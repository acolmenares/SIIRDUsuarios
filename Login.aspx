<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Sistema de Información SIIRD</title>
</head>

    
<body bgcolor="#FFFFFF" leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
<form id="form1" runat="server">
<!-- Save for Web Slices (IRD.psd) -->
<table id="Tabla_01" width="800" height="600" border="0" cellpadding="0" cellspacing="0">
	<tr valign="top">
		<td colspan="2">
			<img src="im&#xe1;genes/IRD_01.gif" width="398" height="102" alt=""></td>
		<td colspan="7">
			<img src="im&#xe1;genes/IRD_02.gif" width="402" height="102" alt=""></td>
	</tr>
	<tr valign="top">
		<td colspan="2">
			<img src="im&#xe1;genes/IRD_03.gif" width="398" height="125" alt=""></td>
		<td colspan="7">
			<img src="im&#xe1;genes/IRD_04.gif" width="402" height="125" alt=""></td>
	</tr>
	<tr valign="top">
		<td colspan="2">
			<img src="im&#xe1;genes/IRD_05.gif" width="398" height="113" alt=""></td>
		<td colspan="7">
			<img src="im&#xe1;genes/IRD_06.gif" width="402" height="113" alt=""></td>
	</tr>
	<tr valign="top">
		<td colspan="2">
			<img src="im&#xe1;genes/IRD_07.gif" width="398" height="103" alt=""></td>
		<td colspan="7">
			<img src="im&#xe1;genes/IRD_08.gif" width="402" height="103" alt=""></td>
	</tr>
	<tr valign="top">
		<td colspan="2">
			<img src="im&#xe1;genes/IRD_09.gif" width="398" height="23" alt=""></td>
		<td colspan="7">
			<img src="im&#xe1;genes/IRD_10.gif" width="402" height="23" alt=""></td>
	</tr>
	<tr valign="top">
		<td rowspan="8">
			<img src="im&#xe1;genes/IRD_11.gif" width="153" height="118" alt=""></td>
		<td rowspan="8">
			<img src="im&#xe1;genes/IRD_12.gif" width="245" height="118" alt=""></td>
		<td colspan="7">
			<img src="im&#xe1;genes/IRD_13.gif" width="402" height="25" alt=""></td>
	</tr>
	<tr valign="top">
		<td colspan="2" rowspan="3">
			<img src="im&#xe1;genes/IRD_14.gif" width="168" height="34" alt=""></td>
		<td rowspan="3">
			<img src="im&#xe1;genes/IRD_15.gif" width="18" height="34" alt=""></td>
		<td>
			<img src="im&#xe1;genes/IRD_16.gif" width="143" height="13" alt=""></td>
		<td rowspan="3">
			<img src="im&#xe1;genes/IRD_17.gif" width="17" height="34" alt=""></td>
		<td colspan="2" rowspan="3">
			<img src="im&#xe1;genes/IRD_18.gif" width="56" height="34" alt=""></td>
	</tr>
	<tr valign="top">
		<td valign="top" >
            <asp:TextBox ID="txt_login" runat="server" BorderWidth="0px" Height="10px" MaxLength="15"
                Style="padding-right: 0px; padding-left: 0px; font-size: xx-small; background-image: none;
                padding-bottom: 0px; margin: 0px; padding-top: 0px; text-align: left" Width="122px" Font-Size="X-Small" TabIndex="1"></asp:TextBox></td>
	</tr>
	<tr valign="top">
		<td valign="top">
			<img src="im&#xe1;genes/IRD_20.gif" width="143" height="5" alt=""></td>
	</tr>
	<tr valign="top">
		<td rowspan="3">
			<img src="im&#xe1;genes/IRD_21.gif" width="1" height="30" alt=""></td>
		<td rowspan="3">
			<img src="im&#xe1;genes/IRD_22.gif" width="167" height="30" alt=""></td>
		<td rowspan="3">
			<img src="im&#xe1;genes/IRD_23.gif" width="18" height="30" alt=""></td>
		<td>
			<img src="im&#xe1;genes/IRD_24.gif" width="143" height="9" alt=""></td>
		<td rowspan="3">
			<img src="im&#xe1;genes/IRD_25.jpg" width="17" height="30" alt=""></td>
		<td rowspan="3">
		    <asp:ImageButton runat="server" ID="imgok" BorderWidth="0px" ImageUrl="~/imágenes/IRD_26.gif" ToolTip="Acceder al SIIRD" TabIndex="3" /></td>
		<td rowspan="3">
			<img src="im&#xe1;genes/IRD_27.gif" width="18" height="30" alt=""></td>
	</tr>
	<tr valign="top">
		<td valign ="top" style="height: 13px">
		   <asp:TextBox runat="server" ID="txt_contrasena" width="122px" height="12px" style="padding-right: 0px; padding-left: 0px; padding-bottom: 0px; padding-top: 0px; font-size: xx-small; background-image: none; margin: 0px; text-align: left;" BorderWidth="0px" MaxLength="15" TextMode="Password" Font-Size="X-Small" TabIndex="2" ></asp:TextBox></td>
	</tr>
	<tr valign="top">
		<td valign="top" style="height: 8px">
			<img src="im&#xe1;genes/IRD_29.jpg" width="143" height="7" alt=""></td>
	</tr>
	<tr valign="top">
		<td colspan="7" style="background-image: url(imágenes/IRD_30.gif); width: 402px; border-top-style: none; border-right-style: none; border-left-style: none; height: 29px; border-bottom-style: none;" align="center" valign="top">
            <asp:Label ID="lbl_error" runat="server" Font-Bold="True" Font-Size="X-Small" ForeColor="#C00000"
                Height="8px" Width="350px"></asp:Label></td>
	</tr>
	<tr valign="top">
		<td colspan="9">
			<img src="im&#xe1;genes/IRD_31.gif" width="800" height="16" alt=""></td>
	</tr>
</table>


    </form>
</body>
</html>
