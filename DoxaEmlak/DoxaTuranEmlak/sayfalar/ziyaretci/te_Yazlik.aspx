<%@ Page Language="C#" MasterPageFile="~/sayfalar/ziyaretci/ziyaretciPaneli.master"
    AutoEventWireup="true" CodeFile="te_Yazlik.aspx.cs" Inherits="sayfalar_ziyaretci_te_Yazlik"
    Title="Untitled Page" %>

<%@ Register src="../ziyaretciWuc/emlakGoster_Ozet.ascx" tagname="emlakGoster_Ozet" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>Turan Emlak Oto || 2010 || Yazlık</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<div class="divClear"></div>
    <uc1:emlakGoster_Ozet ID="emlakGoster_Ozet1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="ContentPlaceHolder2">
    <div id="header">
        <div id="menu">
            <ul>
                <li><a href="index.aspx" title="Anasayfa">Anasayfa</a></li>
                <li><a href="hakkimizda.aspx" title="Hakkimizda">Hakkımızda</a></li>
                <li><a href="te_Konut.aspx?katId=8" title="Konut">Konut</a></li>
                <li><a href="te_Arsa.aspx?katId=13" title="Arsa">Arsa</a></li>
                <li><a href="te_Isyeri.aspx?katId=7" title="Isyeri">İşyeri</a></li>
                <li class="active"><a href="te_Yazlik.aspx?katId=6" title="Yazlik">Yazlık</a></li>
                <li><a href="te_Devremulk.aspx?katId=1" title="Devremulk">Devremülk</a></li>
                <li><a href="te_Bina.aspx?katId=11" title="Bina">Bina</a></li>
                <li><a href="arama.aspx" title="Arama">Arama</a></li>
                <li><a href="te_Iletisim.aspx" title="Iletisim">İletişim</a></li>
            </ul>
        </div>
    </div>
</asp:Content>

