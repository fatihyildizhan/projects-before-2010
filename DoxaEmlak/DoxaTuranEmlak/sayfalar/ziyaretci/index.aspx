<%@ Page Language="C#" MasterPageFile="~/sayfalar/ziyaretci/ziyaretciPaneli.master"
    AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="sayfalar_ziyaretci_index"
    Title="Turan Oto Emlak 2010 | Anasayfa" %>

<%@ Register Src="../ziyaretciWuc/EmlakARA_Menu.ascx" TagName="EmlakARA_Menu" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="stylesheet" type="text/css" href="../../shadowbox/shadowbox.css" />

    <script type="text/javascript" src="../../shadowbox/shadowbox.js"></script>

    <script type="text/javascript">
        Shadowbox.init();
    </script>

</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <uc1:EmlakARA_Menu ID="EmlakARA_Menu1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="ContentPlaceHolder3">
    <div id="divSlideDesk">
        <div class="divClear">
        </div>
        <div id="slidedeck_frame">
            <dl class="slidedeck">
                <dt>Turan Emlak Oto HAKKIMIZDA</dt>
                <dd>
                    1974 yýlýnda halen bulunduðu yerde hizmet vermeye baþlayan Turan Emlak Oto tamamýyla
                    bir aile þirketi olup, altyapýsýný GÜVENÝLÝRLÝK ve DÜRÜSTLÜK üzerine kurmuþtur.
                    Amacýmýz % 100 MÜÞTERÝ MEMNUNÝYETÝ, politikamýz BÝR MÜÞTERÝ BÝN MÜÞTERÝ politikasýdýr.
                    Ýhtiyacýnýz olduðunda hizmetinizdeyiz. Daima çalýþma dileklerimizle ...
                </dd>
                <dt>Hizmetlerimiz</dt>
                <dd>
                    Turan Emlak Oto birçok semtte KONUT kiralamaktadýr. Hizmetlerimiz HizmetlerimizHizmetlerimizHizmetlerimiz
                    Hizmetlerimiz HizmetlerimizHizmetlerimizHizmetlerimiz Hizmetlerimiz HizmetlerimizHizmetlerimizHizmetlerimiz
                    Hizmetlerimiz HizmetlerimizHizmetlerimizHizmetlerimiz Hizmetlerimiz HizmetlerimizHizmetlerimizHizmetlerimiz
                    Hizmetlerimiz HizmetlerimizHizmetlerimizHizmetlerimiz Hizmetlerimiz HizmetlerimizHizmetlerimizHizmetlerimiz
                    Turan Emlak Oto birçok semtte KONUT kiralamaktadýr. Hizmetlerimiz HizmetlerimizHizmetlerimizHizmetlerimiz
                    Hizmetlerimiz HizmetlerimizHizmetlerimizHizmetlerimiz Hizmetlerimiz HizmetlerimizHizmetlerimizHizmetlerimiz
                    Hizmetlerimiz HizmetlerimizHizmetlerimizHizmetlerimiz Hizmetlerimiz HizmetlerimizHizmetlerimizHizmetlerimiz
                </dd>
                <dt>Ekibimiz</dt>
                <dd>
                    Ekibimiz Ekibimiz Ekibimiz Ekibimiz Ekibimiz Ekibimiz Ekibimiz Ekibimiz Ekibimiz
                    Ekibimiz Ekibimiz Ekibimiz Ekibimiz Ekibimiz Ekibimiz Ekibimiz Ekibimiz Ekibimiz
                    Ekibimiz Ekibimiz Ekibimiz Ekibimiz Ekibimiz Ekibimiz Ekibimiz Ekibimiz Ekibimiz
                    Ekibimiz Ekibimiz Ekibimiz Ekibimiz Ekibimiz Ekibimiz Ekibimiz Ekibimiz Ekibimiz
                    Ekibimiz Ekibimiz Ekibimiz Ekibimiz Ekibimiz Ekibimiz Ekibimiz Ekibimiz Ekibimiz
                    Ekibimiz Ekibimiz Ekibimiz Ekibimiz Turan Emlak Oto birçok semtte ARSA kiralamaktadýr.</dd>
                <dt>Referanslarýmýz</dt>
                <dd>
                    Turan Emlak Oto birçok semtte ÝÞYERÝ kiralamaktadýr.</dd>
                <dt>Bölgesel Bilgi</dt>
                <dd>
                    Turan Emlak Oto birçok semtte YAZLIK kiralamaktadýr.</dd>
                <dt>Haritalar</dt>
                <dd>
                    Turan Emlak Oto birçok semtte DEVREMÜLK kiralamaktadýr.</dd>
                <dt>Linkler</dt>
                <dd>
                    Turan Emlak Oto birçok semtte BÝNA kiralamaktadýr.</dd>
            </dl>
        </div>

        <script type="text/javascript">
            $('.slidedeck').slidedeck();
        </script>

        <div class="divClear">
        </div>
    </div>
</asp:Content>
