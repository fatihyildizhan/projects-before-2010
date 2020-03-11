<%@ Page Language="C#" MasterPageFile="~/sayfalar/ziyaretci/ziyaretciPaneli.master"
    AutoEventWireup="true" CodeFile="arama.aspx.cs" Inherits="sayfalar_ziyaretci_arama"
    Title="Untitled Page" %>

<%@ Register src="../ziyaretciWuc/emlakARA_Dinamik.ascx" tagname="emlakARA_Dinamik" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>Arama</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <uc1:emlakARA_Dinamik ID="emlakARA_Dinamik1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="ContentPlaceHolder2">
    <div id="header">
        <div id="menu">
            <ul>
                <li><a href="index.aspx" title="Anasayfa">Anasayfa</a></li>
                <li><a href="hakkimizda.aspx" title="Hakkimizda">Hakkýmýzda</a></li>
                <li><a href="te_Konut.aspx?katId=8" title="Konut">Konut</a></li>
                <li><a href="te_Arsa.aspx?katId=13" title="Arsa">Arsa</a></li>
                <li><a href="te_Isyeri.aspx?katId=7" title="Isyeri">Ýþyeri</a></li>
                <li><a href="te_Yazlik.aspx?katId=6" title="Yazlik">Yazlýk</a></li>
                <li><a href="te_Devremulk.aspx?katId=1" title="Devremulk">Devremülk</a></li>
                <li><a href="te_Bina.aspx?katId=11" title="Bina">Bina</a></li>
                <li class="active"><a href="arama.aspx" title="Arama">Arama</a></li>
                <li><a href="te_Iletisim.aspx" title="Iletisim">Ýletiþim</a></li>
            </ul>
        </div>
    </div>
</asp:Content>