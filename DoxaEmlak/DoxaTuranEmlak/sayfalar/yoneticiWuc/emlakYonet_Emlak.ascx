<%@ Control Language="C#" AutoEventWireup="true" CodeFile="emlakYonet_Emlak.ascx.cs" Inherits="sayfalar_yoneticiWuc_emlakYonet_Emlak" %>
<style type="text/css">
    .style1
    {
        width: 121px;
    }
    .style2
    {
        width: 268435408px;
    }
    .style4
    {
        width: 81px;
    }
    .style5
    {
        width: 99px;
    }
    .style6
    {
        width: 87px;
    }
</style>
<asp:DataList ID="dlEmlaklarYonetim" runat="server" CellPadding="3" HorizontalAlign="Center"
    RepeatColumns="4" RepeatDirection="Horizontal" Width="756px" BackColor="#DEBA84"
    BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellSpacing="2" GridLines="Both"
    OnItemCommand="dlEmlaklarYonetim_ItemCommand">
    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
    <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
    <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
    <ItemTemplate>
        <table style="width: 244px">
            <tr>
                <td class="style4" colspan="2">
                    <asp:Label ID="lblKategori" runat="server" Text='<%# bind("KategoriAd") %>'></asp:Label>
                </td>
                <td style="text-align: right" class="style2">
                    <asp:LinkButton ID="lbDetay" runat="server" CommandArgument='<%# bind("EmlakId") %>'
                        CommandName="guncelle" Font-Underline="False" ForeColor="#009933">Güncelle</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td style="text-align: left" class="style1">
                    <asp:Literal ID="ltrBaslik" runat="server" Text='<%# bind("EmlakBaslik") %>'></asp:Literal>
                </td>
                <td colspan="2" style="text-align: right">
                    <asp:LinkButton ID="lbSil" runat="server" 
                        CommandArgument='<%# bind("EmlakId") %>' CommandName="sil" 
                        Font-Underline="False" ForeColor="#CC0000">Sil</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center">
                    <a rel="shadowbox" href='<%# Eval("ilkResimBuyuk") %>'>
                        <img alt="Emlak-Resim" src='<%# Eval("ilkResimKucuk") %>'></a>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td colspan="2" class="style4">
                    Emlak Tipi:</td>
                <td class="style2">
                    <asp:Label ID="lbEmlakTip" runat="server" Text='<%# bind("EmlakTipAd") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="style4">
                    Referans No:
                </td>
                <td class="style2">
                    <asp:Label ID="lblREferansNo" runat="server" Text='<%# bind("EmlakReferansNo") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="style4">
                    Fiyat:
                </td>
                <td class="style2">
                    <asp:Label ID="lblFiyat" runat="server" Text='<%# bind("fiyatTL") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="style4">
                    <span class="texhtml"><i>m</i><sup>2</sup></span>:
                </td>
                <td class="style2">
                    <asp:Label ID="lblM2" runat="server" Text='<%# bind("EmlakM2") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="style4">
                    Adres:
                </td>
                <td class="style2">
                    <asp:Literal ID="ltrEmlakAdres" runat="server" Text='<%# bind("Adres") %>'></asp:Literal>
                </td>
            </tr>
        </table>
    </ItemTemplate>
</asp:DataList>
<p>
    &nbsp;</p>
<asp:Panel ID="Panel1" runat="server" style="width: 932px; text-align: center">
    <table class="style2">
        <tr>
            <td colspan="2" style="text-align: center">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                Silmek istiyor musunuz?</td>
        </tr>
        <tr>
            <td style="text-align: right" class="style6">
                <asp:LinkButton ID="lbEvet" runat="server" Font-Underline="False" 
                    ForeColor="#00CC00" onclick="lbEvet_Click">Evet</asp:LinkButton>
            </td>
            <td style="text-align: left" class="style5">
                <asp:LinkButton ID="lbHayir" runat="server" Font-Underline="False" 
                    ForeColor="Red" onclick="lbHayir_Click">Hayır</asp:LinkButton>
            </td>
        </tr>
    </table>
</asp:Panel>
