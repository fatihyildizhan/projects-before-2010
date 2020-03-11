<%@ Page Language="C#" MasterPageFile="~/sayfalar/ziyaretci/ziyaretciPaneli.master"
    AutoEventWireup="true" CodeFile="te_Devremulk.aspx.cs" Inherits="sayfalar_ziyaretci_te_Devremulk"
    Title="Untitled Page" %>

<%@ Register Src="../ziyaretciWuc/emlakGoster_Ozet.ascx" TagName="emlakGoster_Ozet"
    TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>Turan Emlak Oto || 2010 || Devremülk</title>
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
                <li><a href="te_Yazlik.aspx?katId=6" title="Yazlik">Yazlık</a></li>
                <li class="active"><a href="te_Devremulk.aspx?katId=1" title="Devremulk">Devremülk</a></li>
                <li><a href="te_Bina.aspx?katId=11" title="Bina">Bina</a></li>
                <li><a href="arama.aspx" title="Arama">Arama</a></li>
                <li><a href="te_Iletisim.aspx" title="Iletisim">İletişim</a></li>
            </ul>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content6" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <uc1:emlakGoster_Ozet ID="emlakGoster_Ozet1" runat="server" />
</asp:Content>
