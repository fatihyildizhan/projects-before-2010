<%@ Page Language="C#" AutoEventWireup="true" CodeFile="yoneticiGiris.aspx.cs" Inherits="sayfalar_yonetici_yoneticiGiris" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 27%;
        }
        .style2
        {
            width: 507px;
            text-align: left;
        }
        .style3
        {
            width: 507px;
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" class="style1">
            <tr>
                <td colspan="2" style="text-align: center">
                    Turan Emlak Oto Yönetici Girişi</td>
            </tr>
            <tr>
                <td class="style3">
                    Kullanıcı Adı:</td>
                <td>
                    <asp:TextBox ID="txtKullaniciAdi" runat="server">yonetici</asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtSifre" ErrorMessage="*" ValidationGroup="1"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Şifre:</td>
                <td>
                    <asp:TextBox ID="txtSifre" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtSifre" ErrorMessage="*" ValidationGroup="1"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:LinkButton ID="lbGiris" runat="server" Font-Underline="False" 
                        onclick="lbGiris_Click" ValidationGroup="1">Giriş</asp:LinkButton>
                </td>
                <td>
                    <asp:Label ID="lblSonuc" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:LinkButton ID="lbAnasayfa" runat="server" Font-Underline="False" 
                        ForeColor="#006600" PostBackUrl="~/sayfalar/ziyaretci/index.aspx">Anasayfa</asp:LinkButton>
                </td>
                <td style="text-align: right">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
