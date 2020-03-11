<%@ Control Language="C#" AutoEventWireup="true" CodeFile="emlakGoster_Detay_Admin.ascx.cs" Inherits="sayfalar_ziyaretciWuc_emlakGoster_Detay_Admin" %>
<style type="text/css">

    .style3
    {
        text-align: left;
    }
        .style2
    {
        height: 20px;
    }
    </style>
    <asp:DataList ID="dtlEmlaklar" runat="server" CellPadding="3" 
    RepeatColumns="2" RepeatDirection="Horizontal" Width="756px" BackColor="#DEBA84"
    BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
    CellSpacing="2" GridLines="Both" style="text-align: left">
    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
    <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
    <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
    <ItemTemplate>
        <table align="left" style="width: 581px">
            <tr>
                <td colspan="5" style="text-align: left">
                    <asp:Literal ID="ltrBaslik" runat="server" Text='<%# bind("EmlakBaslik") %>'></asp:Literal>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: left">
                    Kategori:</td>
                <td colspan="4">
                    <asp:Label ID="lblKategori" runat="server" Text='<%# bind("KategoriAd") %>'></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="5" class="style3">
                    <asp:Literal ID="ltrResimler" runat="server" 
                        Text='<%# bind("ilkResimKucuk") %>'></asp:Literal>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    Emlak Tipi:</td>
                <td class="style2">
                    <asp:Label ID="lbEmlakTip" runat="server" Text='<%# bind("EmlakTipAd") %>'></asp:Label>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style2">
                    Bina Yaşı:</td>
                <td class="style2">
                    <asp:Label ID="lblBinaYasi" runat="server" Text='<%# bind("BinaYasi") %>'></asp:Label>
                </td>
                <td class="style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Referans No:
                </td>
                <td>
                    <asp:Label ID="lblREferansNo" runat="server" Text='<%# bind("EmlakReferansNo") %>'></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    Kat Sayısı:</td>
                <td>
                    <asp:Label ID="lblKatSayisi" runat="server" Text='<%# bind("KatSayisi") %>'></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Fiyat:
                </td>
                <td>
                    <asp:Label ID="lblFiyat" runat="server" Text='<%# bind("fiyatTL") %>'></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    Kaçıncı Kat:</td>
                <td>
                    <asp:Label ID="lblKacinciKat" runat="server" Text='<%# bind("BulunduguKat") %>'></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <span class="texhtml"><i>m</i><sup>2</sup></span>:
                </td>
                <td>
                    <asp:Label ID="lblM2"  runat="server" Text='<%# bind("EmlakM2") %>'></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    Isıtma Tipi:</td>
                <td>
                    <asp:Label ID="lblIsitmaTipi" runat="server" Text='<%# bind("IsitmaTipAd") %>'></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Şehir:</td>
                <td>
                    <asp:Label ID="lblSehir" runat="server" Text='<%# bind("SehirAd") %>'></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    Semt:</td>
                <td>
                    <asp:Label ID="lblSemt" runat="server" Text='<%# bind("SemtAd") %>'></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    İlçe:</td>
                <td>
                    <asp:Label ID="lblIlce" runat="server" Text='<%# bind("IlceAd") %>'></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    Cadde:</td>
                <td>
                    <asp:Label ID="lblCadde" runat="server" Text='<%# bind("CaddeAd") %>'></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Adres Tarifi:</td>
                <td>
                    <asp:Literal ID="ltrAdresTarifi" runat="server" 
                        Text='<%# bind("AdresTarifi") %>'></asp:Literal>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    Aidat:</td>
                <td>
                    <asp:Label ID="lblAidat" runat="server" Text='<%# bind("Aidat") %>'></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Durumu:</td>
                <td>
                    <asp:Label ID="lblDurumu" runat="server" Text='<%# bind("Durumu") %>'></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    Deposit:</td>
                <td>
                    <asp:Label ID="lblDeposit" runat="server" Text='<%# bind("Deposit") %>'></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Tapu Durumu:</td>
                <td>
                    <asp:Label ID="lblTapuDurumu" runat="server" Text='<%# bind("TapuDurumu") %>'></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    Eklenme Tarihi:</td>
                <td>
                    <asp:Label ID="lblEklenmeTarihi" runat="server" 
                        Text='<%# bind("EmlakEklenmeTarihi") %>'></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Krediye Uygun Mu?</td>
                <td>
                    <asp:CheckBox ID="cbKrediyeUygunMu" runat="server" 
                        Checked='<%# bind("KrediyeUygun") %>' Enabled="False" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    Açıklama:</td>
                <td>
                    <asp:Literal ID="ltrEmlakAciklama" runat="server" 
                        Text='<%# bind("EmlakAciklama") %>'></asp:Literal>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Balkon Sayısı:</td>
                <td>
                    <asp:Label ID="lblBalkonSayisi" runat="server" 
                        Text='<%# bind("BalkonSayisi") %>'></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    Oda Sayısı:</td>
                <td>
                    <asp:Label ID="lblOdaSayisi" runat="server" Text='<%# bind("OdaSayisi") %>'></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Banyo Sayısı</td>
                <td>
                    <asp:Label ID="lblBanyoSayisi" runat="server" Text='<%# bind("BanyoSayisi") %>'></asp:Label>
                </td>
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
                    Özellikler:</td>
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
                <td colspan="5">
                    
                    <asp:CheckBoxList ID="cblOzellikler" runat="server" 
                        DataSource='<%# bind("ozellikler") %>' Enabled="False" RepeatColumns="5" 
                        RepeatDirection="Horizontal">
                    </asp:CheckBoxList>
                    
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <br />
    </ItemTemplate>
</asp:DataList>
   