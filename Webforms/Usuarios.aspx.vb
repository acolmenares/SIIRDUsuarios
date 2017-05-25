Imports ingNovar.Utilidades2
Imports System.Text
Imports System.Security.Cryptography

Partial Class Usuarios
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

        BindHelper.PerfilesUIL.BindToListControl(ddl_perfil, New ListItem("Seleccione", 0))
        BindHelper.SucursalesUIL.BindToListControl(ddl_Sucursal, New ListItem("Seleccione", 0))
        txtContrasena.Enabled = True
        revContrasena.Enabled = True
        rfv_Contrasena.Enabled = True


        If Request.QueryString.Item("Refrescar") = 1 Then
            Dim objUsuarios As UsuariosBrl = UsuariosBrl.CargarPorID(Request.QueryString.Item("ID"))

            If objUsuarios Is Nothing Then
                lblMensaje.Text = "Registro no existe"
                lblMensaje.Visible = True
                Exit Sub
            End If

            txtLogin.Text = Trim(objUsuarios.Login)
            txtContrasena.Enabled = False
            revContrasena.Enabled = False
            rfv_Contrasena.Enabled = False
            'txtContrasena.Text = Trim(objUsuarios.Contrasena)
            txtNombre_Completo.Text = Trim(objUsuarios.Nombre_Completo)
            txtCorreo.Text = Trim(objUsuarios.Correo)
            ddl_perfil.SelectedValue = objUsuarios.Id_Perfil
            chkActivo.Checked = objUsuarios.Activo
            ddl_Sucursal.SelectedValue = objUsuarios.Id_Sucursal
        End If

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Validate()
        If Not IsValid Then Exit Sub

        Dim ID As Int32

        Try
            ID = Grabar()
            Response.Redirect("Usuarios.aspx?Refrescar=1&Mensaje=1&ID=" & ID)
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
            Response.Redirect("Usuarios.aspx?Mensaje=1")
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Session.Remove("Usuarios")
        Response.Redirect("UsuariosList.aspx?Refrescar=1")
    End Sub

    Private Function Grabar() As Int32

        Dim objUsuarios As UsuariosBrl

        If Request.QueryString.Item("Refrescar") = 1 Then
            objUsuarios = UsuariosBrl.CargarPorID(Request.QueryString.Item("ID"))
        Else
            objUsuarios = New UsuariosBrl
        End If

        objUsuarios.Login = Trim(txtLogin.Text)
        If Not (Request.QueryString.Item("Refrescar") = 1) Then
            objUsuarios.Contrasena = generarClaveSHA1(txtContrasena.Text)
        End If
        objUsuarios.Nombre_Completo = Trim(txtNombre_Completo.Text)
        objUsuarios.Correo = Trim(txtCorreo.Text)
        objUsuarios.Activo = chkActivo.Checked
        objUsuarios.Id_Perfil = ddl_perfil.SelectedValue
        objUsuarios.Id_Sucursal = ddl_Sucursal.SelectedValue
        objUsuarios.Guardar()

        Return objUsuarios.ID

    End Function

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim objUsuarios As UsuariosBrl
        Try
            If Request.QueryString.Item("Refrescar") = 1 Then
                objUsuarios = UsuariosBrl.CargarPorID(Request.QueryString.Item("ID"))
                objUsuarios.Eliminar()
                Response.Redirect("Usuarios.aspx?Mensaje=1")
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
            lblMensaje.Visible = True
        End Try

    End Sub
    
    Private Function generarClaveSHA1(ByVal nombre As String) As String
        ' Crear una clave SHA1 como la generada por 
        ' FormsAuthentication.HashPasswordForStoringInConfigFile
        ' Adaptada del ejemplo de la ayuda en la descripción de SHA1 (Clase)
        Dim enc As New UTF8Encoding
        Dim data() As Byte = enc.GetBytes(nombre)
        Dim result() As Byte

        Dim sha As New SHA1CryptoServiceProvider
        ' This is one implementation of the abstract class SHA1.
        result = sha.ComputeHash(data)
        '
        ' Convertir los valores en hexadecimal
        ' cuando tiene una cifra hay que rellenarlo con cero
        ' para que siempre ocupen dos dígitos.
        Dim sb As New StringBuilder
        For i As Integer = 0 To result.Length - 1
            If result(i) < 16 Then
                sb.Append("0")
            End If
            sb.Append(result(i).ToString("x"))
        Next
        '
        Return sb.ToString.ToUpper
    End Function

    Protected Sub btn_home_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_home.Click
        Response.Redirect("../webforms/Principal.aspx")
    End Sub

    Protected Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_cerrar.Click
        Session.Remove("TiposUnidad")
        Response.Redirect("../webforms/UsuariosList.aspx?Refrescar=1")
    End Sub

    Protected Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_nuevo.Click
        Response.Redirect("../webforms/Usuarios.aspx")
    End Sub

    Protected Sub btn_actualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btn_actualizar.Click
        If Request.QueryString.Item("Id") > 0 Then
            Response.Redirect("../webforms/Usuarios.aspx?Refrescar=1&Id=" + Request.QueryString.Item("Id"))
        Else
            btn_nuevo_Click(sender, e)
        End If
    End Sub
End Class


