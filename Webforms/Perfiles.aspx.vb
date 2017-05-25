Imports ingNovar.Utilidades2

Partial Class Perfiles
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

        If Request.QueryString.Item("Refrescar") = 1 Then
            Dim objPerfiles As PerfilesBrl = PerfilesBrl.CargarPorID(Request.QueryString.Item("ID"))

            If objPerfiles Is Nothing Then
                lblMensaje.Text = "Registro no existe"
                lblMensaje.Visible = True
                Exit Sub
            End If

            txtdescripcion.Text = objPerfiles.Descripcion
            chk_Administrador.Checked = objPerfiles.Administrador
        End If

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Validate()
        If Not IsValid Then Exit Sub

        Dim ID As Int32

        Try
            ID = Grabar()
            Response.Redirect("Perfiles.aspx?Refrescar=1&Mensaje=1&ID=" & ID)
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
            Response.Redirect("Perfiles.aspx?Mensaje=1")
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub
    
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Session.Remove("Perfiles")
        Response.Redirect("PerfilesList.aspx?Refrescar=1")
	End Sub

    Private Function Grabar() As Int32

        Dim objPerfiles As PerfilesBRL

        If Request.QueryString.Item("Refrescar") = 1 Then
            objPerfiles = PerfilesBrl.CargarPorID(Request.QueryString.Item("ID"))
        Else
            objPerfiles = New PerfilesBrl
        End If

        objPerfiles.Descripcion = txtdescripcion.Text
        If chk_Administrador.Checked Then
            objPerfiles.Administrador = 1
        Else
            objPerfiles.Administrador = 0
        End If

        objPerfiles.Guardar()

        Return objPerfiles.ID

    End Function
    
    Protected Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim objPerfiles As PerfilesBrl

        Try
            If Request.QueryString.Item("Refrescar") = 1 Then
                objPerfiles = PerfilesBrl.CargarPorID(Request.QueryString.Item("ID"))
                objPerfiles.Eliminar()
                Response.Redirect("Perfiles.aspx?Mensaje=1")
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Session.Remove("TiposUnidad")
        Response.Redirect("../webforms/PerfilesList.aspx?Refrescar=1")
    End Sub

    Protected Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevo.Click
        Response.Redirect("../webforms/Perfiles.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        If Request.QueryString.Item("Id") > 0 Then
            Response.Redirect("../webforms/Perfiles.aspx?Refrescar=1&Id=" + Request.QueryString.Item("Id"))
        Else
            btn_nuevo_Click(sender, e)
        End If
    End Sub
End Class


