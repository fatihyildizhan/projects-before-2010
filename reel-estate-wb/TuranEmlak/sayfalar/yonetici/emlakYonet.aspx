<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="emlakYonet.aspx.cs" Inherits="BussinessLayer.sayfalar.yonetici.emlakYonet" %>

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
                    Emlak Türü:</td>
                <td>
                    <asp:TextBox ID="prmTxtEmlakTuru" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Emlak Tipi:</td>
                <td>
                    <asp:DropDownList ID="prmDdEmlakTip" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Emlak Boyutu:</td>
                <td>
                    <asp:TextBox ID="prmTxtEmlakBoyut" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnEmlakEkle" runat="server" onclick="btnEmlakEkle_Click" 
                        Text="Emlak Ekle" />
                </td>
                <td>
                    <asp:Label ID="prmLblSonuc" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
