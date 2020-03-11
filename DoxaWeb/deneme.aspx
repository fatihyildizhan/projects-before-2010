<%@ Page Language="C#" AutoEventWireup="true" CodeFile="deneme.aspx.cs" Inherits="deneme" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style7
        {
            width: 100%;
        }
        
* {
	margin: 0;
	padding: 0;
	text-align: left;
}
    
* {
	padding: 0;
	text-align: left;
	margin-left: 0;
	margin-right: 0;
	margin-top: 0;
            height: 26px;
        }

        .style9
        {
            width: 113px;
        }
        .style10
        {
            height: 24px;
            width: 113px;
        }
        .style8
        {
            height: 24px;
        }
        
.contact_input
{
    width:290px;
    height:17px;
    font-size:12px;
    float:left;
    background-color:#fff8dc;
    border:1px #DAB75A solid;
}

p,code,ul {padding-bottom: 1.2em;}

li {list-style: none;}

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
                            <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Height="150px" Width="308px" 
                                Font-Names="Trebuchet MS, Small">
                                <table class="style7" cellpadding="0px" cellspacing="0px">
                                    <tr>
                                        <td colspan="2">
                                            Şifremi Unuttum !</td>
                                    </tr>
                                    <tr>
                                        <td class="style9">
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style10">
                                            Kullanıcı Adı:</td>
                                        <td class="style8">
                                            <asp:TextBox ID="txtKullaniciAd" runat="server" 
                                                ValidationGroup="SifremiUnuttum" CssClass="contact_input" MaxLength="50" 
                                                Width="100px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                ControlToValidate="txtKullaniciAd" ErrorMessage="Kullanıcı Adı Boş Geçilemez!" 
                                                ValidationGroup="SifremiUnuttum" Display="Dynamic">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style9">
                                            E-Posta:</td>
                                        <td>
                                            <asp:TextBox ID="txtEPosta" runat="server" CssClass="contact_input" 
                                                MaxLength="50" Width="100px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                ControlToValidate="txtEPosta" ErrorMessage="E-Posta Boş Geçilemez!" 
                                                ValidationGroup="SifremiUnuttum" Display="Dynamic">*</asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                                ControlToValidate="txtEPosta" ErrorMessage="Geçersiz E-Posta Formatı !" 
                                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                                ValidationGroup="SifremiUnuttum" Display="Dynamic">*</asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:ValidationSummary ID="ValidationSummary2" runat="server" 
                                                ValidationGroup="SifremiUnuttum" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style9">
                                            <asp:Button ID="btnSifreSifirla" runat="server" onclick="btnSifreSifirla_Click" 
                                                Text="Şifremi Sıfırla" ValidationGroup="SifremiUnuttum" Width="100px" 
                                                CssClass="contact_input" Height="20px" />
                                        </td>
                                        <td>
                                            <asp:Label ID="lblSifremiUnuttumSonuc" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
    
    </div>
    </form>
</body>
</html>
