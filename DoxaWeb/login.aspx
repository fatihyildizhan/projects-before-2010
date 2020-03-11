<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageSayfalar.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style7
        {
            width: 100%;
        }
        .style8
        {
            height: 24px;
        }
        .style9
        {
            width: 113px;
        }
        .style10
        {
            height: 24px;
            width: 113px;
        }
        .style11
        {
            height: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder4">
                        <div>
                            <br />
                            <asp:Login ID="Login1" runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8" 
                                BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" 
                                CreateUserText="Kayıt Ol." CreateUserUrl="~/sozlesme.aspx" 
                                DestinationPageUrl="~/index.aspx" Font-Names="Trebuchet MS" Font-Size="Small" 
                                ForeColor="#333333" FailureText="Geçersiz Deneme. Tekrar deneyiniz." 
                                LoginButtonText="Giriş" PasswordLabelText="Şifreniz:" 
                                PasswordRequiredErrorMessage="Şifre Boş Geçilemez." 
                                RememberMeText="Beni Hatırla" TitleText="Giriş Paneli" 
                                UserNameLabelText="Kullanıcı Adınız:" 
                                UserNameRequiredErrorMessage="Kullanıcı Adı boş geçilemez." 
                                VisibleWhenLoggedIn="False">
                                <TextBoxStyle Font-Size="0.8em" />
                                <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" 
                                    BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                                <LayoutTemplate>
                                    <table border="0" cellpadding="4" cellspacing="0" 
                                        style="border-collapse:collapse;">
                                        <tr>
                                            <td>
                                                <table border="0" cellpadding="0">
                                                    <tr>
                                                        <td align="center" colspan="2" 
                                                            style="color:White;background-color:#5D7B9D;font-size:0.9em;font-weight:bold;">
                                                            Giriş Paneli</td>
                                                    </tr>
                                                    <tr>
                                                        <td align="right" class="style11">
                                                            <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Kullanıcı Adınız:</asp:Label>
                                                        </td>
                                                        <td class="style11">
                                                            <asp:TextBox ID="UserName" runat="server" Font-Size="0.8em" 
                                                                CssClass="contact_input" MaxLength="50" Width="100px"></asp:TextBox>
                                                            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" 
                                                                ControlToValidate="UserName" ErrorMessage="Kullanıcı Adı boş geçilemez." 
                                                                ToolTip="Kullanıcı Adı boş geçilemez." ValidationGroup="Login1" 
                                                                Display="Dynamic">*</asp:RequiredFieldValidator>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="right">
                                                            <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Şifreniz:</asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="Password" runat="server" Font-Size="0.8em" TextMode="Password" 
                                                                CssClass="contact_input" MaxLength="50" Width="100px"></asp:TextBox>
                                                            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" 
                                                                ControlToValidate="Password" ErrorMessage="Şifre Boş Geçilemez." 
                                                                ToolTip="Şifre Boş Geçilemez." ValidationGroup="Login1" Display="Dynamic">*</asp:RequiredFieldValidator>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="center" colspan="2" style="color:Red;">
                                                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="48px" 
                                                                ValidationGroup="Login1" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="right" colspan="2">
                                                            <asp:Button ID="LoginButton" runat="server" BackColor="#FFFBFF" 
                                                                BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" CommandName="Login" 
                                                                Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" Text="Giriş" 
                                                                ValidationGroup="Login1" Height="26px" Width="85px" 
                                                                 />
                                                            <asp:Button ID="LoginButton0" runat="server" BackColor="#FFFBFF" 
                                                                BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" CommandName="Login" 
                                                                Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" Height="26px" 
                                                                onclick="LoginButton0_Click" Text="Şifremi Unuttum" ValidationGroup="Login12" 
                                                                Width="99px" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                            <asp:HyperLink ID="CreateUserLink" runat="server" NavigateUrl="~/sozlesme.aspx">Kayıt Ol.</asp:HyperLink>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </LayoutTemplate>
                                <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                                <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" 
                                    ForeColor="White" />
                            </asp:Login>
                            <br />
                            <br />
                            <br />
                            <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Height="150px" Visible="False" Width="308px" 
                                Font-Names="Trebuchet MS, Small">
                                <table class="style7" cellpadding="0px" cellspacing="0px">
                                    <tr>
                                        <td colspan="2">
                                            Şifremi Unuttum !</td>
                                    </tr>
                                    <tr>
                                        <td class="style9">
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style10">
                                            Kullanıcı Adı:</td>
                                        <td class="style8">
                                            <asp:TextBox ID="txtKullaniciAd" runat="server" 
                                                ValidationGroup="SifremiUnuttum" CssClass="contact_input" MaxLength="50" 
                                                Width="100px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                ControlToValidate="txtKullaniciAd" ErrorMessage="Kullanıcı Adı Boş Geçilemez!" 
                                                ValidationGroup="SifremiUnuttum" Display="Dynamic">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style9">
                                            E-Posta:</td>
                                        <td>
                                            <asp:TextBox ID="txtEPosta" runat="server" CssClass="contact_input" 
                                                MaxLength="50" Width="100px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                ControlToValidate="txtEPosta" ErrorMessage="E-Posta Boş Geçilemez!" 
                                                ValidationGroup="SifremiUnuttum" Display="Dynamic">*</asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                                ControlToValidate="txtEPosta" ErrorMessage="Geçersiz E-Posta Formatı !" 
                                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                                ValidationGroup="SifremiUnuttum" Display="Dynamic">*</asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:ValidationSummary ID="ValidationSummary2" runat="server" 
                                                ValidationGroup="SifremiUnuttum" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style9">
                                            <asp:Button ID="btnSifreSifirla" runat="server" onclick="btnSifreSifirla_Click" 
                                                Text="Şifremi Sıfırla" ValidationGroup="SifremiUnuttum" Width="100px" 
                                                CssClass="contact_input" Height="20px" />
                                        </td>
                                        <td>
                                            <asp:Label ID="lblSifremiUnuttumSonuc" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
    </div>
                      
</asp:Content>

















<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="ContentPlaceHolder2">

                        <a href="index.aspx" title="Anasayfa">Anasayfa</a>
	                    <a href="Haberler.aspx" title="konular">Haberler </a>
	                    <a href="User/Download.aspx" title="download">Download </a>
	                    <a href="Hakkimda.aspx" title="hakkimda">Hakkımda </a>
	                    <a href="iletisim.aspx" title="iletisim">İletişim </a>
                        <div class="clearer"><span></span></div>
                    
</asp:Content>


















<asp:Content ID="Content4" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">

                    <div class="sidenav">
			<h2>Programlama Dilleri</h2>
			<ul>
                <li><a href="java.aspx" title="java">Java </a></li>
		        <li><a href="cSharp.aspx" title="cSharp">C# </a></li>
		        <li><a href="adoNet.aspx" title="adoNet">ADO.NET </a></li>
		        <li><a href="xml.aspx" title="xml">XML </a></li>
		        <li><a href="html.aspx" title="html">Html </a></li>
		        <li><a href="transactSql.aspx" title="transactSql">Transact-SQL</a></li>			                          
		    </ul>
			<h2>Programlar</h2>
			<ul>
				 <li><a href="eclipse.aspx" title="eclipse">Eclipse </a></li>
		         <li><a href="visualStudio.aspx" title="visualStudio">Visual Studio </a></li>
		         <li><a href="sqlServer.aspx" title="sqlServer">Sql Server</a></li>
			</ul>
			<h2>Üye Paneli</h2>
			<ul>
                <asp:LoginView ID="LoginView1" runat="server">
                    <RoleGroups>
                        <asp:RoleGroup Roles="Admin">
                            <ContentTemplate>
                                <li>
                               </li>
                                <li>
                                    <asp:LoginName ID="LoginName1" runat="server" Font-Size="Small" 
                                        FormatString="Hoşgeldin : {0}" />
                                </li>
                                <asp:HyperLink ID="HyperLink1" runat="server" 
                                    NavigateUrl="~/User/userPanel.aspx" Width="104px">Profilim</asp:HyperLink>
                               <li>
                                   <asp:HyperLink ID="HyperLink3" runat="server" 
                                       NavigateUrl="~/Management/adminPanel.aspx" Width="107px">Yönetim Paneli</asp:HyperLink>
                               </li>
                            </ContentTemplate>
                        </asp:RoleGroup>
                    </RoleGroups>
                    <LoggedInTemplate>
                       <li>
                           <asp:LoginName ID="LoginName1" runat="server" Font-Size="Small" 
                               FormatString="Hoşgeldin : {0}" Font-Italic="True" />
                       </li>
                        <li>
                            <asp:HyperLink ID="HyperLink2" runat="server" 
                                NavigateUrl="~/User/userPanel.aspx" Width="97px">Profilim &gt;&gt;&gt;</asp:HyperLink></li> 
                    </LoggedInTemplate>
                    <AnonymousTemplate>
                        <li>
                            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/sozlesme.aspx" 
                                Width="104px">Kayıt Ol &gt;&gt;&gt;</asp:HyperLink>
                        </li>
                    </AnonymousTemplate>
                </asp:LoginView>
                <li>
                     <asp:LoginStatus ID="LoginStatus1" runat="server" LoginText="Giriş" 
                         LogoutText="Güvenli Çıkış" LogoutPageUrl="~/login.aspx" />
                 </li>
			</ul>
			<br />
     </div>
                    
</asp:Content>



















