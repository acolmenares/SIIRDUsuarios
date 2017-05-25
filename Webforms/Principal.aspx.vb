
Partial Class Webforms_Principal
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Me.IsPostBack Then Exit Sub

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

        Me.Header.Title = "Sistema Financiero IRD"


        'Dim objparametros As New ParametrosBrl
        'objparametros = ParametrosBrl.CargarPorID(1)

        'If objparametros Is Nothing Then
        Me.lblcorreo1.Text = "Sin definir"
        Me.lbldireccion1.Text = "Sin definir"
        Me.lblfax1.Text = "Sin definir"
        Me.lblnombre1.Text = "Sin definir"
        Me.Lbltel1.Text = "Sin definir"
        Me.lbloa1.Text = "Sin definir"
        Me.lblweb1.Text = "Sin definir"

        'Else
        'Me.lblcorreo1.Text = objparametros.Correo
        'Me.lblcorreo1.NavigateUrl = "mailto://" + objparametros.Correo
        'Me.lbldireccion1.Text = objparametros.Direccion
        'Me.lblfax1.Text = objparametros.Fax
        'Me.lblnombre1.Text = objparametros.Razon_Social
        'Me.Lbltel1.Text = objparametros.Telefono_Principal
        'Me.lbloa1.Text = objparametros.Observacion_Adicional
        'Me.lblweb1.Text = objparametros.Url
        'Me.lblweb1.NavigateUrl = "http://" + objparametros.Url

        'lbltexto01.Text = objparametros.Texto01
        'lbltexto02.Text = objparametros.Texto02
        'lbltexto03.Text = objparametros.Texto03
        'lbltexto04.Text = objparametros.Texto04

        'End If

    End Sub

End Class
