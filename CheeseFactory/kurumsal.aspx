<%@ Page Title="" Language="C#" MasterPageFile="~/Sayfalar.master" AutoEventWireup="true" CodeFile="kurumsal.aspx.cs" Inherits="kurumsal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 <script type="text/javascript">
       
         function fncc(id) 
         {
             if (id == 1) 
             {
                document.getElementById("frm2").src = "subelerimiz.aspx";
             }
             else if(id ==2)
             {
                 document.getElementById("frm2").src = "urunTesislerimiz.aspx";
             }
             else if (id == 3) 
             {
                 document.getElementById("frm2").src = "kalitePolitikamiz.aspx";
             }
             else if (id == 4) 
             {
                 document.getElementById("frm2").src = "hakkimizda.aspx";
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

<asp:Content ID="Content5" runat="server" contentplaceholderid="ContentPlaceHolder2">
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
<span style="margin-bottom:0px;" class="collapsed">Kurumsal</span>
<ul style="float:left; margin-top:0px; margin-left:0px; width:200px;">
            <li><a href="#1" onclick="fncc(4)" title="Link 1">Hakkımızda</a></li>
			<li><a href="#2" onclick="fncc(5)" title="Link 2">Vizyonumz</a></li>
			<li><a href="#3" onclick="fncc(6)" title="Link 3">Misyonumuz</a></li>
			<li><a href="#4" onclick="fncc(3)" title="Link 4">Kalite Politikamız</a></li>
			<li><a href="#5" onclick="fncc(2)" title="Link 5">Üretim Tesislerimiz</a></li>	
            <li><a href="#1" onclick="fncc(1)" title="Link 1">Şubelerimiz</a></li>
			<li><a href="#2" onclick="fncc(2)" title="Link 2">Ödüllerimiz</a></li>
			<li><a href="#3" onclick="fncc(7)" title="Link 3">İletişim</a></li>
			<li><a href="#4" onclick="fncc(8)" title="Link 4">Haberler</a></li>
</ul>
</div>
</div>
        </div>
</asp:Content>

<asp:Content ID="Content6" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
            <div class="contIcerik">
                <iframe id="frm2" 
                            src="http://www.fatihyildizhan.com" 
                            scrolling="no"  
                            frameborder="0" 
                            style="width:686px; height: 526px; top:10px;">
                         </iframe>
            </div>
</asp:Content>












