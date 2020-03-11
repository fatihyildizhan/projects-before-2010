<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPageUyeler.master" AutoEventWireup="true" CodeFile="pwdChange.aspx.cs" Inherits="User_pwdRecovery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style6
        {
            width: 100px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content4" runat="server" 
    contentplaceholderid="ContentPlaceHolder4">
    <div>
                         <div>
                             <asp:Panel ID="Panel1" runat="server" Height="208px" HorizontalAlign="Center" 
                                 Width="377px" BorderStyle="Dashed" BorderWidth="1px">
                                 <table>
                                     <tr>
                                         <td colspan="2">
                                             Güvenlik için şifrenizi yeniledikten sonra aktivasyon işlemini mailinize gelen 
                                             linkten gerçekleştirebilirsiniz..<br />
                                         </td>
                                     </tr>
                                     <tr>
                                         <td class="style6">
                                             Eski Şifre:</td>
                                         <td>
                                             <asp:TextBox ID="txtEskiSifre" runat="server" TextMode="Password" 
                                                 CssClass="contact_input" MaxLength="50" Width="100px"></asp:TextBox>
                                             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                 ControlToValidate="txtEskiSifre" ErrorMessage="Şifre alanı boş geçilemez!">**</asp:RequiredFieldValidator>
                                         </td>
                                     </tr>
                                     <tr>
                                         <td class="style6">
                                             Yeni Şifre:</td>
                                         <td>
                                             <asp:TextBox ID="txtYeniSifre" runat="server" TextMode="Password" 
                                                 CssClass="contact_input" MaxLength="50" Width="100px"></asp:TextBox>
                                             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                 ControlToValidate="txtYeniSifre" ErrorMessage="Şifre alanı boş geçilemez...">**</asp:RequiredFieldValidator>
                                         </td>
                                     </tr>
                                     <tr>
                                         <td class="style6">
                                             Yeni Şifre Tekrar:</td>
                                         <td width="100px">
                                             <asp:TextBox ID="txtYeniSifreTekrar" runat="server" TextMode="Password" 
                                                 CssClass="contact_input" MaxLength="50" Width="100px"></asp:TextBox>
                                             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                 ErrorMessage="Şifre alanı boş geçilemez..." 
                                                 ControlToValidate="txtYeniSifreTekrar">**</asp:RequiredFieldValidator>
                                             <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                                 ControlToCompare="txtYeniSifre" ControlToValidate="txtYeniSifreTekrar" 
                                                 ErrorMessage="Şifreler Uyuşmuyor...">**</asp:CompareValidator>
                                         </td>
                                     </tr>
                                     <tr>
                                         <td class="style6">
                                             <asp:Button ID="btnSifreYenile" runat="server" Height="25px" 
                                                 onclick="btnSifreYenile_Click" Text="Şifremi Yenile" Width="85px" 
                                                 CssClass="contact_input" />
                                         </td>
                                         <td>
                                             <asp:CheckBox ID="CheckBox1" runat="server" 
                                                 Text="Kullanıcı Adı ve Şifre bilgisini E-Posta ile gönder!" />
                                         </td>
                                     </tr>
                                     <tr>
                                         <td colspan="2">
                                             <asp:Label ID="lblSifreDegistirmeSonuc" runat="server"></asp:Label>
                                         </td>
                                     </tr>
                                     <tr>
                                         <td colspan="2">
                                             <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                                         </td>
                                     </tr>
                                 </table>
                                 <asp:Label ID="lblSifreDegisti" runat="server"></asp:Label>
                             </asp:Panel>
                             </div>
                      
                      </div>
                      


</asp:Content>




