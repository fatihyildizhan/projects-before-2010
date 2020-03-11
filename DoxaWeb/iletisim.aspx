<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageSayfalar.master" AutoEventWireup="true" CodeFile="iletisim.aspx.cs" Inherits="User_iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style6
        {
        width: 119px;
        float: left;
    }

    </style>
</asp:Content>


<asp:Content ID="Content4" runat="server" 
    contentplaceholderid="ContentPlaceHolder4">
    <table class="main" dir="ltr" rules="groups" 
        
        style="font-family: 'Courier New'; font-size: large; font-weight: normal; position: static; caption-side: bottom; width: 526px;">
        <tr>
            <td class="style6">
                <asp:Label ID="Label124" runat="server" Text="Adınız:" 
                    Font-Names="Times New Roman"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtGonderenAd" runat="server" Width="120px" 
                    CssClass="contact_input" MaxLength="50" ValidationGroup="iletisim"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtGonderenAd" 
                    ErrorMessage="Adınız Alanı Boş Geçilemez" ValidationGroup="iletisim">!</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style6">
                <asp:Label ID="Label125" runat="server" Text="Soyadınız:" 
                    Font-Names="Times New Roman"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtGonderenSoyad" runat="server" Width="120px" 
                    CssClass="contact_input" MaxLength="50" ValidationGroup="iletisim"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtGonderenSoyad" 
                    ErrorMessage="Soyadınız Alanı Boş Geçilemez" ValidationGroup="iletisim">!</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style6">
                <asp:Label ID="Label126" runat="server" Text="E-mail:" 
                    Font-Names="Times New Roman"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtGonderenMail" runat="server" Width="138px" 
                    CssClass="contact_input" MaxLength="100" ValidationGroup="iletisim"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtGonderenMail" 
                    ErrorMessage="Mail Kısmı Boş Geçilemez" ValidationGroup="iletisim">!</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="txtGonderenMail" ErrorMessage="Geçersiz E-Mail Formatı" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    ValidationGroup="iletisim">!</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style6">
                <asp:Label ID="Label127" runat="server" Text="Konu:" 
                    Font-Names="Times New Roman"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtGonderenKonu" runat="server" Width="143px" 
                    CssClass="contact_input" MaxLength="120" ValidationGroup="iletisim"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="txtGonderenKonu" 
                    ErrorMessage="Konu Alanı Boş Geçilemez" ValidationGroup="iletisim">!</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style6">
                <asp:Label ID="Label128" runat="server" Text="Mesajınız:" 
                    Font-Names="Times New Roman"></asp:Label>
            </td>
            <td rowspan="3">
                <asp:TextBox ID="txtMailMesaj" runat="server" Height="225px" 
                    TextMode="MultiLine" Width="326px" CssClass="contact_input" 
                    Font-Names="Times New Roman" ValidationGroup="iletisim"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="txtMailMesaj" 
                    ErrorMessage="Mesajınız Alanı Boş Geçilemez" ValidationGroup="iletisim">!</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnMesajGonder" runat="server" Height="26px" 
                    onclick="btnMesajGonder_Click" Text="Mesajı Gönder" Width="112px" 
                    Font-Names="Times New Roman" ValidationGroup="iletisim" 
                    CssClass="contact_input" />
                <br />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:TextBox ID="txtMailSonuc" runat="server" Font-Bold="True" 
                    Font-Italic="True" ForeColor="#77933D" Height="25px" ReadOnly="True" 
                    Visible="False" Width="282px" CssClass="contact_input"></asp:TextBox>
            </td>
        </tr>
    </table>
                        <div></div>
                      
</asp:Content>








