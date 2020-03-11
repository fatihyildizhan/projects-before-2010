<%@ Page Language="C#" MasterPageFile="~/sayfalar/yonetici/yoneticiPaneli.master" AutoEventWireup="true" CodeFile="Yonet_Kategori.aspx.cs" Inherits="sayfalar_yonetici_Yonet_Kategori" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table>
                <tr>
                    <td>
                        Kategori Listesi
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
                        Seçilen kategori kaç evde kullanılıyor?
                    </td>
                    <td>
                        <asp:Label ID="lblSayi" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Seçilen Kategori:
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
                        <asp:Label ID="lblSonuc" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:LinkButton ID="lbSil" runat="server" ForeColor="Red" onclick="lbSil_Click">Sil</asp:LinkButton>
                    </td>
                    <td>
                        &nbsp;
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
</asp:Content>

