Imports ingNovar.Utilidades2

Partial Class Permisos_Usuario
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If IsPostBack Then Exit Sub

        If Session("IdUsuario") Is Nothing Then
            Session.RemoveAll()
            Response.Redirect("../login.aspx")
            Exit Sub
        End If

        Dim lblidUsuario As Label
        lblidUsuario = Master.FindControl("lblidusuario")
        lblidUsuario.Text = Session("IdUsuario")

        Dim LblNombreUsuario As Label
        LblNombreUsuario = Master.FindControl("LblNombreUsuario")
        LblNombreUsuario.Text = Session("NombreUsuario")

        Dim Lbl_regional As Label
        Lbl_regional = Master.FindControl("Lbl_regional")
        Lbl_regional.Text = Session("NombreRegional")

        Dim Lbl_usuario As Label
        Lbl_usuario = Master.FindControl("Lbl_usuario")
        Lbl_usuario.Text = Session("LoginUsuario")

        Dim Lbl_perfil As Label
        Lbl_perfil = Master.FindControl("Lbl_perfil")
        Lbl_perfil.Text = Session("NombrePerfil")

        If Request.QueryString.Item("Mensaje") = 1 Then
            lblMensaje.Text = "Operación exitosa"
            lblMensaje.Visible = True
        End If

        
        BindHelper.PaginasUIL.BindToListControl(ddlPaginas, New ListItem("Seleccione", 0))
        BindHelper.UsuariosUIL.BindToListControl(ddlUsuarios, New ListItem("Seleccione", 0))


        If Request.QueryString.Item("Refrescar") = 1 Then
            Dim objPermisos_Usuario As Permisos_UsuarioBrl = Permisos_UsuarioBrl.CargarPorID(Request.QueryString.Item("ID"))

            If objPermisos_Usuario Is Nothing Then
                lblMensaje.Text = "Registro no existe"
                lblMensaje.Visible = True
                Exit Sub
            End If

            If ddlPaginas.Items.FindByValue(objPermisos_Usuario.Id_Pagina) IsNot Nothing Then ddlPaginas.SelectedValue = objPermisos_Usuario.Id_Pagina
            If ddlUsuarios.Items.FindByValue(objPermisos_Usuario.Id_Usuario) IsNot Nothing Then ddlUsuarios.SelectedValue = objPermisos_Usuario.Id_Usuario
            chkPver.Checked = objPermisos_Usuario.Pver
            chkPconsultar.Checked = objPermisos_Usuario.Pconsultar
            chkPexportarpdf.Checked = objPermisos_Usuario.Pexportarpdf
            chkPexportarword.Checked = objPermisos_Usuario.Pexportarword
            chkPexportarcsv.Checked = objPermisos_Usuario.Pexportarcsv
            chkPexportarexcel.Checked = objPermisos_Usuario.Pexportarexcel
            chkPcrear.Checked = objPermisos_Usuario.Pcrear
            chkPeditar.Checked = objPermisos_Usuario.Peditar
            chkPeliminar.Checked = objPermisos_Usuario.Peliminar
            ChkPvertodo.Checked = objPermisos_Usuario.Pvertodo
            chkPcontrolvisible.Checked = objPermisos_Usuario.Pcontrolvisible

        End If

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Validate()
        If Not IsValid Then Exit Sub

        Dim ID As Int32

        Try
            ID = Grabar()
            Response.Redirect("Permisos_Usuario.aspx?Refrescar=1&Mensaje=1&ID=" & ID)
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Private Sub btnGuardarOtro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarOtro.Click
		Validate()
        If Not IsValid Then Exit Sub
        
        Try
			Grabar()
            Response.Redirect("Permisos_Usuario.aspx?Mensaje=1")
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub
    
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Session.Remove("Permisos_Usuario")
        Response.Redirect("Permisos_UsuarioList.aspx?Refrescar=1")
	End Sub

    Private Function Grabar() As Int32

        Dim objPermisos_Usuario As Permisos_UsuarioBRL

        If Request.QueryString.Item("Refrescar") = 1 Then
            objPermisos_Usuario = Permisos_UsuarioBrl.CargarPorID(Request.QueryString.Item("ID"))
        Else
            objPermisos_Usuario = New Permisos_UsuarioBrl
        End If

        objPermisos_Usuario.Id_Pagina = ddlPaginas.SelectedValue
        objPermisos_Usuario.Id_Usuario = ddlUsuarios.SelectedValue
        objPermisos_Usuario.Pver = chkPver.Checked
        objPermisos_Usuario.Pconsultar = chkPconsultar.Checked
        objPermisos_Usuario.Pexportarpdf = chkPexportarpdf.Checked
        objPermisos_Usuario.Pexportarword = chkPexportarword.Checked
        objPermisos_Usuario.Pexportarcsv = chkPexportarcsv.Checked
        objPermisos_Usuario.Pexportarexcel = chkPexportarexcel.Checked
        objPermisos_Usuario.Pcrear = chkPcrear.Checked
        objPermisos_Usuario.Peditar = chkPeditar.Checked
        objPermisos_Usuario.Peliminar = chkPeliminar.Checked
        objPermisos_Usuario.Pvertodo = ChkPvertodo.Checked
        objPermisos_Usuario.Pcontrolvisible = chkPcontrolvisible.Checked
        objPermisos_Usuario.Guardar()
        
        Return objPermisos_Usuario.ID

    End Function

    Protected Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim objPermisos_Usuario As Permisos_UsuarioBrl

        Try
            If Request.QueryString.Item("Refrescar") = 1 Then
                objPermisos_Usuario = Permisos_UsuarioBrl.CargarPorID(Request.QueryString.Item("ID"))
                objPermisos_Usuario.Eliminar()
                Response.Redirect("Permisos_Usuario.aspx?Mensaje=1")
            End If
        Catch ex As Exception
            lblmensaje.Text = ex.Message
            lblmensaje.Visible = True
        End Try
    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Session.Remove("TiposUnidad")
        Response.Redirect("../webforms/Permisos_UsuarioList.aspx?Refrescar=1")
    End Sub

    Protected Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevo.Click
        Response.Redirect("../webforms/Permisos_Usuario.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        If Request.QueryString.Item("Id") > 0 Then
            Response.Redirect("../webforms/Permisos_Usuario.aspx?Refrescar=1&Id=" + Request.QueryString.Item("Id"))
        Else
            btn_nuevo_Click(sender, e)
        End If
    End Sub

End Class


