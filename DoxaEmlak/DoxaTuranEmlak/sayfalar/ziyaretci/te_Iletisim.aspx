<%@ Page Language="C#" MasterPageFile="~/sayfalar/ziyaretci/ziyaretciPaneli.master"
    AutoEventWireup="true" CodeFile="te_Iletisim.aspx.cs" Inherits="sayfalar_ziyaretci_te_Iletisim"
    Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>Turan Emlak Oto || 2010 || Ýletiþim</title>
    <style type="text/css">

.main {
	border-top: 4px solid #FFF;
	background: url('../../../../DoxaWeb/DoxaWeb/img/bgmain.gif') repeat-y;
        }

* {
	padding: 0;
	text-align: center;
	margin-left: 0;
	margin-right: 0;
	margin-top: 0;
}

* {
	margin: 0;
	padding: 0;
	text-align: left;
}
        .style6
        {
        width: 119px;
        float: left;
    }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="main" dir="ltr" rules="groups" 
        style="font-family: 'Courier New'; font-size: large; font-weight: normal; position: static; caption-side: bottom; width: 526px;">
        <tr>
            <td class="style6">
                <asp:Label ID="Label124" runat="server" Font-Names="Times New Roman" 
                    Text="Adýnýz:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtGonderenAd" runat="server" CssClass="contact_input" 
                    MaxLength="50" ValidationGroup="iletisim" Width="120px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtGonderenAd" ErrorMessage="Adýnýz Alaný Boþ Geçilemez" 
                    ValidationGroup="iletisim">!</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style6">
                <asp:Label ID="Label125" runat="server" Font-Names="Times New Roman" 
                    Text="Soyadýnýz:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtGonderenSoyad" runat="server" CssClass="contact_input" 
                    MaxLength="50" ValidationGroup="iletisim" Width="120px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtGonderenSoyad" 
                    ErrorMessage="Soyadýnýz Alaný Boþ Geçilemez" ValidationGroup="iletisim">!</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style6">
                <asp:Label ID="Label126" runat="server" Font-Names="Times New Roman" 
                    Text="E-mail:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtGonderenMail" runat="server" CssClass="contact_input" 
                    MaxLength="100" ValidationGroup="iletisim" Width="138px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtGonderenMail" ErrorMessage="Mail Kýsmý Boþ Geçilemez" 
                    ValidationGroup="iletisim">!</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="txtGonderenMail" ErrorMessage="Geçersiz E-Mail Formatý" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    ValidationGroup="iletisim">!</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style6">
                <asp:Label ID="Label127" runat="server" Font-Names="Times New Roman" 
                    Text="Konu:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtGonderenKonu" runat="server" CssClass="contact_input" 
                    MaxLength="120" ValidationGroup="iletisim" Width="143px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="txtGonderenKonu" ErrorMessage="Konu Alaný Boþ Geçilemez" 
                    ValidationGroup="iletisim">!</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style6">
                <asp:Label ID="Label128" runat="server" Font-Names="Times New Roman" 
                    Text="Mesajýnýz:"></asp:Label>
            </td>
            <td rowspan="3">
                <asp:TextBox ID="txtMailMesaj" runat="server" CssClass="contact_input" 
                    Font-Names="Times New Roman" Height="225px" TextMode="MultiLine" 
                    ValidationGroup="iletisim" Width="326px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="txtMailMesaj" ErrorMessage="Mesajýnýz Alaný Boþ Geçilemez" 
                    ValidationGroup="iletisim">!</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnMesajGonder" runat="server" CssClass="contact_input" 
                    Font-Names="Times New Roman" Height="26px" onclick="btnMesajGonder_Click" 
                    Text="Mesajý Gönder" ValidationGroup="iletisim" Width="112px" />
                <br />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:TextBox ID="txtMailSonuc" runat="server" CssClass="contact_input" 
                    Font-Bold="True" Font-Italic="True" ForeColor="#77933D" Height="25px" 
                    ReadOnly="True" Visible="False" Width="282px"></asp:TextBox>
            </td>
        </tr>
    </table>
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
                <li><a href="arama.aspx" title="Arama">Arama</a></li>
                <li class="active"><a href="te_Iletisim.aspx" title="Iletisim">Ýletiþim</a></li>
            </ul>
        </div>
    </div>
</asp:Content>


