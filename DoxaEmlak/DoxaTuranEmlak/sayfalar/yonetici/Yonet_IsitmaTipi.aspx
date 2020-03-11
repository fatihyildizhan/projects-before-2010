<%@ Page Language="C#" MasterPageFile="~/sayfalar/yonetici/yoneticiPaneli.master"
    AutoEventWireup="true" CodeFile="Yonet_IsitmaTipi.aspx.cs" Inherits="sayfalar_yonetici_Yonet_IsitmaTipi"
    Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style2
        {
            height: 19px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table>
                <tr>
                    <td>
                        Isıtma Tipi Listesi
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
                        Seçilen ısıtma tipi kaç evde kullanılıyor?
                    </td>
                    <td>
                        <asp:Label ID="lblSayi" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Seçilen ısıtma tipi:
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
                    <td class="style2">
                        <asp:LinkButton ID="lbSil" runat="server" ForeColor="Red" onclick="lbSil_Click">Sil</asp:LinkButton>
                    </td>
                    <td class="style2">
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
