<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPageUyeler.master" AutoEventWireup="true" CodeFile="guncelle.aspx.cs" Inherits="User_guncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style7
    {
        width: 100%;
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
<asp:Content ID="Content4" runat="server" contentplaceholderid="ContentPlaceHolder4">
                   
                      
    <div>
        <table class="style7">
            <tr>
                <td class="style9">
                Ad :</td>
                <td>
                    <asp:TextBox ID="txtAd" runat="server" CssClass="contact_input" MaxLength="50" 
                        Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Soyad:</td>
                <td>
                    <asp:TextBox ID="txtSoyad" runat="server" CssClass="contact_input" 
                        MaxLength="50" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Cinsiyet:</td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem Selected="True">Bayan</asp:ListItem>
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
                    <asp:TextBox ID="txtDogumTarih" runat="server" MaxLength="8" 
                        CssClass="contact_input" Width="100px"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="style9">
                Memleket:</td>
                <td>
                    <asp:TextBox ID="txtMemleket" runat="server" CssClass="contact_input" 
                        MaxLength="50" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Favori Sözünüz:</td>
                <td>
                    <asp:TextBox ID="txtFavoriSoz" runat="server" Width="100px" 
                        CssClass="contact_input" MaxLength="50"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style10">
                İlgi Alanlarınız:</td>
                <td class="style8">
                    <asp:TextBox ID="txtIlgiAlani" runat="server" Height="88px" 
                        TextMode="MultiLine" Width="351px" CssClass="contact_input" 
                        MaxLength="300"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Aktiviteleriniz:</td>
                <td>
                    <asp:TextBox ID="txtAktivite" runat="server" Height="88px" TextMode="MultiLine" 
                        Width="351px" CssClass="contact_input" MaxLength="300"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                MSN:</td>
                <td>
                    <asp:TextBox ID="txtMsn" runat="server" Width="200px" CssClass="contact_input" 
                        MaxLength="50"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Yaşadığınız Şehir:</td>
                <td>
                    <asp:TextBox ID="txtYasadigiSehir" runat="server" CssClass="contact_input" 
                        MaxLength="50" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Cep Telefonu:</td>
                <td>
                    <asp:TextBox ID="txtCepTelefonu" runat="server" MaxLength="50" 
                        CssClass="contact_input" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Ruh Durumunuz:</td>
                <td>
                    <asp:TextBox ID="txtRuhDurumu" runat="server" Width="200px" 
                        CssClass="contact_input" MaxLength="50"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Web Siteniz:</td>
                <td>
                    <asp:TextBox ID="txtWebSitesi" runat="server" Width="200px" 
                        CssClass="contact_input" MaxLength="50"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                NickName:</td>
                <td>
                    <asp:TextBox ID="txtNickName" runat="server" Width="200px" 
                        CssClass="contact_input" MaxLength="50"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Üniversite:</td>
                <td>
                    <asp:TextBox ID="txtUnivetsite" runat="server" Width="200px" 
                        CssClass="contact_input" MaxLength="50"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Bölüm:</td>
                <td>
                    <asp:TextBox ID="txtUniBolum" runat="server" Width="200px" 
                        CssClass="contact_input" MaxLength="50"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Lise:</td>
                <td>
                    <asp:TextBox ID="txtLise" runat="server" Width="200px" CssClass="contact_input" 
                        MaxLength="50"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                Meslek:</td>
                <td>
                    <asp:TextBox ID="txtMeslek" runat="server" Width="200px" 
                        CssClass="contact_input" MaxLength="50"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                    <asp:Button ID="btnGuncelle" runat="server" onclick="btnGuncelle_Click" 
                    Text="Güncelle" Width="120px" CssClass="contact_input" /></td>
                <td></td>
            </tr>
        </table>
    </div>                      
</asp:Content>





