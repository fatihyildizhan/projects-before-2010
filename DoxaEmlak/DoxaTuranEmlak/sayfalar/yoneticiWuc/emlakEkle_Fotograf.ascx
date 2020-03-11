<%@ Control Language="C#" AutoEventWireup="true" CodeFile="emlakEkle_Fotograf.ascx.cs" Inherits="sayfalar_yoneticiWuc_emlakEkle_Fotograf" %>
<style type="text/css">


        .style1
        {
            width: 48%;
        }
        .style2
    {
        width: 100%;
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
        <td>
            Resim:</td>
        <td>
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="btnResimEkle" runat="server" onclick="btnResimEkle_Click" 
                Text="Resim Ekle" Width="101px" />
        </td>
        <td>
            <asp:Label ID="lblUyari" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <asp:LinkButton ID="LbEmlakEkleBitir" runat="server" 
                onclick="LbEmlakEkleBitir_Click">Emlak Eklemeyi Bitir</asp:LinkButton>
        </td>
    </tr>
</table>
<asp:DataList ID="DataList1" runat="server" 
    onitemcommand="DataList1_ItemCommand" RepeatColumns="5" 
    RepeatDirection="Horizontal">
    <ItemTemplate>
        <table class="style1">
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Label ID="Label1" runat="server" Text='<%# bind("Baslik") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:ImageButton ID="ImageButton1" runat="server" 
                        CommandArgument='<%# bind("Id") %>' CommandName="ResimEkle" 
                        ImageUrl='<%# bind("ResimKucuk") %>' />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Label ID="Label2" runat="server" Text='<%# bind("Tarih") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align: center">
                    <asp:LinkButton ID="LinkButton8" runat="server" 
                        CommandArgument='<%# bind("Id") %>' CommandName="Guncelle" 
                        Font-Underline="False" ForeColor="#009933">Güncelle</asp:LinkButton>
                </td>
                <td style="text-align: center">
                    <asp:LinkButton ID="LinkButton9" runat="server" 
                        CommandArgument='<%# bind("Id") %>' CommandName="Sil" Font-Underline="False" 
                        ForeColor="Red">Sil</asp:LinkButton>
                </td>
            </tr>
        </table>
    </ItemTemplate>
</asp:DataList>
<asp:Panel ID="Panel1" runat="server" Visible="False" Width="421px">
    <table class="style2">
        <tr>
            <td colspan="2" style="text-align: center">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                Resimi silmek istiyor musunuz?</td>
        </tr>
        <tr>
            <td style="text-align: right">
                <asp:LinkButton ID="lbEvet" runat="server" Font-Underline="False" 
                    ForeColor="#00CC00" onclick="lbEvet_Click">Evet</asp:LinkButton>
            </td>
            <td style="text-align: left">
                <asp:LinkButton ID="lbHayir" runat="server" Font-Underline="False" 
                    ForeColor="Red" onclick="lbHayir_Click">Hayır</asp:LinkButton>
            </td>
        </tr>
    </table>
</asp:Panel>

