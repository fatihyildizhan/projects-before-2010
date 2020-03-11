<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageSayfalar.master" AutoEventWireup="true" CodeFile="createNewAccount.aspx.cs" Inherits="createNewAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content8" runat="server" 
    contentplaceholderid="ContentPlaceHolder4">
                         <div>
                            <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" 
                                ConfirmPasswordCompareErrorMessage="Şifreler eşleşmiyor!" 
                                ConfirmPasswordLabelText="Şifre Tekrar:" 
                                ConfirmPasswordRequiredErrorMessage="Boş Geçilemez." CreateUserButtonText="Profil Oluştur" 
                                DuplicateEmailErrorMessage="Mevcut E-Posta adresi!." 
                                DuplicateUserNameErrorMessage="Mevcut kullanıcı adı!" 
                                InvalidEmailErrorMessage="Lüfen geçerli mail adresi giriniz!" 
                                InvalidPasswordErrorMessage="Şifre için Mininum harf sayısı: {0}. Minimum karakter sayısı: {1}." 
                                UnknownErrorMessage="Profiliniz oluşturulamadı. Lütfen tekrar deneyiniz." 
                                Width="294px" BackColor="#F7F6F3" BorderColor="#E6E2D8" BorderStyle="Solid" 
                                 BorderWidth="1px" EmailRegularExpressionErrorMessage="Geçersiz E-Posta" 
                                 Font-Names="Trebuchet MS, Small" 
                                 PasswordRegularExpressionErrorMessage="Geçersiz şifre" 
                                 oncreateduser="CreateUserWizard1_CreatedUser" 
                                 FinishCompleteButtonText="Tamamla">
                                <SideBarStyle BackColor="#5D7B9D" BorderWidth="0px" Font-Size="0.9em" 
                                    VerticalAlign="Top" />
                                <SideBarButtonStyle BorderWidth="0px" Font-Names="Verdana" ForeColor="White" />
                                <ContinueButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" 
                                    BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
                                    ForeColor="#284775" />
                                <NavigationButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" 
                                    BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
                                    ForeColor="#284775" />
                                <HeaderStyle BackColor="#5D7B9D" BorderStyle="Solid" Font-Bold="True" 
                                    Font-Size="0.9em" ForeColor="White" HorizontalAlign="Center" />
                                <CreateUserButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" 
                                    BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
                                    ForeColor="#284775" />
                                <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <StepStyle BorderWidth="0px" />
                                <WizardSteps>
                                    <asp:CreateUserWizardStep runat="server" Title="Yeni Profil Oluştur" >
                                        <ContentTemplate>
                                            <table border="0" style="font-family:Verdana;font-size:100%;width:279px;">
                                                <tr>
                                                    <td align="center" colspan="2" 
                                                        style="color:White;background-color:#5D7B9D;font-weight:bold;">
                                                        Yeni Profil Oluştur...</td>
                                                </tr>
                                                <tr>
                                                    <td align="right">
                                                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Kullanıcı Adı:</asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="UserName" runat="server" CssClass="contact_input" 
                                                            MaxLength="50" Width="100px"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" 
                                                            ControlToValidate="UserName" ErrorMessage="User Name is required." 
                                                            ToolTip="User Name is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="right">
                                                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Şifre:</asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="Password" runat="server" TextMode="Password" 
                                                            CssClass="contact_input" MaxLength="50" Width="100px"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" 
                                                            ControlToValidate="Password" ErrorMessage="Password is required." 
                                                            ToolTip="Password is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="right">
                                                        <asp:Label ID="ConfirmPasswordLabel" runat="server" 
                                                            AssociatedControlID="ConfirmPassword">Şifre Tekrar:</asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password" 
                                                            CssClass="contact_input" MaxLength="50" Width="100px"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" 
                                                            ControlToValidate="ConfirmPassword" ErrorMessage="Boş Geçilemez." 
                                                            ToolTip="Boş Geçilemez." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="right">
                                                        <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="Email">E-Posta:</asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="Email" runat="server" CssClass="contact_input" MaxLength="50" 
                                                            Width="100px"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="EmailRequired" runat="server" 
                                                            ControlToValidate="Email" ErrorMessage="E-mail is required." 
                                                            ToolTip="E-mail is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="right">
                                                        <asp:Label ID="EmailLabel0" runat="server" AssociatedControlID="Email">E-Posta Tekrar:</asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="EmailTekrar" runat="server" CssClass="contact_input" 
                                                            MaxLength="50" Width="100px"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                            ControlToValidate="EmailTekrar">*</asp:RequiredFieldValidator>
                                                        <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                                            ControlToCompare="Email" ControlToValidate="EmailTekrar" 
                                                            ErrorMessage="E-Posta Adresleriniz Uyuşmuyor">*</asp:CompareValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="center" colspan="2">
                                                        <asp:CompareValidator ID="PasswordCompare" runat="server" 
                                                            ControlToCompare="Password" ControlToValidate="ConfirmPassword" 
                                                            Display="Dynamic" ErrorMessage="Şifreler eşleşmiyor!" 
                                                            ValidationGroup="CreateUserWizard1"></asp:CompareValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="center" colspan="2" style="color:Red;">
                                                        <asp:Literal ID="ErrorMessage" runat="server" EnableViewState="False"></asp:Literal>
                                                    </td>
                                                </tr>
                                            </table>
                                        </ContentTemplate>
                                    </asp:CreateUserWizardStep>
                                    <asp:CompleteWizardStep runat="server" >
                                        <ContentTemplate>
                                            <table border="0">
                                                <tr>
                                                    <td align="center">
                                                        İşlem Tamamlandı.</td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        Profiliniz Başarıyla Oluşturulmuştur.</td>
                                                </tr>
                                                
                                                <tr>
                                                    <td>
                                                        <br />
                                                        *Profil bilgilerinize ulaşmak için lütfen mailinize gelen Aktivasyon E-Postasını 
                                                        onaylayınız.<br />
                                                        <br />
                                                        *Aktivasyon işleminiz gerçekleşmez ise <a href="mailto:info@fatihyildizhan.com">
                                                        info@fatihyildizhan.com</a> adresine Kullanıcı Adınızı ve Sistemdeki E-Posta 
                                                        adresini göndererek Admin tarafından üyeliğinizi aktif hale getirebilirsiniz.<br />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="right">
                                                        <asp:Button ID="ContinueButton" runat="server" CausesValidation="False" 
                                                            CommandName="Continue" Text="Giriş Yap" 
                                                            ValidationGroup="CreateUserWizard1" 
                                                            PostBackUrl="https://www.fatihyildizhan.com/login.aspx" />
                                                    </td>
                                                </tr>
                                            </table>
                                        </ContentTemplate>
                                    </asp:CompleteWizardStep>
                                </WizardSteps>
                            </asp:CreateUserWizard>
                            
                             <br />
                             <asp:Panel ID="Panel1" runat="server" Visible="False" Height="133px">
                                 <asp:Label ID="lblOnaySonuc" runat="server"></asp:Label>
                                 <table>
                                     <tr>
                                         <td>
                                             Kullanıcı Adınız :</td>
                                         <td>
                                             <asp:TextBox ID="txtKullaniciAd" runat="server" CssClass="contact_input" 
                                             Width="100px" ReadOnly="True" ValidationGroup="onay"></asp:TextBox>
                                             <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" 
                                                 ControlToValidate="txtKullaniciAd">*</asp:RequiredFieldValidator>
                                         </td>
                                     </tr>
                                     <tr>
                                         <td>
                                             Onay Kodu :</td>
                                         <td>
                                             <asp:TextBox ID="txtOnayKodu" runat="server" CssClass="contact_input" 
                                             MaxLength="50" Width="100px"></asp:TextBox>
                                             <asp:RequiredFieldValidator ID="RequiredFieldValidator33" runat="server" 
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
                        </div>
                      
</asp:Content>
<asp:Content ID="Content9" runat="server" 
    contentplaceholderid="ContentPlaceHolder2">

                        <a href="index.aspx" title="Anasayfa">Anasayfa</a>
	                    <a href="haberler.aspx" title="konular">Haberler </a>
	                    <a href="https://www.fatihyildizhan.com/User/download.aspx" title="download">Download </a>
	                    <a href="hakkimda.aspx" title="hakkimda">Hakkımda </a>
	                    <a href="iletisim.aspx" title="iletisim">İletişim </a>
                        <div class="clearer"><span></span></div>
                    
</asp:Content>








