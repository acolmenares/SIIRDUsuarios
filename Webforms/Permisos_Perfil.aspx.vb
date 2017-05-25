Imports ingNovar.Utilidades2

Partial Class Permisos_Perfil
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
        
        BindHelper.PerfilesUIL.BindToListControl(ddlPerfiles, New ListItem("Seleccione", 0))
        BindHelper.PaginasUIL.BindToListControl(ddlPaginas, New ListItem("Seleccione", 0))


        If Request.QueryString.Item("Refrescar") = 1 Then
            Dim objPermisos_Perfil As Permisos_PerfilBrl = Permisos_PerfilBrl.CargarPorID(Request.QueryString.Item("ID"))

            If objPermisos_Perfil Is Nothing Then
                lblMensaje.Text = "Registro no existe"
                lblMensaje.Visible = True
                Exit Sub
            End If

            If ddlPerfiles.Items.FindByValue(objPermisos_Perfil.Id_Perfil) IsNot Nothing Then ddlPerfiles.SelectedValue = objPermisos_Perfil.Id_Perfil
            If ddlPaginas.Items.FindByValue(objPermisos_Perfil.Id_Pagina) IsNot Nothing Then ddlPaginas.SelectedValue = objPermisos_Perfil.Id_Pagina
            chkPver.Checked = objPermisos_Perfil.Pver
            chkPconsultar.Checked = objPermisos_Perfil.Pconsultar
            chkPexportarpdf.Checked = objPermisos_Perfil.Pexportarpdf
            chkPexportarword.Checked = objPermisos_Perfil.Pexportarword
            chkPexportarcsv.Checked = objPermisos_Perfil.Pexportarcsv
            chkPexportarexcel.Checked = objPermisos_Perfil.Pexportarexcel
            chkPcrear.Checked = objPermisos_Perfil.Pcrear
            chkPeditar.Checked = objPermisos_Perfil.Peditar
            chkPeliminar.Checked = objPermisos_Perfil.Peliminar
            ChkPvertodo.Checked = objPermisos_Perfil.Pvertodo
            chkPcontrolvisible.Checked = objPermisos_Perfil.Pcontrolvisible

        End If

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Validate()
        If Not IsValid Then Exit Sub

        Dim ID As Int32

        Try
            ID = Grabar()
            Response.Redirect("Permisos_Perfil.aspx?Refrescar=1&Mensaje=1&ID=" & ID)
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
            Response.Redirect("Permisos_Perfil.aspx?Mensaje=1")
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub
    
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Session.Remove("Permisos_Perfil")
        Response.Redirect("Permisos_PerfilList.aspx?Refrescar=1")
	End Sub

    Private Function Grabar() As Int32

        Dim objPermisos_Perfil As Permisos_PerfilBRL

        If Request.QueryString.Item("Refrescar") = 1 Then
            objPermisos_Perfil = Permisos_PerfilBrl.CargarPorID(Request.QueryString.Item("ID"))
        Else
            objPermisos_Perfil = New Permisos_PerfilBrl
        End If

        objPermisos_Perfil.Id_Perfil = ddlPerfiles.SelectedValue
        objPermisos_Perfil.Id_Pagina = ddlPaginas.SelectedValue
        objPermisos_Perfil.Pver = chkPver.Checked
        objPermisos_Perfil.Pconsultar = chkPconsultar.Checked
        objPermisos_Perfil.Pexportarpdf = chkPexportarpdf.Checked
        objPermisos_Perfil.Pexportarword = chkPexportarword.Checked
        objPermisos_Perfil.Pexportarcsv = chkPexportarcsv.Checked
        objPermisos_Perfil.Pexportarexcel = chkPexportarexcel.Checked
        objPermisos_Perfil.Pcrear = chkPcrear.Checked
        objPermisos_Perfil.Peditar = chkPeditar.Checked
        objPermisos_Perfil.Peliminar = chkPeliminar.Checked
        objPermisos_Perfil.Pvertodo = ChkPvertodo.Checked
        objPermisos_Perfil.Pcontrolvisible = chkPcontrolvisible.Checked

        objPermisos_Perfil.Guardar()
        
        Return objPermisos_Perfil.ID

    End Function
    
    Protected Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim objPermisos_Perfil As Permisos_PerfilBrl

        Try
            If Request.QueryString.Item("Refrescar") = 1 Then
                objPermisos_Perfil = Permisos_PerfilBrl.CargarPorID(Request.QueryString.Item("ID"))
                objPermisos_Perfil.Eliminar()
                Response.Redirect("Permisos_Perfil.aspx?Mensaje=1")
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
        Response.Redirect("../webforms/Permisos_PerfilList.aspx?Refrescar=1")
    End Sub

    Protected Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevo.Click
        Response.Redirect("../webforms/Permisos_Perfil.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        If Request.QueryString.Item("Id") > 0 Then
            Response.Redirect("../webforms/Permisos_Perfil.aspx?Refrescar=1&Id=" + Request.QueryString.Item("Id"))
        Else
            btn_nuevo_Click(sender, e)
        End If
    End Sub
End Class


