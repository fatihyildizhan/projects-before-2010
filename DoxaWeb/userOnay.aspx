<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageSayfalar.master" AutoEventWireup="true" CodeFile="userOnay.aspx.cs" Inherits="userOnay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder4">
                         <div>
                             <br />
                             <br />
                             <asp:Panel ID="Panel1" runat="server" Height="133px">
                                 <asp:Label ID="lblOnaySonuc" runat="server"></asp:Label>
                                 <table>
                                     <tr>
                                         <td>
                                             Kullanıcı Adınız :</td>
                                         <td>
                                             <asp:TextBox ID="txtKullaniciAd" runat="server" CssClass="contact_input" 
                                             Width="100px" ValidationGroup="onay"></asp:TextBox>
                                             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                 ControlToValidate="txtKullaniciAd">*</asp:RequiredFieldValidator>
                                         </td>
                                     </tr>
                                     <tr>
                                         <td>
                                             Onay Kodu :</td>
                                         <td>
                                             <asp:TextBox ID="txtOnayKodu" runat="server" CssClass="contact_input" 
                                             MaxLength="50" Width="100px"></asp:TextBox>
                                             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
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
                             <br />
                             <br />
                             <br />
                         </div>
                      
</asp:Content>






