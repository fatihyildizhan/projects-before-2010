<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageSayfalar.master" AutoEventWireup="true" CodeFile="rssYayini.aspx.cs" Inherits="rssYayini" %>

<%@ Register src="../istatistik.ascx" tagname="istatistik" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style6
    {
        width: 100%;
    }
    .style7
    {
        font-size: medium;
        font-style: italic;
        font-weight: bold;
    }
</style>
<meta http-equiv="Content-Type" content="text/html;charset=utf-8" />
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-9" />
</asp:Content>
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder4">
    <div>
                             <table class="style6">
                                 <tr>
                                     <td class="style7" colspan="3">
                                         RSS YAYINI</td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <asp:Image ID="Image1" runat="server" ImageUrl="~/img/fatihyildizhan_rss.gif" />
&nbsp;Java Projeleri</td>
                                     <td>
                                         <asp:HyperLink ID="HyperLink5" runat="server" 
                                             NavigateUrl="http://www.fatihyildizhan.com/rss/fydoxaJAVA.xml" Target="_blank">http://www.fatihyildizhan.com/rss/fydoxaJAVA.xml</asp:HyperLink>
                                     </td>
                                     <td>
                                         <asp:ImageButton ID="ImageButton1" runat="server" 
                                             ImageUrl="~/img/fatihyildizhan_xml.gif" oncommand="ImageButton1_Command" />
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <asp:Image ID="Image2" runat="server" ImageUrl="~/img/fatihyildizhan_rss.gif" />
&nbsp;C# Projeleri</td>
                                     <td>
                                         <asp:HyperLink ID="HyperLink6" runat="server" 
                                             NavigateUrl="http://www.fatihyildizhan.com/rss/fydoxaCSHARP.xml" 
                                             Target="_blank">http://www.fatihyildizhan.com/rss/fydoxaCSHARP.xml</asp:HyperLink>
                                     </td>
                                     <td>
                                         <asp:ImageButton ID="ImageButton2" runat="server" 
                                             ImageUrl="~/img/fatihyildizhan_xml.gif" oncommand="ImageButton2_Command" />
                                     </td>
                                 </tr>
                             </table>
</div>
                      

</asp:Content>
<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="ContentPlaceHolder3">
                      <div class="right">
                        
                    </div>
                    
</asp:Content>


<asp:Content ID="Content4" runat="server" 
    contentplaceholderid="ContentPlaceHolder2">

                        <a href="../index.aspx" title="Anasayfa">Anasayfa</a>
	                    <a href="../Haberler.aspx" title="konular">Haberler </a>
	                    <a href="../User/Download.aspx" title="download">Download </a>
	                    <a href="../Hakkimda.aspx" title="hakkimda">Hakkýmda </a>
	                    <a href="../iletisim.aspx" title="iletisim">Ýletiþim </a>
                        <div class="clearer"><span></span></div>
                    
</asp:Content>



<asp:Content ID="Content5" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">

                    <div class="sidenav">
			<h2>Programlama Dilleri</h2>
			<ul>
                <li><a href="../java.aspx" title="java">Java </a></li>
		        <li><a href="../cSharp.aspx" title="cSharp">C# </a></li>
		        <li><a href="../adoNet.aspx" title="adoNet">ADO.NET </a></li>
		        <li><a href="../xml.aspx" title="xml">XML </a></li>
		        <li><a href="../html.aspx" title="html">Html </a></li>
		        <li><a href="../transactSql.aspx" title="transactSql">Transact-SQL</a></li>			                          
		    </ul>
			<h2>Programlar</h2>
			<ul>
				 <li><a href="../eclipse.aspx" title="eclipse">Eclipse </a></li>
		         <li><a href="../visualStudio.aspx" title="visualStudio">Visual Studio </a></li>
		         <li><a href="../sqlServer.aspx" title="sqlServer">Sql Server</a></li>
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
                                        FormatString="Hoþgeldin : {0}" />
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
                               FormatString="Hoþgeldin : {0}" Font-Italic="True" />
                       </li>
                        <li>
                            <asp:HyperLink ID="HyperLink2" runat="server" 
                                NavigateUrl="~/User/userPanel.aspx" Width="97px">Profilim &gt;&gt;&gt;</asp:HyperLink></li> 
                    </LoggedInTemplate>
                    <AnonymousTemplate>
                        <li>
                            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/sozlesme.aspx" 
                                Width="104px">Kayýt Ol &gt;&gt;&gt;</asp:HyperLink>
                        </li>
                    </AnonymousTemplate>
                </asp:LoginView>
                <li>
                     <asp:LoginStatus ID="LoginStatus1" runat="server" LoginText="Giriþ" 
                         LogoutText="Güvenli Çýkýþ" LogoutPageUrl="~/login.aspx" />
                 </li>
			</ul>
			<br />
     </div>
                    
</asp:Content>




