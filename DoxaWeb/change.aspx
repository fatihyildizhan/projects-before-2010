<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageSayfalar.master" AutoEventWireup="true" CodeFile="change.aspx.cs" Inherits="change" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style6
        {
            height: 30px;
        }
        .style7
        {
            width: 99px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder4">
                         <div>
                             <asp:Panel ID="Panel1" runat="server" Height="225px" HorizontalAlign="Center" 
                                 Width="291px" BorderStyle="Dashed" BorderWidth="1px">
                                 <table>
                                     <tr>
                                         <td colspan="2" class="style6">
                                             Güvenliğiniz için aktivasyon işlemini E-Postanıza gelen linkten 
                                             gerçekleştirebilirsiniz..<br />
                                         </td>
                                     </tr>
                                     <tr>
                                         <td class="style7">
                                             Kullanıcı Adınız:</td>
                                         <td>
                                             <asp:TextBox ID="txtChangeKullaniciAd" runat="server" CssClass="contact_input" 
                                                 MaxLength="50" Width="100px"></asp:TextBox>
                                             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                 ControlToValidate="txtChangeKullaniciAd">*</asp:RequiredFieldValidator>
                                         </td>
                                     </tr>
                                     <tr>
                                         <td class="style7">
                                             Onay Kodunuz:</td>
                                         <td>
                                             <asp:TextBox ID="txtChangeOnayKodu" runat="server" CssClass="contact_input" 
                                                 MaxLength="50" Width="100px"></asp:TextBox>
                                             <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                 ControlToValidate="txtChangeOnayKodu">*</asp:RequiredFieldValidator>
                                         </td>
                                     </tr>
                                     <tr>
                                         <td class="style7">
                                             Yeni Şifre:</td>
                                         <td>
                                             <asp:TextBox ID="txtSifre" runat="server" CssClass="contact_input" 
                                                 MaxLength="50" TextMode="Password" Width="100px"></asp:TextBox>
                                             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                 ControlToValidate="txtSifre" ErrorMessage="Şifre alanı boş geçilemez...">**</asp:RequiredFieldValidator>
                                         </td>
                                     </tr>
                                     <tr>
                                         <td class="style7">
                                             Yeni Şifre Tekrar:</td>
                                         <td>
                                             <asp:TextBox ID="txtSifreTekrar" runat="server" TextMode="Password" 
                                                 CssClass="contact_input" MaxLength="50" Width="100px"></asp:TextBox>
                                             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                 ErrorMessage="Şifre alanı boş geçilemez..." 
                                                 ControlToValidate="txtSifreTekrar">**</asp:RequiredFieldValidator>
                                             <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                                 ControlToCompare="txtSifre" ControlToValidate="txtSifreTekrar" 
                                                 ErrorMessage="Şifreler Uyuşmuyor...">**</asp:CompareValidator>
                                         </td>
                                     </tr>
                                     <tr>
                                         <td class="style7">
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
                                             <asp:Label ID="lblChangeMesaj0" runat="server"></asp:Label>
                                         </td>
                                     </tr>
                                     <tr>
                                         <td colspan="2">
                                             <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                                         </td>
                                     </tr>
                                 </table>
                             </asp:Panel>
                             <asp:Panel ID="Panel2" runat="server" Visible="False" Height="133px">
                                 <asp:Label ID="lblOnaySonuc" runat="server"></asp:Label>
                                 <table class="style6">
                                     <tr>
                                         <td>
                                             Kullanıcı Adınız :</td>
                                         <td>
                                             <asp:TextBox ID="txtKullaniciAd" runat="server" CssClass="contact_input" 
                                             Width="100px" ReadOnly="True" ValidationGroup="onay"></asp:TextBox>
                                             <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                                 ControlToValidate="txtKullaniciAd">*</asp:RequiredFieldValidator>
                                         </td>
                                     </tr>
                                     <tr>
                                         <td>
                                             Onay Kodu :</td>
                                         <td>
                                             <asp:TextBox ID="txtOnayKodu" runat="server" CssClass="contact_input" 
                                             MaxLength="50" Width="100px"></asp:TextBox>
                                             <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                 ValidationGroup="onay" ControlToValidate="txtOnayKodu">*</asp:RequiredFieldValidator>
                                         </td>
                                     </tr>
                                     <tr>
                                         <td colspan="2">
                                             <asp:Button ID="btnUyeAktifEt" runat="server" onclick="btnUyeAktifEt_Click" 
                                             Text="Aktivasyon" Width="100px" CssClass="contact_input" 
                                                 ValidationGroup="onay" />
                                         </td>
                                     </tr>
                                 </table>
                                 <br />
                                 <asp:Button ID="btnGiriseGit" runat="server" CssClass="contact_input" 
                                     onclick="btnGiriseGit_Click" Text="Anasayfa" Visible="False" 
                                     Width="100px" />
                                 <br />
                             </asp:Panel>
                             </div>                      
</asp:Content>


