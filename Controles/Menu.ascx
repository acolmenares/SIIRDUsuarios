<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Menu.ascx.vb" Inherits="Controles_MenuPrueba" %>
<telerik:RadMenu ID="RadMenu1" runat="server" Skin="Windows7" style="left: 0px">
    <Items>
        <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/Seguimiento.aspx" Selected="True"
            Text="Inicio">
        </telerik:RadMenuItem>
        <telerik:RadMenuItem runat="server" Text="Seguridad">
            <Items>
                <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/UsuariosList.aspx" Text="Usuarios">
                </telerik:RadMenuItem>
                <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/PerfilesList.aspx" Text="Perfiles">
                </telerik:RadMenuItem>
                <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/PaginasList.aspx" Text="P&#225;ginas">
                </telerik:RadMenuItem>
              
            </Items>
        </telerik:RadMenuItem>
                <telerik:RadMenuItem runat="server"  Text="Permisos">
                  <items>
                        <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/Permisos_PerfilList.aspx" Text="Por Perfil">
                        </telerik:RadMenuItem>
                        <telerik:RadMenuItem runat="server" NavigateUrl="~/Webforms/Permisos_UsuarioList.aspx" Text="Por Usuario">
                        </telerik:RadMenuItem>                  
                  </items>
                </telerik:RadMenuItem>
        <telerik:RadMenuItem runat="server" Text="Administraci&#243;n">
            <Items>
                <telerik:RadMenuItem runat="server" Text="Sucursales" NavigateUrl="~/Webforms/SucursalesList.aspx" ToolTip="Sucursales / Regionales">
                </telerik:RadMenuItem>
            </Items>
        </telerik:RadMenuItem>
    </Items>
</telerik:RadMenu>&nbsp;<br />
