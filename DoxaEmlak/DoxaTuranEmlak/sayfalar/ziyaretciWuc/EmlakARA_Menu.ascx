<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EmlakARA_Menu.ascx.cs"
    Inherits="sayfalar_ziyaretciWuc_EmlakARA_Menu" %>
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <table>
            <tr>
                <td colspan="2">
                    Emlak özelliklerini seçiniz:
                </td>
                <td rowspan="17">
                    <asp:DataList ID="DataList1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84"
                        BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" GridLines="Both"
                        HorizontalAlign="Center" OnItemCommand="DataList1_ItemCommand" RepeatColumns="4"
                        RepeatDirection="Horizontal" Width="756px">
                        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                        <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                        <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                        <ItemTemplate>
                            <table>
                                <tr>
                                    <td>
                                        <asp:ImageButton ID="ImageButton3" runat="server" Height="16px" ImageUrl="~/resimler/resimler/TE.gif" />
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
                                        <a href='<%# Eval("ilkResimBuyuk") %>' rel="shadowbox">
                                            <img alt="Emlak-Resim-Menü" src='<%# Eval("ilkResimKucuk") %>'></img></a>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        Emlak Tipi:
                                    </td>
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
                                        <span><i>m</i><sup>2</sup></span>:
                                    </td>
                                    <td>
                                        <asp:Label ID="lblM2" runat="server" Text='<%# bind("EmlakM2") %>'></asp:Label>
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
                </td>
            </tr>
            <tr>
                <td>
                    Kategori Seçiniz:
                </td>
                <td>
                    <asp:DropDownList ID="ddKategori" runat="server" Height="20px" Width="141px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Emlak Tipini Seçiniz:
                </td>
                <td>
                    <asp:DropDownList ID="ddEmlakTipler" runat="server" Height="20px" Width="141px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Sehir Seçiniz:
                </td>
                <td>
                    <asp:DropDownList ID="ddSehirler" runat="server" AutoPostBack="True" Height="20px"
                        OnSelectedIndexChanged="ddSehirler_SelectedIndexChanged" Width="141px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    İlçe Seçiniz:
                </td>
                <td>
                    <asp:DropDownList ID="ddIlceler" runat="server" AutoPostBack="True" Height="20px"
                        OnSelectedIndexChanged="ddIlceler_SelectedIndexChanged" Width="141px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Semt Seçiniz:
                </td>
                <td>
                    <asp:DropDownList ID="ddSemtler" runat="server" AutoPostBack="True" Height="20px"
                        OnSelectedIndexChanged="ddSemtler_SelectedIndexChanged" Width="141px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Cadde Seçiniz:
                </td>
                <td>
                    <asp:DropDownList ID="ddCaddeler" runat="server" Height="20px" Width="141px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Fiyat Giriniz:
                </td>
                <td>
                    <asp:TextBox ID="txtFiyat" runat="server" MaxLength="8" Width="100px">0</asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtFiyat"
                        ErrorMessage="***" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Fiyat Türünü Seçiniz:
                </td>
                <td>
                    <asp:RadioButton ID="rbFiyatEsitKucuk" runat="server" GroupName="fiyat" Text="= &lt;"
                        ValidationGroup="fiyat" />
                    &nbsp;|
                    <asp:RadioButton ID="rbFiyatEsitBuyuk" runat="server" Checked="True" GroupName="fiyat"
                        Text="= &gt;" ValidationGroup="fiyat" />
                </td>
            </tr>
            <tr>
                <td>
                    Referans No Giriniz:
                </td>
                <td>
                    <asp:TextBox ID="txtReferans" runat="server" Width="99px">0</asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtReferans"
                        ErrorMessage="***" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Fiyat Türünü Seçiniz:
                </td>
                <td>
                    <asp:RadioButton ID="rbReferansEsitKucuk" runat="server" GroupName="referans" Text="= &lt;"
                        ValidationGroup="referans" />
                    &nbsp;|&nbsp;<asp:RadioButton ID="rbReferansBuyuk" runat="server" Checked="True"
                        GroupName="referans" Text="= &gt;" ValidationGroup="referans" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnEmlakAra" runat="server" OnClick="btnEmlakAra_Click" Text="Emlak Arama"
                        Width="131px" />
                </td>
                <td>
                    <asp:LinkButton ID="lbSifirla" runat="server" OnClick="lbSifirla_Click">Sıfırla</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    <asp:LinkButton ID="lbDetayliArama" runat="server" OnClick="lbDetayliArama_Click">Detaylı Arama</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
        </table>
    </ContentTemplate>
</asp:UpdatePanel>
