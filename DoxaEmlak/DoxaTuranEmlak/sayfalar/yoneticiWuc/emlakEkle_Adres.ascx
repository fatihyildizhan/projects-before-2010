<%@ Control Language="C#" AutoEventWireup="true" CodeFile="emlakEkle_Adres.ascx.cs" Inherits="sayfalar_yoneticiWuc_emlakEkle_Adres" %>

<asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table>
                <tr>
                    <td colspan="2" style="text-align: center">
                        <asp:Label ID="lblAdresEkle" runat="server" Text="Adres Ekle"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Sehir Seçiniz:
                    </td>
                    <td>
                        <asp:DropDownList ID="ddSehirler" runat="server" AutoPostBack="True" 
                            Height="20px" OnSelectedIndexChanged="ddSehirler_SelectedIndexChanged" 
                            Width="141px">
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
                        <asp:DropDownList ID="ddSemtler" runat="server" Height="20px" Width="141px" AutoPostBack="True"
                            OnSelectedIndexChanged="ddSemtler_SelectedIndexChanged">
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
                        Adres Tarifi:
                    </td>
                    <td>
                        <asp:TextBox ID="txtAdresTarif" runat="server" Height="108px" TextMode="MultiLine"
                            Width="346px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnAdresEkle" runat="server" OnClick="btnAdresEkle_Click" Text="Adres Ekle Adım 3"
                            Width="123px" />
                    </td>
                    <td>
                        <asp:Label ID="lblAdresSonuc" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:LinkButton ID="lbSonrakiAdim" runat="server" OnClick="lbSonrakiAdim_Click">Sonraki Adım</asp:LinkButton>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
            </table>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="ddSehirler" EventName="SelectedIndexChanged" />
            <asp:AsyncPostBackTrigger ControlID="ddIlceler" EventName="SelectedIndexChanged" />
        </Triggers>
    </asp:UpdatePanel>
