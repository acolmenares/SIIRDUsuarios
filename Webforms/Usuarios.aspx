<%@ page language="vb" MasterPageFile="~/Controles/MasterPage.master" autoeventwireup="false" codefile="Usuarios.aspx.vb" inherits="Usuarios" Title ="Edición consulta de Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
    </telerik:RadScriptManager>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    
    <table id="TablaContenido" cellspacing="0" cellpadding="0" border="0" class="ContentTable" style="width: 100%">
        <tr valign="top">
        <td style="width: 75%"> 
            <asp:Label ID="lbl_Titulo" runat="server" Text="CREACION / MODIFICACION DE USUARIOS" Width="90%" CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
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

                            			
                            <tr valign="top" ><td  class="LabelCell" style="width: 20%">
                            <asp:Label id="lblLogin" runat="server" CssClass="LabelsDigitar" Width="90%">Login de Acceso</asp:Label>


                            </td><td class="ControlCell" style="width: 80%">
                             <telerik:radtextbox skin="Outlook"  id="txtLogin" runat = "server" MaxLength="15"></telerik:radtextbox>      



                            <asp:regularexpressionvalidator id="revLogin" runat="server" EnableClientScript="False" ErrorMessage="El valor ingresado para Login no es válido"  ControlToValidate="txtLogin" ValidationExpression=".{0,15}">*</asp:regularexpressionvalidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLogin"
                                    ErrorMessage="Debe Digitarse Usuario de Acceso" EnableClientScript="False">*</asp:RequiredFieldValidator></td></tr>

                            <tr valign="top" ><td  class="LabelCell" style="width: 20%">
                            <asp:Label id="lblContrasena" runat="server" CssClass="LabelsDigitar" Width="90%">Contraseña</asp:Label>


                            </td><td class="ControlCell" style="width: 80%">
                             <telerik:radtextbox skin="Outlook"   TextMode="Password" id="txtContrasena" runat = "server" MaxLength="15"></telerik:radtextbox>      



                            <asp:regularexpressionvalidator id="revContrasena" runat="server" EnableClientScript="False" ErrorMessage="El valor ingresado para Contraseña no es válido"  ControlToValidate="txtContrasena" ValidationExpression=".{0,15}">*</asp:regularexpressionvalidator>
                                <asp:RequiredFieldValidator ID="rfv_Contrasena" runat="server" ControlToValidate="txtContrasena"
                                    ErrorMessage="Debe Digitarse Contraseña" EnableClientScript="False">*</asp:RequiredFieldValidator></td></tr>

                            <tr valign="top" ><td  class="LabelCell" style="width: 20%">
                            <asp:Label id="lblNombre_Completo" runat="server" CssClass="LabelsDigitar" Width="90%">Nombre Completo</asp:Label>


                            </td><td class="ControlCell" style="width: 80%">
                             <telerik:radtextbox skin="Outlook"  id="txtNombre_Completo" runat = "server" Width="464px" MaxLength="100"></telerik:radtextbox>      



                            <asp:regularexpressionvalidator id="revNombre_Completo" runat="server" EnableClientScript="False" ErrorMessage="El valor ingresado para Nombre_Completo no es válido"  ControlToValidate="txtNombre_Completo" ValidationExpression=".{0,100}">*</asp:regularexpressionvalidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtNombre_Completo"
                                    ErrorMessage="Falta Nombre Completo" EnableClientScript="False">*</asp:RequiredFieldValidator></td></tr>

                            <tr valign="top" ><td  class="LabelCell" style="width: 20%">
                            <asp:Label id="lblCorreo" runat="server" CssClass="LabelsDigitar" Width="90%">Correo</asp:Label>


                            </td><td class="ControlCell" style="width: 80%">
                             <telerik:radtextbox skin="Outlook"  id="txtCorreo" runat = "server" Width="464px" MaxLength="100"></telerik:radtextbox>      



                            <asp:regularexpressionvalidator id="revCorreo" runat="server" EnableClientScript="False" ErrorMessage="El valor ingresado para Correo no es válido"  ControlToValidate="txtCorreo" ValidationExpression=".{0,100}">*</asp:regularexpressionvalidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtCorreo"
                                    ErrorMessage="Falta Correo Electrónico" Width="1px" EnableClientScript="False">*</asp:RequiredFieldValidator></td></tr>
                        <tr valign="top">
                            <td class="LabelCell" style="width: 20%">
                                <asp:Label ID="Label1" runat="server" CssClass="LabelsDigitar" Width="90%">Perfil</asp:Label></td>
                            <td class="ControlCell" style="width: 80%">
                                <asp:DropDownList ID="ddl_perfil" runat="server" Font-Size="X-Small" Width="300px">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="rfv_perfil" runat="server" ErrorMessage="Falta dato de Perfil" ControlToValidate="ddl_perfil" EnableClientScript="False">*</asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="revId_Perfil" runat="server" ControlToValidate="ddl_perfil"
                                    EnableClientScript="False" ErrorMessage="El valor ingresado de perfil no es válido"
                                    ValidationExpression="(?!0).*">*</asp:RegularExpressionValidator></td>
                        </tr>

                            <tr valign="top" ><td  class="LabelCell" style="width: 20%; height: 14px;">
                                <asp:Label ID="Label2" runat="server" CssClass="LabelsDigitar" Width="90%">Sucursal donde labora</asp:Label></td><td class="ControlCell" style="width: 80%; height: 14px;"><asp:DropDownList ID="ddl_Sucursal" runat="server" Font-Size="X-Small" Width="300px">
                            </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="ddl_Sucursal"
                                        EnableClientScript="False" ErrorMessage="Falta dato de Sucursal">*</asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="ddl_Sucursal"
                                        EnableClientScript="False" ErrorMessage="El valor ingresado de Sucursal no es válido"
                                        ValidationExpression="(?!0).*">*</asp:RegularExpressionValidator></td></tr>
                    <tr valign="top">
                        <td class="LabelCell" style="width: 20%">
                            <asp:Label id="lblActivo" runat="server" CssClass="LabelsDigitar" Width="90%">Activo</asp:Label></td>
                        <td class="ControlCell" style="width: 80%">
                            <asp:checkbox id="chkActivo" runat="server" Text=""  ></asp:checkbox></td>
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