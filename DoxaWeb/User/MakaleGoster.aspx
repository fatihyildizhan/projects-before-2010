<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPageUyeler.master" AutoEventWireup="true" CodeFile="MakaleGoster.aspx.cs" Inherits="User_MakaleGoster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style9
        {
            width: 489px;
        }
        .style10
        {
            width: 74px;
        }
        .style11
        {
        }
        .style12
        {
            width: 315px;
        }
        .style13
        {
            width: 704px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content7" runat="server" 
    contentplaceholderid="ContentPlaceHolder3">
                      <div class="right">
                      </div>
                    
</asp:Content>
<asp:Content ID="Content8" runat="server" 
    contentplaceholderid="ContentPlaceHolder2">
                        <a href="../index.aspx" title="Anasayfa">Anasayfa</a>
	                    <a href="../haberler.aspx" title="konular">Haberler</a>
	                    <a href="https://www.fatihyildizhan.com/User/download.aspx" title="download">Download</a>
	                    <a href="../hakkimda.aspx" title="hakkimda">Hakkımda</a>
	                    <a href="../iletisim.aspx" title="iletisim">İletişim</a>
                        <div class="clearer"><span></span></div>
                    
</asp:Content>
<asp:Content ID="Content9" runat="server" 
    contentplaceholderid="ContentPlaceHolder5">
                    <div class="sidenav">
			<h2>Programlama Dilleri</h2>
			<ul>
                <li><a href="../java.aspx" title="java">Java</a></li>
		        <li><a href="../cSharp.aspx" title="cSharp">C#</a></li>
		        <li><a href="../adoNet.aspx" title="adoNet">ADO.NET</a></li>
		        <li><a href="../xml.aspx" title="xml">XML</a></li>
		        <li><a href="../html.aspx" title="html">Html</a></li>
		        <li><a href="../transactSql.aspx" title="transactSql">Transact-SQL</a></li>			                           
		    </ul>
			<h2>Programlar</h2>
			<ul>
				 <li><a href="../eclipse.aspx" title="eclipse">Eclipse</a></li>
		         <li><a href="../visualStudio.aspx" title="visualStudio">Visual Studio</a></li>
		         <li><a href="../sqlServer.aspx" title="sqlServer">Sql Server</a></li>
			</ul>
			<h2>Üye Paneli</h2>
			<ul>
				 <li>
                     <asp:LoginStatus ID="LoginStatus1" runat="server" LoginText="Giriş" 
                         LogoutText="Güvenli Çıkış" LogoutPageUrl="https://www.fatihyildizhan.com/login.aspx" />
                 </li>
                <asp:LoginView ID="LoginView1" runat="server">
                    <RoleGroups>
                        <asp:RoleGroup Roles="Admin">
                            <ContentTemplate>
                                <li>
                                    <asp:HyperLink ID="HyperLink1" runat="server" 
                                        NavigateUrl="https://www.fatihyildizhan.com/User/userPanel.aspx" Width="104px">Profilim</asp:HyperLink>
                               </li>
                               <li>
                                   <asp:HyperLink ID="HyperLink3" runat="server" 
                                       NavigateUrl="https://www.fatihyildizhan.com/Management/adminPanel.aspx" Width="107px">Yönetim Paneli</asp:HyperLink>
                               </li>
                            </ContentTemplate>
                        </asp:RoleGroup>
                    </RoleGroups>
                    <LoggedInTemplate>
                        <li>
                            <asp:HyperLink ID="HyperLink2" runat="server" 
                                NavigateUrl="https://www.fatihyildizhan.com/User/userPanel.aspx" Width="97px">Profilim &gt;&gt;&gt;</asp:HyperLink></li>
                    </LoggedInTemplate>
                    <AnonymousTemplate>
                        <li>
                            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/sozlesme.aspx" 
                                Width="104px">Kayıt Ol &gt;&gt;&gt;</asp:HyperLink>
                        </li>
                    </AnonymousTemplate>
                </asp:LoginView>
			</ul>		
     </div>
                    
</asp:Content>
<asp:Content ID="Content10" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">

</asp:Content>
<asp:Content ID="Content11" runat="server" 
    contentplaceholderid="ContentPlaceHolder4">
                      
                         <div id="table">
                             <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                 onrowcommand="GridView1_RowCommand" AllowPaging="True" PageSize="1" 
                                 Width="520px" Font-Names="Trebuchet MS">
                                 <Columns>
                                     <asp:TemplateField>
                                         <ItemTemplate>
                                             <table class="style9">
                                                 <tr>
                                                     <td colspan="2">
                                                         <asp:Label ID="Label1" runat="server" Text='<%# Eval("MakaleAd") %>'></asp:Label>
                                                     </td>
                                                     <td class="style12">
                                                         <asp:Label ID="Label7" runat="server" Text="Yazar :"></asp:Label>
                                                     </td>
                                                     <td class="style10">
                                                         <asp:LinkButton ID="LinkButton1" runat="server" 
                                                             CommandArgument='<%# Bind("Yazar") %>' CommandName="uyeMesajGonder" 
                                                             Text='<%# Bind("Yazar") %>'></asp:LinkButton>
                                                     </td>
                                                 </tr>
                                                 <tr>
                                                     <td colspan="2">
                                                         Konu :
                                                         <asp:Label ID="Label2" runat="server" Text='<%# Eval("KonuAd") %>'></asp:Label>
                                                     </td>
                                                     <td class="style12">
                                                         <asp:Label ID="Label6" runat="server" Text="Okunma Sayısı :"></asp:Label>
                                                     </td>
                                                     <td class="style10">
                                                         <asp:Label ID="Label8" runat="server" Text='<%# Bind("OkumaSayisi") %>'></asp:Label>
                                                     </td>
                                                 </tr>
                                                 <tr>
                                                     <td class="style11">
                                                         Tarih :</td>
                                                     <td class="style13">
                                                         <asp:Label ID="Label4" runat="server" Text='<%# Eval("EklemeTarihi") %>'></asp:Label>
                                                     </td>
                                                     <td class="style12">
                                                         İndirme Sayısı :</td>
                                                     <td class="style10">
                                                         <asp:Label ID="Label9" runat="server" Text='<%# Bind("IndirmeSayisi") %>'></asp:Label>
                                                     </td>
                                                 </tr>
                                                 <tr>
                                                     <td colspan="4">
                                                         Özet :
                                                         <asp:Label ID="Label3" runat="server" Text='<%# Eval("Ozet") %>'></asp:Label>
                                                     </td>
                                                 </tr>
                                                 <tr>
                                                     <td colspan="4">
                                                         <br />
                                                         <asp:TextBox ID="TextBox1" runat="server" CssClass="contact_input" 
                                                             Height="98px" ReadOnly="True" Text='<%# Bind("Aciklama") %>' 
                                                             TextMode="MultiLine" Width="466px"></asp:TextBox>
                                                         <br />
                                                         <br />
                                                         <br />
                                                         <br />
                                                     </td>
                                                 </tr>
                                                 <tr>
                                                     <td class="style11" colspan="2">
                                                         <asp:LinkButton ID="LinkButton2" runat="server" 
                                                             CommandArgument='<%# Bind("Link") %>' CommandName="UygulamaIndir">Uygulamayı İndir &gt;&gt;&gt;</asp:LinkButton>
                                                     </td>
                                                     <td class="style12">
                                                         &nbsp;</td>
                                                     <td class="style10">
                                                         &nbsp;</td>
                                                 </tr>
                                             </table>
                                         </ItemTemplate>
                                     </asp:TemplateField>
                                 </Columns>
                                 <HeaderStyle BackColor="#A2BB54" />
                             </asp:GridView>
    </div>
                      
                      
</asp:Content>


