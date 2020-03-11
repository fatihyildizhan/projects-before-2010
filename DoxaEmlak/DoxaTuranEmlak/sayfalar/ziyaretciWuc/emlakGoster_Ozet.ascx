<%@ Control Language="C#" AutoEventWireup="true" CodeFile="emlakGoster_Ozet.ascx.cs"
    Inherits="sayfalar_ziyaretciWuc_emlakGoster_Ozet" %>
<asp:DataList ID="DataList1" runat="server" CellPadding="3" 
    RepeatColumns="4" RepeatDirection="Horizontal" Width="756px" BackColor="#DEBA84"
    BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellSpacing="2" GridLines="Both"
    OnItemCommand="DataList1_ItemCommand" style="text-align: left">
    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
    <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
    <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
    <ItemTemplate>
        <table>
            <tr>
                <td>
                    <asp:ImageButton ID="ImageButton3" runat="server" 
                        ImageUrl="~/resimler/resimler/TE.gif" Height="16px" />
                </td>
                <td>
                    <asp:Label ID="lblKategori" runat="server" Text='<%# bind("KategoriAd") %>'></asp:Label>
                </td>
                <td style="text-align: right">
                    <asp:LinkButton ID="lbDetay" runat="server" CommandArgument='<%# bind("EmlakId") %>'
                        CommandName="detay" Font-Underline="False" ForeColor="#009933">Detay</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: left">
                    <asp:Literal ID="ltrBaslik" runat="server" Text='<%# bind("EmlakBaslik") %>'></asp:Literal>
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
                <td colspan="2">
                    Emlak Tipi:</td>
                <td>
                    <asp:Label ID="lbEmlakTip" runat="server" Text='<%# bind("EmlakTipAd") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    Referans No:
                </td>
                <td>
                    <asp:Label ID="lblREferansNo" runat="server" Text='<%# bind("EmlakReferansNo") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    Fiyat:
                </td>
                <td>
                    <asp:Label ID="lblFiyat" runat="server" Text='<%# bind("fiyatTL") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <span class="texhtml"><i>m</i><sup>2</sup></span>:
                </td>
                <td>
                    <asp:Label ID="lblM2"  runat="server" Text='<%# bind("EmlakM2") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    Adres:
                </td>
                <td>
                    <asp:Literal ID="ltrEmlakAdres" runat="server" Text='<%# bind("Adres") %>'></asp:Literal>
                </td>
            </tr>
        </table>
    </ItemTemplate>
</asp:DataList>