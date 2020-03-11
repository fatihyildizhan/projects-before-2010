<%@ Page Title="" Language="C#" MasterPageFile="~/Sayfalar.master" AutoEventWireup="true" CodeFile="bilgikupu.aspx.cs" Inherits="bilgikupu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
     <script type="text/javascript">
       
         function fncc(id) 
         {
             if (id == 1) 
             {
                document.getElementById("frm2").src = "sss.aspx";
             }
             else if(id ==2)
             {
                 document.getElementById("frm2").src = "saglikliBeslenmek.aspx";
             }
             else if (id == 3) 
             {
                 document.getElementById("frm2").src = "pratikBilgiler.aspx";
             }
             else if (id == 4) 
             {

             }
             else if (id == 5) 
             {

             }
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
		        <li><a href="urunler.aspx" title="">Ürünlerimiz<span>En kaliteli ürünler hakkında bilgilenmek için tıklayın</span></a></li>
		        <li><a href="bilgikupu.aspx" title="" class="current">Bilgi Küpü<span>Bunları biliyor musunuz?</span></a></li>
		        <li><a href="#" title="">Hakkımızda<span>Hakkımızda genel bilgiler</span></a></li>
		        <li><a href="#" title="">Deneme<span>Deneme Deneme Deneme Denemedeeefsfsdfssdfsd</span></a></li>
		        <li><a href="iletisim.aspx" title="">İletişim<span>İstediğiniz herzaman bize ulaşabilirsiniz</span></a></li>
	            </ul>
            </div>
           </div>
        
</asp:Content>


<asp:Content ID="Content6" runat="server" 
    contentplaceholderid="ContentPlaceHolder2">

         <div class="sidenav">
         <div class="sitemap">
            <asp:SiteMapPath ID="SiteMapPath1" runat="server" Font-Names="Verdana" 
                 Font-Size="0.8em" PathSeparator=" : ">
                <NodeStyle ForeColor="#7C6F57" Font-Size="Small" Font-Bold="True"/>
                <RootNodeStyle ForeColor="#5D7B9D" Font-Bold="True" />
                <PathSeparatorStyle Font-Bold="True" ForeColor="#5D7B9D" />
                <CurrentNodeStyle ForeColor="#333333" />
            </asp:SiteMapPath>
            <hr />
         </div>
             <br />
             <div id="my_menu" class="sdmenu">
<div>
<span style="margin-bottom:0px;" class="collapsed">Bilgi Küpü</span>
<ul style="float:left; margin-top:0px; margin-left:0px; width:200px;">
            <li><a href="#1" onclick="fncc(1)" title="Link 1">Sıkça Sorulan Sorular</a></li>
			<li><a href="#2" onclick="fncc(2)" title="Link 2">Sağlıklı Beslenmek</a></li>
			<li><a href="#3" onclick="fncc(3)" title="Link 3">Pratik Bilgiler</a></li>
			<li><a href="#4" onclick="fncc(4)" title="Link 4">Yemek Tarifleri</a></li>
			<li><a href="#5" onclick="fncc(5)" title="Link 5">Besin Tablosu</a></li>	
</ul>
</div>
</div>
        </div>
</asp:Content>



<asp:Content ID="Content7" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
            <div class="contIcerik">
                <iframe id="frm2" 
                            src="http://www.fatihyildizhan.com" 
                            scrolling="no"  
                            frameborder="0" 
                            style="width:686px; height: 300px; top:10px;">
                         </iframe>
                         <br />
                &nbsp;</div>
            
</asp:Content>




