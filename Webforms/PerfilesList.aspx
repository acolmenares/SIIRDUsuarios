<%@ Page Language="VB" MasterPageFile="~/Controles/MasterPage.master" AutoEventWireup="false" CodeFile="PerfilesList.aspx.vb" Inherits="ListPerfiles" title="Vista de Perfiles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
    </telerik:RadScriptManager>
    <table id="tbl_Interna" border="0" cellpadding="1" cellspacing="0" width="100%" style="border-right: whitesmoke thin solid; border-top: whitesmoke thin solid; border-left: whitesmoke thin solid; border-bottom: whitesmoke thin solid">
        <tr>
        <td style="width: 75%;"> 
            <asp:Label ID="lbl_Titulo" runat="server" Text="VISTA GENERAL DE PERFILES" Width="100%" CssClass="TitTitulo" BackColor="PeachPuff"></asp:Label><br />
            <asp:Label ID="lblMensaje" runat="server" CssClass="TitMensaje" Text="_" Width="100%" Visible="False"></asp:Label></td>
        <td style="width: 25%" align="right">
            <asp:ImageButton ID="btn_actualizar" runat="server" ImageUrl="~/Images/Reload.jpg" ToolTip="Actualizar la vista actual." />
            <asp:ImageButton ID="btn_buscar" runat="server" ImageUrl="~/Images/Zoom In.jpg" ToolTip="Ver/quitar Sistema de Búsqueda." Visible="False" />
            <asp:ImageButton ID="btn_nuevo" runat="server" ImageUrl="~/Images/Add.jpg" ToolTip="Crear Nuevo Registro." />
            <asp:ImageButton ID="btn_cerrar" runat="server" ImageUrl="~/Images/Stop.jpg" ToolTip="Cerrar - Volver a la vista anterior." />
            <asp:ImageButton ID="btn_home" runat="server" ImageUrl="~/Images/Home.jpg" ToolTip="Ir al Inicio." />&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" align="center" >
                <asp:Panel ID="pnl_buscar" runat="server" Width="90%" style="text-align: center; border-right: palegoldenrod thin ridge; border-top: palegoldenrod thin ridge; border-left: palegoldenrod thin ridge; border-bottom: palegoldenrod thin ridge;" Visible="False" >
                   
                    <table border="0" cellpadding="0" cellspacing="0" style="width: 100%" >
                        <tr>
                            <td colspan="5" style="text-align: left" align="left">
                                <asp:Label ID="Label1" runat="server" Text="Sistema de Búsqueda Selectiva" Width="90%" Font-Bold="True" Font-Underline="False"></asp:Label></td>
                            <td style="width: 15%" align="right">
                                <asp:ImageButton ID="btn_Procesar" runat="server" ImageUrl="~/Images/Search.jpg" ToolTip="Realizar la Búsqueda." />
                                <asp:ImageButton ID="btn_limpiar" runat="server" ImageUrl="~/Images/New.jpg" ToolTip="Limpiar Campos Búsqueda." /></td>
                        </tr>
                        <tr>
                            <td style="width: 15%;" align="left">
                                </td>
                            <td style="width: 15%;" align="left">
                                &nbsp;</td>
                            <td style="width: 15%;" align="left">
                                </td>
                            <td style="width: 15%;" align="left">
                                &nbsp;</td>
                            <td style="width: 15%" align="left">
                                </td>
                            <td style="width: 15%" align="left">
                                </td>
                        </tr>
                    </table>
                    
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <telerik:RadGrid ID="Rg_Listado" runat="server" AllowPaging="True" AllowSorting="True" 
                      AutoGenerateColumns="False" GridLines="None" Skin="Office2007" ShowStatusBar ="True" PageSize="15">
                      <MasterTableView NoDetailRecordsText="No hay informaci&#243;n." NoMasterRecordsText="No hay informaci&#243;n."  
                      CommandItemDisplay ="Top" DataKeyNames="Id">
                      <Columns>
                         <telerik:GridTemplateColumn HeaderText="No." UniqueName="TemplateColumn">
                            <ItemTemplate>
                              <%#CType(CType(Container.Parent.Parent, GridTableView).DataSource, IList).IndexOf(Container.DataItem) + 1%>
                            </ItemTemplate>
                            <ItemStyle Width="50px" />
                         </telerik:GridTemplateColumn>                         

                         <telerik:GridBoundColumn DataField="Id"   UniqueName="Id" Visible ="false" >
                         </telerik:GridBoundColumn>
                         
                         <telerik:GridBoundColumn DataField="Descripcion" EmptyDataText="" 
                             HeaderText="Descripción" SortExpression="Descripcion" UniqueName="Descripcion">
                             <ItemStyle  Width="500px"  HorizontalAlign ="Left"/>
                             <HeaderStyle Width="500px" HorizontalAlign ="Center" />                                 
                         </telerik:GridBoundColumn>

                         <telerik:GridTemplateColumn UniqueName="Admin"  HeaderText="Admin" DataField="Administrador" DefaultInsertValue="" >
                                <ItemTemplate>
							       <asp:CheckBox ID="chk_admin" runat="Server" Enabled="False" ToolTip="PAdminstrador"  Checked = '<%# Container.DataItem.Administrador %>' />
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Center" Width ="100px" />
                                <ItemStyle HorizontalAlign ="Center" Width ="100px" />
                         </telerik:GridTemplateColumn>

                        
                    </Columns>
                    <PagerStyle Mode="NumericPages" FirstPageToolTip="Primera" LastPageToolTip="Ultima" NextPagesToolTip="Pr&#243;ximas" NextPageToolTip="Pr&#243;xima" PagerTextFormat="Cambiar P&#225;gina: {4} &amp;nbsp;P&#225;gina &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, registros &lt;strong&gt;{2}&lt;/strong&gt; a &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;." PrevPageToolTip="Anterior"  PrevPagesToolTip ="Anteriores"/>
                    <CommandItemSettings ExportToCsvText ="Exportar a CSV" ExportToExcelText ="Exportar a Excel" ExportToPdfText ="Exportar a PDF"
                         ExportToWordText ="Exportar a Word" RefreshText ="Actualizar" AddNewRecordText =""  AddNewRecordImageUrl ="~/images/nothing.gif"
                          ShowExportToCsvButton="True" ShowExportToExcelButton="True" ShowExportToPdfButton="True" ShowExportToWordButton ="True"/>

                </MasterTableView>
                <ClientSettings EnablePostBackOnRowClick="True" EnableRowHoverStyle ="True" >
                    <Selecting AllowRowSelect="True" />
                </ClientSettings>
                 <ExportSettings
                   HideStructureColumns="True" FileName ="Perfiles" 
                   ExportOnlyData="True"  IgnorePaging="True" OpenInNewWindow="True">
                </ExportSettings>

                <SortingSettings SortToolTip="Clic aqui para ordenar" SortedAscToolTip="Ordenar Ascendente" SortedDescToolTip="Ordenar Descendente" />
                <PagerStyle Mode="NumericPages" />
            </telerik:RadGrid>                                    
            </td>
        </tr>
        <tr>
            <td colspan="2" align="left">
                <asp:Panel ID="pnl_final" runat="server" Width="100%" style="vertical-align: middle; text-align: center" Visible="False" >
                    <table border="0" cellpadding="1" cellspacing="1" style="width: 90%">
                        <tr>
                            <td style="width: 15%; height: 16px;">
                            </td>
                            <td style="width: 15%; height: 16px;">
                            </td>
                            <td style="width: 16%; height: 16px;">
                            </td>
                            <td style="width: 15%; height: 16px;">
                            </td>
                            <td style="width: 15%; height: 16px;">
                            </td>
                            <td style="width: 15%; height: 16px;">
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>
                                  


