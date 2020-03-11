<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPageUyeler.master" AutoEventWireup="true" CodeFile="profilim.aspx.cs" Inherits="User_profilim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style7
    {
        width: 500px;
    }
    .style8
    {
        height: 16px;
    }
    .style9
    {
        width: 161px;
    }
    .style10
    {
        height: 16px;
        width: 161px;
    }
   
</style>
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="ContentPlaceHolder4">
                     
    <div>
        <table class="style7">
            <tr>
                <td class="style9">
                Ad :</td>
                <td>
                    <asp:TextBox ID="txtAd" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Soyad:</td>
                <td>
                    <asp:TextBox ID="txtSoyad" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Cinsiyet:</td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem>Bayan</asp:ListItem>
                        <asp:ListItem>Bay</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Doğum Tarihi:</td>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Gün/Ay/Yıl"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtDogumTarih" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Memleket:</td>
                <td>
                    <asp:TextBox ID="txtMemleket" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Favori Sözünüz:</td>
                <td>
                    <asp:TextBox ID="txtFavoriSoz" runat="server" ReadOnly="True" Width="351px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style10">
                İlgi Alanlarınız:</td>
                <td class="style8">
                    <asp:TextBox ID="txtIlgiAlani" runat="server" Height="88px" ReadOnly="True" 
                        TextMode="MultiLine" Width="351px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Aktiviteleriniz:</td>
                <td>
                    <asp:TextBox ID="txtAktivite" runat="server" Height="88px" TextMode="MultiLine" 
                        Width="351px" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                MSN:</td>
                <td>
                    <asp:TextBox ID="txtMsn" runat="server" Width="351px" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Yaşadığınız Şehir:</td>
                <td>
                    <asp:TextBox ID="txtYasadigiSehir" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Cep Telefonu:</td>
                <td>
                    <asp:TextBox ID="txtCepTelefonu" runat="server" MaxLength="10" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Ruh Durumunuz:</td>
                <td>
                    <asp:TextBox ID="txtRuhDurumu" runat="server" ReadOnly="True" Width="351px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Web Siteniz:</td>
                <td>
                    <asp:TextBox ID="txtWebSitesi" runat="server" ReadOnly="True" Width="351px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                NickName:</td>
                <td>
                    <asp:TextBox ID="txtNickName" runat="server" ReadOnly="True" Width="351px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Üniversite:</td>
                <td>
                    <asp:TextBox ID="txtUnivetsite" runat="server" ReadOnly="True" Width="351px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Bölüm:</td>
                <td>
                    <asp:TextBox ID="txtUniBolum" runat="server" ReadOnly="True" Width="351px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Lise:</td>
                <td>
                    <asp:TextBox ID="txtLise" runat="server" ReadOnly="True" Width="351px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Meslek:</td>
                <td>
                    <asp:TextBox ID="txtMeslek" runat="server" ReadOnly="True" Width="351px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </div>
                     
</asp:Content>

