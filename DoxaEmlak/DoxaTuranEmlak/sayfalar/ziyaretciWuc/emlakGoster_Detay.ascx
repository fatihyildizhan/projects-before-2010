<%@ Control Language="C#" AutoEventWireup="true" CodeFile="emlakGoster_Detay.ascx.cs" Inherits="sayfalar_ziyaretciWuc_emlakGoster_Detay" %>
   <style type="text/css">
       .style1
       {
           width: 28px;
       }
       .style2
       {
           width: 229px;
       }
   </style>
   <asp:GridView ID="gridEmlakDetay" runat="server" CellPadding="0" ForeColor="#333333" 
    GridLines="None" AutoGenerateColumns="False" PageSize="1" 
    style="margin-right: 0px">
    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
    <Columns>
        <asp:TemplateField HeaderText="Detaylı Bilgiler">
            <ItemTemplate>
                <table>
                    <tr>
                        <td>
                            <asp:ImageButton ID="ImageButton3" runat="server" 
                                ImageUrl="~/resimler/resimler/TE.gif" />
                        </td>
                        <td colspan="2">
                            <asp:Label ID="lblKategoriAd" runat="server" Text='<%# bind("KategoriAd") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3" style="text-align: left">
                            <asp:Literal ID="ltrBaslik" runat="server" Text='<%# bind("EmlakBaslik") %>'></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style2">
                            <a href='<%# Eval("ilkResimBuyuk") %>' rel="shadowbox">
                            <img alt="Emlak-Resim" src='<%# Eval("ilkResimKucuk") %>'></img></a>
                        </td>
                        <td class="style1">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style2">
                            Referans No:</td>
                        <td class="style1">
                            <asp:Label ID="lblREferansNo" runat="server" 
                                Text='<%# bind("EmlakReferansNo") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style2">
                            Emlak Tipi:</td>
                        <td class="style1">
                            <asp:Label ID="lbEmlakTip" runat="server" Text='<%# bind("EmlakTipAd") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            Adres Bilgileri:</td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style2">
                            Şehir:</td>
                        <td class="style1">
                            <asp:Literal ID="ltrEmlakSehir" runat="server" Text='<%# bind("SehirAd") %>'></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style2">
                            İlçe:</td>
                        <td class="style1">
                            <asp:Literal ID="ltrEmlakIlce" runat="server" Text='<%# bind("IlceAd") %>'></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style2">
                            Semt:</td>
                        <td class="style1">
                            <asp:Literal ID="ltrEmlakSemt" runat="server" Text='<%# bind("SemtAd") %>'></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style2">
                            Cadde:</td>
                        <td class="style1">
                            <asp:Literal ID="ltrEmlakCadde" runat="server" Text='<%# bind("CaddeAd") %>'></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="2">
                            Adres Tarifi:</td>
                        <td class="style1">
                            <asp:Literal ID="ltrAdresTarifi" runat="server" 
                                Text='<%# bind("AdresTarifi") %>'></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style2">
                            Fiyat:</td>
                        <td class="style1">
                            <asp:Label ID="lblFiyat" runat="server" Text='<%# bind("FiyatTL") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style2">
                            <span class="texhtml"><i>m</i><sup>2</sup></span>:</td>
                        <td class="style1">
                            <asp:Label ID="lblM2" runat="server" Text='<%# bind("EmlakM2") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style2">
                            Oda sayısı:</td>
                        <td class="style1">
                            <asp:Label ID="lblOdaSayisi" runat="server" Text='<%# bind("OdaSayisi") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style2">
                            Banyo sayısı:</td>
                        <td class="style1">
                            <asp:Label ID="lblBanyoSayisi" runat="server" Text='<%# bind("BanyoSayisi") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="2">
                            Balkon sayısı:</td>
                        <td class="style1">
                            <asp:Label ID="lblBalkonSayisi" runat="server" 
                                Text='<%# bind("BalkonSayisi") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style2">
                            Bina yaşı:</td>
                        <td class="style1">
                            <asp:Label ID="lblBinaYasi" runat="server" Text='<%# bind("BinaYasi") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style2">
                            Kat sayısı:</td>
                        <td class="style1">
                            <asp:Label ID="lblKatSayisi" runat="server" Text='<%# bind("KatSayisi") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style2">
                            Kaçıncı kat:</td>
                        <td class="style1">
                            <asp:Label ID="lblKacinciKat" runat="server" Text='<%# bind("BulunduguKat") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style2">
                            Isıtma tipi:</td>
                        <td class="style1">
                            <asp:Label ID="lblIsitmaTipi" runat="server" Text='<%# bind("IsitmaTipAd") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style2">
                            Krediye uygun mu?</td>
                        <td class="style1">
                            <asp:CheckBox ID="cbKrediyeUygunMu" runat="server" 
                                Checked='<%# bind("KrediyeUygun") %>' Enabled="False" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style2">
                            Durumu:</td>
                        <td class="style1">
                            <asp:Label ID="lblDurumu" runat="server" Text='<%# bind("Durumu") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style2">
                            Tapu durumu:</td>
                        <td class="style1">
                            <asp:Label ID="lblTapuDurumu" runat="server" Text='<%# bind("TapuDurumu") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style2">
                            Eklenme tarihi:</td>
                        <td class="style1">
                            <asp:Label ID="lblEklenmeTarihi" runat="server" 
                                Text='<%# bind("EmlakEklenmeTarihi") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style2">
                            Aidat:</td>
                        <td class="style1">
                            <asp:Label ID="lblAidat" runat="server" Text='<%# bind("Aidat") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style2">
                            Deposit:</td>
                        <td class="style1">
                            <asp:Label ID="lblDeposit" runat="server" Text='<%# bind("Deposit") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style2">
                            Açıklama:</td>
                        <td class="style1">
                            <asp:Literal ID="ltrEmlakAciklama" runat="server" 
                                Text='<%# bind("EmlakAciklama") %>'></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="style2">
                            &nbsp;</td>
                        <td class="style1">
                            &nbsp;</td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <EditRowStyle BackColor="#999999" />
    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
</asp:GridView>
    <p style="text-align: left">
        &nbsp;</p>

    