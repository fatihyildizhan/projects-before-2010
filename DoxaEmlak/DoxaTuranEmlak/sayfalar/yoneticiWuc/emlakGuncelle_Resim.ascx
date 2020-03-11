<%@ Control Language="C#" AutoEventWireup="true" CodeFile="emlakGuncelle_Resim.ascx.cs" Inherits="sayfalar_yoneticiWuc_emlakGuncelle_Resim" %>
<style type="text/css">


        .style1
        {
            width: 100%;
        }
        .style3
        {
            height: 6px;
        }
    </style>
<table class="style1">
    <tr>
        <td>
            Başlık:</td>
        <td>
            <asp:TextBox ID="txtBaslik" runat="server" Width="213px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style3">
            <asp:Button ID="btnGuncelle" runat="server" onclick="btnGuncelle_Click" 
                Text="Güncelle" Width="101px" />
        </td>
        <td class="style3">
            <asp:Label ID="lblUyari" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:LinkButton ID="lbGeriDon" runat="server" onclick="lbGeriDon_Click">Geri</asp:LinkButton>
        </td>
        <td>
            &nbsp;</td>
    </tr>
</table>
