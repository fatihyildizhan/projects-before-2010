<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="yoneticiSayfasi.aspx.cs" Inherits="BussinessLayer.sayfalar.yonetici.yoneticiSayfasi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td>
                    <asp:LinkButton ID="LinkButton1" runat="server" 
                        PostBackUrl="~/sayfalar/yonetici/yoneticiSayfasi.aspx">Yönetici Sayfası</asp:LinkButton>
                </td>
                <td>
                    <asp:LinkButton ID="LinkButton2" runat="server" 
                        PostBackUrl="~/sayfalar/yonetici/emlakYonet.aspx">Emlak Yönet</asp:LinkButton>
                </td>
                <td>
                    <asp:LinkButton ID="LinkButton3" runat="server">Özellik Yönet</asp:LinkButton>
                </td>
                <td>
                    <asp:LinkButton ID="LinkButton4" runat="server" 
                        PostBackUrl="~/sayfalar/yonetici/emlakTipYonet.aspx">Emlak Tip Yönet</asp:LinkButton>
                </td>
                <td>
                    <asp:LinkButton ID="LinkButton6" runat="server">LinkButton</asp:LinkButton>
                </td>
                <td>
                    <asp:LinkButton ID="LinkButton5" runat="server">LinkButton</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    kaç ev var, kaç özellik var</td>
                <td>
                    siteyi kaç kişi ziyaret etmiş gibi istatistiki</td>
                <td>
                    bilgileri
                </td>
                <td>
                    bu</td>
                <td>
                    sayfada</td>
                <td>
                    göster.</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
