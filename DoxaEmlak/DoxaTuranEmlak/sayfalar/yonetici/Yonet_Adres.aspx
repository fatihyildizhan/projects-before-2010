<%@ Page Language="C#" MasterPageFile="~/sayfalar/yonetici/yoneticiPaneli.master" AutoEventWireup="true" CodeFile="Yonet_Adres.aspx.cs" Inherits="sayfalar_yonetici_Yonet_Adres" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table>
                <tr>
                    <td>
                        Şehir Listesi
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlListe" runat="server" AutoPostBack="True" Height="20px"
                            Width="247px" OnSelectedIndexChanged="ddlListe_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td>
                        Seçilen Şehir kaç evde kullanılıyor?
                    </td>
                    <td>
                        <asp:Label ID="lblSayi" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Seçilen Şehir Adı:
                    </td>
                    <td>
                        <asp:TextBox ID="txtAd" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:LinkButton ID="lbGuncelle" runat="server" ForeColor="#006600" 
                            onclick="lbGuncelle_Click">Güncelle</asp:LinkButton>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:LinkButton ID="lbSil" runat="server" ForeColor="Red" onclick="lbSil_Click">Sil</asp:LinkButton>
                    </td>
                    <td>
                        <asp:Label ID="lblSonuc" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:LinkButton ID="lbEkle" runat="server" ForeColor="#0000CC" 
                            onclick="lbEkle_Click">Ekle</asp:LinkButton>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEkle" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="ddlListe" 
                EventName="SelectedIndexChanged" />
        </Triggers>
    </asp:UpdatePanel>
            </td>
            <td>
                &nbsp;</td>
            <td>
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <table>
                <tr>
                    <td>
                        İlçe Listesi
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlListeIlce" runat="server" AutoPostBack="True" Height="20px"
                            Width="247px" OnSelectedIndexChanged="ddlListeIlce_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td>
                        Seçilen İlçe kaç adreste kullanılıyor?
                    </td>
                    <td>
                        <asp:Label ID="lblSayiIlce" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Seçilen İlçe:
                    </td>
                    <td>
                        <asp:TextBox ID="txtAdIlce" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        İlçenin bağlı olduğu şehir:</td>
                    <td>
                        <asp:DropDownList ID="ddlIlceSehir" runat="server" Height="20px" 
                            Width="152px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:LinkButton ID="lbGuncelleIlce" runat="server" ForeColor="#006600" 
                            onclick="lbGuncelleIlce_Click">Güncelle</asp:LinkButton>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:LinkButton ID="lbEkleIlce" runat="server" ForeColor="#0000CC" 
                            onclick="lbEkleIlce_Click">Ekle</asp:LinkButton>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEkleIlce" runat="server" style="margin-bottom: 0px" 
                            Width="152px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:LinkButton ID="lbSilIlce" runat="server" ForeColor="Red" 
                            onclick="lbSilIlce_Click">Sil</asp:LinkButton>
                    </td>
                    <td>
                        <asp:Label ID="lblSonucIlce" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="ddlIlceSehir" 
                EventName="SelectedIndexChanged" />
        </Triggers>
    </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
        <ContentTemplate>
            <table>
                <tr>
                    <td>
                        Semt Listesi
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlListeSemt" runat="server" AutoPostBack="True" Height="20px"
                            Width="247px" OnSelectedIndexChanged="ddlListeSemt_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td>
                        Seçilen Semt kaç adreste kullanılıyor?
                    </td>
                    <td>
                        <asp:Label ID="lblSayiSemt" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Seçilen Semt:
                    </td>
                    <td>
                        <asp:TextBox ID="txtAdSemt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Semtin bağlı olduğu ilçe:</td>
                    <td>
                        <asp:DropDownList ID="ddlSemtIlce" runat="server" Height="20px" 
                            Width="152px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:LinkButton ID="lbGuncelleSemt" runat="server" ForeColor="#006600" 
                            onclick="lbGuncelleSemt_Click">Güncelle</asp:LinkButton>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:LinkButton ID="lbEkleSemt" runat="server" ForeColor="#0000CC" 
                            onclick="lbEkleSemt_Click">Ekle</asp:LinkButton>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEkleSemt" runat="server" style="margin-bottom: 0px" 
                            Width="152px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:LinkButton ID="lbSilSemt" runat="server" ForeColor="Red" 
                            onclick="lbSilSemt_Click">Sil</asp:LinkButton>
                    </td>
                    <td>
                        <asp:Label ID="lblSonucSemt" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="ddlListeSemt" 
                EventName="SelectedIndexChanged" />
        </Triggers>
    </asp:UpdatePanel>
            </td>
            <td>
                &nbsp;</td>
            <td>
    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
        <ContentTemplate>
            <table>
                <tr>
                    <td>
                        Cadde Listesi
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlListeCadde" runat="server" AutoPostBack="True" Height="20px"
                            Width="247px" OnSelectedIndexChanged="ddlListeCadde_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td>
                        Seçilen Özellik kaç evde kullanılıyor?
                    </td>
                    <td>
                        <asp:Label ID="lblSayiCadde" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Seçilen Özellik:
                    </td>
                    <td>
                        <asp:TextBox ID="txtAdCadde" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Özellik Tipi:</td>
                    <td>
                        <asp:DropDownList ID="ddlCaddeSemt" runat="server" Height="20px" 
                            Width="152px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:LinkButton ID="lbGuncelleCadde" runat="server" ForeColor="#006600" 
                            onclick="lbGuncelleCadde_Click">Güncelle</asp:LinkButton>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:LinkButton ID="lbEkleCadde" runat="server" ForeColor="#0000CC" 
                            onclick="lbEkleCadde_Click">Ekle</asp:LinkButton>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEkleCadde" runat="server" style="margin-bottom: 0px" 
                            Width="152px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:LinkButton ID="lbSilCadde" runat="server" ForeColor="Red" 
                            onclick="lbSilCadde_Click">Sil</asp:LinkButton>
                    </td>
                    <td>
                        <asp:Label ID="lblSonucCadde" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="ddlListeCadde" 
                EventName="SelectedIndexChanged" />
        </Triggers>
    </asp:UpdatePanel>
            </td>
        </tr>
    </table>
</asp:Content>

