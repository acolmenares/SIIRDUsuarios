<%@ page language="vb" MasterPageFile="~/Controles/MasterPage.master" autoeventwireup="false" codefile="Paginas.aspx.vb" inherits="Paginas" Title ="Edición consulta de Páginas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
    </telerik:RadScriptManager>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    
    <table id="TablaContenido" cellspacing="0" cellpadding="0" border="0" class="ContentTable" style="width: 100%">
        <tr valign="top">
        <td style="width: 75%"> 
            <asp:Label ID="lbl_Titulo" runat="server" Text="CREACION / MODIFICACION DE PAGINAS" Width="90%" CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
            <asp:Label ID="lblMensaje" runat="server" CssClass="TitMensaje" Text="_" Width="90%" Visible="False"/>
        </td>
        <td style="width: 25%" align="right">
            <asp:ImageButton ID="btn_actualizar" runat="server" ImageUrl="~/Images/Reload.jpg" ToolTip="Actualizar la vista actual." />
            <asp:ImageButton ID="btn_nuevo" runat="server" ImageUrl="~/Images/Add.jpg" ToolTip="Crear Nuevo Registro." />
            <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." />
            <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." />&nbsp;</td>
        </tr>

        <tr valign="top">
            <td>
                <table id="tblContenido" class="EditControlsTable" cellspacing="0" cellpadding="0" border="0" style="width: 100%">
                    <tr valign="top">
                        <td  class="LabelCell" style="width: 30%">
                        </td>
                        <td class="ControlCell" style="width: 70%">
                            </td>
                    </tr>

                    <tr valign="top" >
                        <td  class="LabelCell" style="width: 30%">
                            <asp:Label id="lblDescripcion" runat="server">Nombre de la página</asp:Label>
                        </td>
                        <td class="ControlCell" style="width: 70%">
                                <telerik:radtextbox skin="Outlook"  id="txtdescripcion" runat = "server" Width="464px"></telerik:radtextbox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtdescripcion"
                                    ErrorMessage="Falta Nombre Página" EnableClientScript="False">*</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr valign="top">
                            <td class="LabelCell" style="width: 30%;">
                                <asp:Label ID="Label1" runat="server">Dirección URL Módulo</asp:Label></td>
                            <td class="ControlCell" style="width: 70%;">
                                <telerik:radtextbox skin="Outlook"  id="txturl" runat = "server" Width="464px">
                                </telerik:RadTextBox><asp:RequiredFieldValidator ID="rfv_url" runat="server" ControlToValidate="txturl"
                                    ErrorMessage="Falta Dirección URL Módulo" EnableClientScript="False">*</asp:RequiredFieldValidator></td>
                    </tr>
                </table>
            </td>
            <td style="width: 33%"></td>
        </tr>
    </table>
    
    <asp:Panel ID="pnl_final" runat="server" Width="100%" style="vertical-align: middle; text-align: center" >
    <table border="0" cellpadding="0" cellspacing="0" style="width: 90%">
        <tr valign="top">
            <td style="width: 15%; height: 20px;">
            </td>
            <td style="width: 15%; height: 20px;">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" cssClass="Boton" Width="100px"></asp:Button>
            </td>
            <td style="width: 16%; height: 20px;">
                <asp:Button ID="btnGuardarOtro" runat="server" Text="Guardar y agregar otro" cssClass="Boton" Width="150px"></asp:Button>
            </td>
            <td style="width: 15%; height: 20px;">
                <asp:Button ID="btnEliminar" runat="server" Text='Eliminar' CssClass="Boton" Width="100px"></asp:Button>
            </td>
            <td style="width: 15%; height: 20px;">
                <asp:Button ID="btnCerrar" runat="server" Text="Cerrar" cssClass="Boton" Width="100px"></asp:Button>
            </td>
            <td style="width: 15%; height: 20px;">
            </td>
        </tr>
    </table>
    </asp:Panel>                         
</asp:content>