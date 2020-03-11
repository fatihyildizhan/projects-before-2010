<%@ Control Language="C#" AutoEventWireup="true" CodeFile="emlakEkle_Fiyat.ascx.cs" Inherits="sayfalar_yoneticiWuc_emlakEkle_Fiyat" %>
<style type="text/css">

    .style1
    {
        width: 32%;
    }
</style>
<table class="style1">
    <tr>
        <td colspan="2" style="text-align: center">
            <asp:Label ID="lblFiyatEkle" runat="server" Text="Emlak Fiyat Ekle"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            Türk Lirası:</td>
        <td>
            <asp:TextBox ID="txtTL" runat="server" Width="163px">0</asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ControlToValidate="txtTL" ErrorMessage="!" ValidationExpression="[0-9]*" 
                ValidationGroup="ekle"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td>
            Euro:</td>
        <td>
            <asp:TextBox ID="txtEuro" runat="server" Width="163px">0</asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                ControlToValidate="txtEuro" ErrorMessage="!" ValidationExpression="[0-9]*" 
                ValidationGroup="ekle"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td>
            Dolar:</td>
        <td>
            <asp:TextBox ID="txtDolar" runat="server" Width="163px">0</asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                ControlToValidate="txtDolar" ErrorMessage="!" ValidationExpression="[0-9]*" 
                ValidationGroup="ekle"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td>
            Pound:</td>
        <td>
            <asp:TextBox ID="txtPound" runat="server" Width="163px">0</asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                ControlToValidate="txtPound" ErrorMessage="!" ValidationExpression="[0-9]*" 
                ValidationGroup="ekle"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="btnEkleFiyat" runat="server" onclick="btnDetayEkle_Click" 
                Text="Fiyat Ekle Adım 2" Width="129px" ValidationGroup="ekle" />
        </td>
        <td>
            <asp:Label ID="lblFiyatSonuc" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:LinkButton ID="lbSonrakiAdim" runat="server" onclick="lbSonrakiAdim_Click">Sonraki Adım</asp:LinkButton>
        </td>
        <td>
            &nbsp;</td>
    </tr>
</table>
