<%@ Page Title="" Language="C#" MasterPageFile="~/Sayfalar.master" AutoEventWireup="true" CodeFile="YoneticiPaneli.aspx.cs" Inherits="Yonetici_YoneticiPaneli" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 149px;
        }
        .style3
        {
            width: 329px;
        }
    .style4
    {
        width: 147px;
    }
    </style>
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <div>

    <table class="style1">
        <tr>
            <td class="style2">
                Urun Adý:</td>
            <td class="style3">
                <asp:TextBox ID="txtUrunAd" runat="server" Width="313px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Kategori Adý:
            </td>
            <td class="style3">
                <asp:DropDownList ID="ddlKategori" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="ddlKategori_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Açýklama:</td>
            <td class="style3">
                <asp:TextBox ID="txtAciklama" runat="server" Height="127px" 
                    TextMode="MultiLine" Width="320px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Aðýrlýk:</td>
            <td class="style3">
                <asp:TextBox ID="txtAgirlik" runat="server" Width="68px"></asp:TextBox>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem>Kilogram</asp:ListItem>
                    <asp:ListItem>Gram</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Resim:</td>
            <td class="style3">
                <asp:TextBox ID="txtResimYolu" runat="server" Width="316px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Button ID="btnUrunEkle" runat="server" onclick="btnUrunEkle_Click" 
                    Text="Ürün Ekle" Width="123px" />
            </td>
            <td class="style3">
                <asp:Label ID="lblUrunEkleSonuc" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <br />
    <table class="style1">
        <tr>
            <td class="style4">
                Ürün Adý:</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    DataSourceID="SqlDataSource1" DataTextField="UrunAd" 
                    DataValueField="UrunId">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:TakisogluConnectionString %>" 
                    SelectCommand="SELECT [UrunId], [UrunAd] FROM [Urun]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Adet Aðýrlýðý:</td>
            <td>
                <asp:TextBox ID="txtAdetAgirligi" runat="server"></asp:TextBox>
                <br />
                <asp:RadioButtonList ID="RadioButtonList3" runat="server">
                    <asp:ListItem>Kilogram</asp:ListItem>
                    <asp:ListItem>Gram</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Koli Ýçi Adedi:</td>
            <td>
                <asp:TextBox ID="txtKoliIciAdedi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Ambalaj Tipi:</td>
            <td>
                <asp:TextBox ID="txtAmbalajTipi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Ambalaj Aðýrlýðý:</td>
            <td>
                <asp:TextBox ID="txtAmbalajAgirligi" runat="server"></asp:TextBox>
                <br />
                <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                    <asp:ListItem>Kilogram</asp:ListItem>
                    <asp:ListItem>Gram</asp:ListItem>
                </asp:RadioButtonList>
                <br />
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                BESÝN DEÐERLERÝ</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                Kaç Gram Ýçin?</td>
            <td>
                <asp:TextBox ID="txtKacGramIcin" runat="server">100</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Enerji(kcal)</td>
            <td>
                <asp:TextBox ID="txtEnerji" runat="server">375</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Protein(gram)</td>
            <td>
                <asp:TextBox ID="txtProtein" runat="server">26</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Yag(gram)</td>
            <td>
                <asp:TextBox ID="txtYag" runat="server">28</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Tuz(gram)</td>
            <td>
                <asp:TextBox ID="txtTuz" runat="server">2.5</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Kolestrol(mg)</td>
            <td>
                <asp:TextBox ID="txtKolestrol" runat="server">89</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Kalsiyum(mg)</td>
            <td>
                <asp:TextBox ID="txtKalsiyum" runat="server">980</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Fosfor(mg)</td>
            <td>
                <asp:TextBox ID="txtFosfor" runat="server">560</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                <asp:Button ID="btnUrunDetayEkle" runat="server" Height="33px" Text="Detay Ekle" 
                    Width="102px" onclick="btnUrunDetayEkle_Click" />
            </td>
            <td>
                <asp:Label ID="lblUrunDetayEkleSonuc" runat="server"></asp:Label>
            </td>
        </tr>
        </table>
<br />
</div>
</asp:Content>


<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="ContentPlaceHolder2">

         <div class="sidenav">
   
        </div>
        
        

</asp:Content>



