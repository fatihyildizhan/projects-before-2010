<%@ Page Language="C#" AutoEventWireup="true" CodeFile="haberler.aspx.cs" Inherits="haberler" %>

<%@ Register src="RSSreader.ascx" tagname="RSSreader" tagprefix="uc2" %>

<%@ Register src="istatistik.ascx" tagname="istatistik" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "//www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Fatih Yýldýzhan FyDoxa 2009</title>

<link rel="stylesheet" type="text/css" href="MasterPageSayfalar.css" media="screen" />
<style type="text/css">
                                
    #style6
    {
        width: 100%;
        height: 100%;
    }         
        </style>
    <link href="sdmenu/sdmenu.css" rel="stylesheet" type="text/css" />
	<script type="text/javascript" src="sdmenu/sdmenu.js">
	    /***********************************************
	    * Slashdot Menu script- By DimX
	    * Submitted to Dynamic Drive DHTML code library: //www.dynamicdrive.com
	    * Visit Dynamic Drive at //www.dynamicdrive.com/ for full source code
	    ***********************************************/
	</script>
	<script type="text/javascript">
	    // <![CDATA[
	    var myMenu;
	    window.onload = function() {
	        myMenu = new SDMenu("my_menu");
	        myMenu.init();
	    };
	    // ]]>
	</script>
        </head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="top">
                <div class="header">
	                <div class="left">&nbsp;&nbsp;&nbsp;Fatih YILDIZHAN 	                
                    </div>
                   
                      <div class="right">
                        
                          <uc1:istatistik ID="istatistik1" runat="server" />
                        
                    </div>
                  
                </div>	
            </div>
            <div class="container">	

	            <div class="navigation">
                    
                        <a href="index.aspx" title="Anasayfa">Anasayfa</a>
	                    <a href="haberler.aspx" title="konular">Haberler </a>
	                    <a href="https://www.fatihyildizhan.com/User/Download.aspx" title="download">Download </a>
	                    <a href="hakkimda.aspx" title="hakkimda">Hakkýmda </a>
	                    <a href="linkler.aspx" title="linkler">Linkler </a>
	                    <a href="iletisim.aspx" title="iletisim">Ýletiþim </a>
                        <div class="clearer"><span></span></div>
                    
                </div>

	            <div class="main">		
            		
	              <div class="content">
	                  <asp:SiteMapPath ID="SiteMapPath1" runat="server" Font-Names="Verdana" 
                          Font-Size="0.8em" PathSeparator=" : ">
                          <PathSeparatorStyle Font-Bold="True" ForeColor="#5D7B9D" />
                          <CurrentNodeStyle ForeColor="#333333" />
                          <NodeStyle Font-Bold="True" ForeColor="#7C6F57" />
                          <RootNodeStyle Font-Bold="True" ForeColor="#5D7B9D" />
                      </asp:SiteMapPath>
                      <br />
	                <br/>
	                  <br />
	                  <uc2:RSSreader ID="RSSreader1" runat="server" />
	                  </div>
	
		  <div style="float: right" id="my_menu" class="sdmenu">
<div>
<span>HÜRRÝYET HABER</span>
    <asp:LinkButton ID="lbAnasayfa" runat="server" onclick="lbAnasayfa_Click">Anasayfa Haberleri</asp:LinkButton>
    <asp:LinkButton ID="lbGundem" runat="server" onclick="lbGundem_Click">Gündem</asp:LinkButton>
    <asp:LinkButton ID="lbDunya" runat="server" onclick="lbDunya_Click">Dünya</asp:LinkButton>
    <asp:LinkButton ID="lbEkonomi" runat="server" onclick="lbEkonomi_Click">Ekonomi</asp:LinkButton>
    <asp:LinkButton ID="lbSpor" runat="server" onclick="lbSpor_Click">Spor</asp:LinkButton>
    <asp:LinkButton ID="lbTeknoloji" runat="server" onclick="lbTeknoloji_Click">Teknoloji</asp:LinkButton>
    <asp:LinkButton ID="lbSaglik" runat="server" onclick="lbSaglik_Click">Saðlýk</asp:LinkButton>
    <asp:LinkButton ID="lbKulturSanat" runat="server" onclick="lbKulturSanat_Click">Kültür Sanat</asp:LinkButton>
    <asp:LinkButton ID="lbMagazin" runat="server" onclick="lbMagazin_Click">Magazin</asp:LinkButton>
    <asp:LinkButton ID="lbAstroloji" runat="server" onclick="lbAstroloji_Click">Astroloji</asp:LinkButton>
    <asp:LinkButton ID="lbYazarlar" runat="server" onclick="lbYazarlar_Click">Yazarlar</asp:LinkButton>
