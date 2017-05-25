<%@ page language="vb" MasterPageFile="~/Controles/MasterPage.master" autoeventwireup="false" codefile="Permisos_Usuario.aspx.vb" inherits="Permisos_Usuario" Title ="Edición consulta de Permisos de Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
    </telerik:RadScriptManager>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    
    <table id="TablaContenido" cellspacing="0" cellpadding="0" border="0" class="ContentTable" style="width: 100%">
        <tr valign="top">
        <td style="width: 75%"> 
            <asp:Label ID="lbl_Titulo" runat="server" Text="CREACION / MODIFICACION DE PERMISOS POR USUARIO" Width="90%" CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
            <asp:Label ID="lblMensaje" runat="server" CssClass="TitMensaje" Text="_" Width="90%" Visible="False"/>
        </td>
        <td style="width: 25%" align="right">
            <asp:ImageButton ID="btn_actualizar" runat="server" ImageUrl="~/Images/Reload.jpg" ToolTip="Actualizar la vista actual." />
            <asp:ImageButton ID="btn_nuevo" runat="server" ImageUrl="~/Images/Add.jpg" ToolTip="Crear Nuevo Registro." />
            <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." />
            <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." />&nbsp;</td>
        </tr>

        <tr valign="top">
            <td colspan="2">
                <table id="tblContenido" class="EditControlsTable" cellspacing="0" cellpadding="0" border="0" style="width: 100%">
                         <tr valign="top" >
                              <td  class="LabelCell" style="width: 25%; vertical-align: middle; height: 50px; text-align: center;" >
                                <asp:Label id="lblDescripcion" runat="server" CssClass="LabelsDigitar">Nombre del Usuario</asp:Label>
                              </td>
                              <td class="ControlCell" style="width: 25%; vertical-align: middle; height: 50px; text-align: center;" >
                                    <asp:dropdownlist id="ddlUsuarios" runat="server" Font-Size="X-Small" CssClass="drop01" Width="90%" />
                                    <asp:requiredfieldvalidator id="rfvId_Usuario" runat="server" EnableClientScript="False" ErrorMessage="Falta la información de Uusario" ControlToValidate="ddlPerfiles">*</asp:requiredfieldvalidator>
                                    <asp:regularexpressionvalidator id="revId_Usuario" runat="server" EnableClientScript="False" ErrorMessage="El valor ingresado para Usuario no es válido"  ControlToValidate="ddlUsuarios" ValidationExpression="(?!0).*">*</asp:regularexpressionvalidator>
                              </td>
                              <td style="width: 25%; vertical-align: middle; height: 50px; text-align: center;">
                                <asp:Label id="Label2" runat="server" CssClass="LabelsDigitar">Nombre de la Página</asp:Label></td>
                              <td  class="LabelCell" style="width: 25%; vertical-align: middle; height: 50px; text-align: center;" >
                                    <asp:dropdownlist id="ddlPaginas" runat="server" Font-Size="X-Small" Width="90%" CssClass="drop01" ></asp:dropdownlist>        
                                    <asp:requiredfieldvalidator id="rfvId_Pagina" runat="server" EnableClientScript="False" ErrorMessage="Falta información de Página" ControlToValidate="ddlPaginas">*</asp:requiredfieldvalidator>
                                    <asp:regularexpressionvalidator id="revId_Pagina" runat="server" EnableClientScript="False" ErrorMessage="El valor ingresado para Página no es válido"  ControlToValidate="ddlPaginas" ValidationExpression="(?!0).*">*</asp:regularexpressionvalidator></td>
                              
                         </tr>

                         <tr valign="top">
                            <td style="width: 25%; vertical-align: middle; height: 50px; text-align: center;">
                                <asp:checkbox id="chkPver" runat="server" Text="Ver" Font-Size="X-Small" ForeColor="Navy" Width="70%"  ></asp:checkbox>   
                            </td>
                            <td style="width: 25%; vertical-align: middle; height: 50px; text-align: center;">
                                <asp:checkbox id="chkPconsultar" runat="server" Text="Consultar" Font-Size="X-Small" ForeColor="Navy" Width="70%"  ></asp:checkbox>       
                            </td>
                            <td style="width: 25%; vertical-align: middle; height: 50px; text-align: center;">
                                <asp:checkbox id="chkPexportarpdf" runat="server" Text="Exportar PDF" Font-Size="X-Small" ForeColor="Navy" Width="70%"  ></asp:checkbox>
                            </td>
                            <td style="width: 25%; vertical-align: middle; height: 50px; text-align: center;">
                                <asp:checkbox id="chkPexportarword" runat="server" Text="Exportar Word" Font-Size="X-Small" ForeColor="Navy" Width="70%"  ></asp:checkbox>         
                            </td>

                         </tr>
                    <tr valign="top">
                        <td style="vertical-align: middle; width: 25%; height: 50px; text-align: center">
                                <asp:checkbox id="chkPexportarcsv" runat="server" Text="Exportar CSV" Font-Size="X-Small" ForeColor="Navy" Width="70%"  ></asp:checkbox></td>
                        <td style="vertical-align: middle; width: 25%; height: 50px; text-align: center">
                            <asp:CheckBox ID="chkPexportarexcel" runat="server" Font-Size="X-Small" ForeColor="Navy"
                                Text="Exportar XLS" Width="70%" /></td>
                        <td style="vertical-align: middle; width: 25%; height: 50px; text-align: center">
                                <asp:checkbox id="chkPcrear" runat="server" Text="Crear" Font-Size="X-Small" ForeColor="Navy" Width="70%"  ></asp:checkbox></td>
                        <td style="vertical-align: middle; width: 25%; height: 50px; text-align: center">
                                <asp:checkbox id="chkPeditar" runat="server" Text="Editar" Font-Size="X-Small" ForeColor="Navy" Width="70%"  ></asp:checkbox></td>
                    </tr>
                    <tr valign="top">
                        <td style="vertical-align: middle; width: 25%; height: 50px; text-align: center">
                                <asp:checkbox id="chkPeliminar" runat="server" Text="Eliminar" Font-Size="X-Small" ForeColor="Navy" Width="70%"  ></asp:checkbox></td>
                        <td style="vertical-align: middle; width: 25%; height: 50px; text-align: center">
                            <asp:CheckBox ID="ChkPvertodo" runat="server" Font-Size="X-Small" ForeColor="Navy"
                                Text="Ver Todo" ToolTip="Quita el Control de la Sucursal" Width="70%" /></td>
                        <td style="vertical-align: middle; width: 25%; height: 50px; text-align: center">
                            <asp:CheckBox ID="chkPcontrolvisible" runat="server" Font-Size="X-Small" ForeColor="Navy"
                                Text="Control Visible" ToolTip="Control de Acceso a registros que no manejan sucursal"
                                Width="70%" /></td>
                        <td style="vertical-align: middle; width: 25%; height: 50px; text-align: center">
                        </td>
                    </tr>
                   </table>
                </td>
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
        
