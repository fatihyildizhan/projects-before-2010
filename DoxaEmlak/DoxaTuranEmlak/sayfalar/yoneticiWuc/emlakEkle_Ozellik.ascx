<%@ Control Language="C#" AutoEventWireup="true" CodeFile="emlakEkle_Ozellik.ascx.cs" Inherits="sayfalar_yoneticiWuc_emlakEkle_Ozellik" %>
<style type="text/css">
    .style1
    {
        width: 97%;
    }
    .style2
    {
        width: 113px;
    }
</style>
<table class="style1">
    <tr>
        <td colspan="2">
            <asp:Label ID="lblOzellikEkle" runat="server" Text="Özellik Ekle"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:CheckBoxList ID="cblOzellikler" runat="server" RepeatColumns="3" 
                RepeatDirection="Horizontal">
            </asp:CheckBoxList>
        </td>
    </tr>
    <tr>
        <td class="style2">
<asp:Button ID="btnOzellikEkle" runat="server" onclick="btnOzellikEkle_Click" 
    Text="Özellik Ekle Adım 4" Width="163px" />
        </td>
        <td>
            <asp:Label ID="lblSonuc" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style2">
            <asp:LinkButton ID="lbSonrakiAdim" runat="server" onclick="lbSonrakiAdim_Click">Sonraki Adım</asp:LinkButton>
        </td>
        <td>
            &nbsp;</td>
    </tr>
</table>