</div>
<div class="collapsed">
<span>HÜRRÝYET HABER EKLER</span>
    <asp:LinkButton ID="lbEYasam" runat="server" onclick="lbEYasam_Click">E-Yaþam</asp:LinkButton>
    <asp:LinkButton ID="lbOtoYasam" runat="server" onclick="lbOtoYasam_Click">Oto Yaþam</asp:LinkButton>
    <asp:LinkButton ID="lbSeyahat" runat="server" onclick="lbSeyahat_Click">Seyahat</asp:LinkButton>
    <asp:LinkButton ID="lbPazar" runat="server" onclick="lbPazar_Click">Pazar</asp:LinkButton>
    <asp:LinkButton ID="lbCumartesi" runat="server" onclick="lbCumartesi_Click">Cumartesi</asp:LinkButton>
    <asp:LinkButton ID="lbCuma" runat="server" onclick="lbCuma_Click">Cuma</asp:LinkButton>
    <asp:LinkButton ID="lbKelebek" runat="server" onclick="lbKelebek_Click">Kelebek</asp:LinkButton> 
</div>
<div class="collapsed">
<span>NTV Haber</span>
    <asp:LinkButton ID="lbDunyaNTV" runat="server" onclick="lbDunyaNTV_Click">Dünya</asp:LinkButton>
    <asp:LinkButton ID="lbEkonomiNTV" runat="server" onclick="lbEkonomiNTV_Click">Ekonomi</asp:LinkButton>
    <asp:LinkButton ID="lbHavaVeYol" runat="server" onclick="lbHavaVeYol_Click">Hava ve Yol</asp:LinkButton> 
    <asp:LinkButton ID="lbKulturVeSanat" runat="server" 
        onclick="lbKulturVeSanat_Click">Kültür ve Sanat</asp:LinkButton>
    <asp:LinkButton ID="lbModa" runat="server" onclick="lbModa_Click">Moda</asp:LinkButton>
    <asp:LinkButton ID="lbSaglikNTV" runat="server" onclick="lbSaglikNTV_Click">Saðlýk</asp:LinkButton>
    <asp:LinkButton ID="lbSporNTV" runat="server" onclick="lbSporNTV_Click">Spor</asp:LinkButton>
    <asp:LinkButton ID="lbTeknolojiNTV" runat="server" 
        onclick="lbTeknolojiNTV_Click">Teknoloji</asp:LinkButton>
    <asp:LinkButton ID="lbTurkiye" runat="server" onclick="lbTurkiye_Click">Türkiye</asp:LinkButton>
    <asp:LinkButton ID="lbYasam" runat="server" onclick="lbYasam_Click">Yaþam</asp:LinkButton>
    <asp:LinkButton ID="lbYesilHaber" runat="server" onclick="lbYesilHaber_Click">Yeþil Haber</asp:LinkButton>
</div>
<div class="collapsed">
<span>E-Kolay Haber</span>
    <asp:LinkButton ID="lbHaber" runat="server" onclick="lbHaber_Click">Haber</asp:LinkButton>
    <asp:LinkButton ID="lbSporEKOLAY" runat="server" onclick="lbSporEKOLAY_Click">Spor</asp:LinkButton>
    <asp:LinkButton ID="lbSinema" runat="server" onclick="lbSinema_Click">Sinema</asp:LinkButton> 
    <asp:LinkButton ID="lbKadýn" runat="server" onclick="lbKadýn_Click">Kadýn</asp:LinkButton>
    <asp:LinkButton ID="lbMuzik" runat="server" onclick="lbMuzik_Click">Müzik</asp:LinkButton>
    <asp:LinkButton ID="lbSehir" runat="server" onclick="lbSehir_Click">Þehir</asp:LinkButton>
    <asp:LinkButton ID="lbEglence" runat="server" onclick="lbEglence_Click">Eðlence</asp:LinkButton>
    <asp:LinkButton ID="lbAstrolojiEKOLAY" runat="server" 
        onclick="lbAstrolojiEKOLAY_Click">Astroloji</asp:LinkButton>
    <asp:LinkButton ID="lbSaglikEKOLAY" runat="server" 
        onclick="lbSaglikEKOLAY_Click">Saðlýk</asp:LinkButton>  
</div>
</div>
     
		            <div class="clearer"></div>

	            </div>

	             <div class="footer">Code Design by 
	             <a href="hakkimda.aspx" 
	              title="FyDoxa" style="text-decoration:none;">FyDoXa </a>
                 <asp:ImageButton ID="ImageButton1" runat="server" 
                  ImageUrl="~/img/fatihyildizhan_rss.gif" PostBackUrl="~/rss/rssYayini.aspx" 
                  ImageAlign="Baseline"/>                           
	            </div>
	            <a href="certvalidity.htm" 
	             
                    title="SSL Certificate Free SSL Secure Server Certificate Branded SSL Certificate Authority Wildcard Certificates" 
                    target="_blank">
	            <img src="ipsCASecuredLogoSmall.gif"  
	             alt="ipsCA SSL Secure Certificate" style="border-style: none" />
	            </a>
            </div>
        </div>
    </form>
</body>
</html>