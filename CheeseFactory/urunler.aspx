<%@ Page Title="" Language="C#" MasterPageFile="~/Sayfalar.master" AutoEventWireup="true" CodeFile="urunler.aspx.cs" Inherits="urunler" EnableEventValidation="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
<script type="text/javascript">
    function fncc(id) 
    {
        document.getElementById("frameUrunGoster").src = "urunGosterFrame.aspx?katId=" + id;
    }
    </script>
    
     <link rel="stylesheet" type="text/css" href="sdmenu/sdmenu.css" />
	<script type="text/javascript" src="sdmenu/sdmenu.js">
	    /***********************************************
	    * Slashdot Menu script- By DimX
	    * Submitted to Dynamic Drive DHTML code library: http://www.dynamicdrive.com
	    * Visit Dynamic Drive at http://www.dynamicdrive.com/ for full source code
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
    
</asp:Content>

<asp:Content ID="Content4" runat="server" 
    contentplaceholderid="ContentPlaceHolder3">

           <div class="container">
            <div id="stylefour">
                <ul>
		        <li><a href="index.aspx" title="">Anasayfa<span>Anasayfamıza hoşgeldiniz</span></a></li>
		        <li><a href="kurumsal.aspx" title="">Kurumsal<span>Kurumsal hizmetlerimiz mevcuttur.</span></a></li>
		        <li><a href="urunler.aspx" title="" class="current">Ürünlerimiz<span>En kaliteli ürünler hakkında bilgilenmek için tıklayın</span></a></li>
		        <li><a href="bilgikupu.aspx" title="">Bilgi Küpü<span>Bunları biliyor musunuz?</span></a></li>
		        <li><a href="#" title="">Hakkımızda<span>Hakkımızda genel bilgiler</span></a></li>
		        <li><a href="#" title="">Deneme<span>Deneme Deneme Deneme Denemedeeefsfsdfssdfsd</span></a></li>
		        <li><a href="iletisim.aspx" title="">İletişim<span>İstediğiniz herzaman bize ulaşabilirsiniz</span></a></li>
	            </ul>
            </div>
            
           </div>
        
</asp:Content>

<asp:Content ID="Content5" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <div class="contIcerik">
                    <iframe id="frameUrunGoster" frameborder="0" visible="false" name="frameUrunGoster" scrolling="no" 
                             src="slideShowUrunler.aspx" 
                             style="width:686px; height: 526px; margin-top:0px; top:0px;" align="top"></iframe>         
            </div>
</asp:Content>
<asp:Content ID="Content6" runat="server" 
    contentplaceholderid="ContentPlaceHolder2">
         <div class="sidenav">
         <div class="sitemap">
            <asp:SiteMapPath ID="SiteMapPath1" runat="server">
                <NodeStyle ForeColor="Green"  Font-Underline="false" Font-Size="Small"/>
                <RootNodeStyle ForeColor="Green" />
                <CurrentNodeStyle />
            </asp:SiteMapPath>
            <hr />
         </div>
         <br />
             <div id="my_menu" class="sdmenu">
<div style="cursor:pointer">
<span style="margin-bottom:0px;">Beyaz Peynir Frame</span>
<ul style="float:left; margin-top:0px; margin-left:0px; width:200px;">
            <li><a  onclick="fncc(1)" title="Link 1">Beyaz Peynir Klasik</a></li>
			<li><a  onclick="fncc(2)" title="Link 2">Beyaz Peynir Tam Yağlı</a></li>
			<li><a  onclick="fncc(3)" title="Link 3">Beyaz Peynir Yarım Yağlı</a></li>
			<li><a  onclick="fncc(4)" title="Link 4">Beyaz Peynir (Light)</a></li>
</ul>
</div>

<div class="collapsed" style="cursor:pointer">
<span style="margin-bottom:0px;">Kaşar Peynir Grubu</span>
<ul style="float:left; margin-top:0px; margin-left:0px; width:200px;">
            <li><a  onclick="fncc(5)" title="Link 1">Taze Kaşar Blok</a></li>
			<li><a  onclick="fncc(6)" title="Link 2">Taze Kaşar</a></li>
			<li><a  onclick="fncc(7)" title="Link 3">Eski Kaşar Peyniri</a></li>
			<li><a  onclick="fncc(9)" title="Link 4">Dilimli Kaşar</a></li>
</ul>
</div>

<div class="collapsed" style="cursor:pointer">
<span style="margin-bottom:0px;">Yöresel Peynirler</span>
<ul style="float:left; margin-top:0px; margin-left:0px; width:200px;">
            <li><a  onclick="fncc(10)" title="Link 1">Telli Kayış Peyniri</a></li>
			<li><a  onclick="fncc(11)" title="Link 2">Telli Kaşar Peyniri</a></li>
			<li><a  onclick="fncc(13)" title="Link 3">Köy Peyniri</a></li>
			<li><a  onclick="fncc(8)" title="Link 4">Kolot Kaşar</a></li>
			<li><a  onclick="fncc(15)" title="Link 4">Tulum Peyniri</a></li>
</ul>
</div>

<div class="collapsed" style="cursor:pointer">
<span style="margin-bottom:0px;">Lor Grubu</span>
<ul style="float:left; margin-top:0px; margin-left:0px; width:200px;">
            <li><a  onclick="fncc(16)" title="Link 1">Lor Gurubu</a></li>
</ul>
</div>

<div class="collapsed" style="cursor:pointer">
<span style="margin-bottom:0px;">Tereyağı</span>
<ul style="float:left; margin-top:0px; margin-left:0px; width:200px;">
            <li><a  onclick="fncc(22)" title="Link 1">Tereyağı</a></li>
</ul>
</div>

<div class="collapsed" style="cursor:pointer">
<span style="margin-bottom:0px;">Zeytin</span>
<ul style="float:left; margin-top:0px; margin-left:0px; width:200px;">
            <li><a  onclick="fncc(35)" title="Link 1">Zeytin</a></li>
</ul>
</div>

</div>
        </div>
         
</asp:Content>







