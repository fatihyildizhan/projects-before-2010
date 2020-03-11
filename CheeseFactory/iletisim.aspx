<%@ Page Title="" Language="C#" MasterPageFile="~/Sayfalar.master" AutoEventWireup="true" CodeFile="iletisim.aspx.cs" Inherits="iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">


* {
	margin: 0;
	padding: 0;
	text-align: left;
}

    .style6
    {
        width: 100%;
        height: 100%;
    }
                        
        .style6
        {
            width: 200px;
            float: left;
        }
    </style>
</asp:Content>



<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder2">

         <div class="sidenav">
          <table id="mytable" >
          <tr>
          <th scope="row" class="spec">
              <asp:LinkButton ID="lbEpostaGonder" runat="server" 
                  onclick="lbEpostaGonder_Click" ValidationGroup="1">E-POSTA GÖNDERİN</asp:LinkButton></th>
          </tr>
          <tr>
          <th scope="row" class="spec">
              <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
                  ValidationGroup="1">GOOGLE MAP</asp:LinkButton>
              </th>
          </tr>
          <tr>
          <th scope="row" class="spec">
              <asp:LinkButton ID="LinkButton2" runat="server" 
                  onclick="LinkButton2_Click" ValidationGroup="1">BAYİLERİMİZ</asp:LinkButton></th>
          </tr>
          <tr>
          <th scope="row" class="spec">
              <asp:LinkButton ID="LinkButton3" runat="server" 
                  onclick="LinkButton3_Click" ValidationGroup="1">İLETİŞİM BİLGİLERİMİZ</asp:LinkButton></th>
          </tr>
          <tr>
          <th scope="row" class="spec"><a href="#" title="">LAF OLSUN TORBA DOLSUN:D</a></th>
          </tr>
          </table>
        </div>
        
</asp:Content>
<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">

            <div class="content">
                <asp:Panel ID="PanelMailGonder" runat="server">
                    <table class="main" dir="ltr" rules="groups">
                        <tr>
                            <td class="style6">
                                <asp:Label ID="Label124" runat="server" Text="Adınız:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtGonderenAd" runat="server" 
                Width="120px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtGonderenAd" 
                ErrorMessage="Adınız Alanı Boş Geçilemez" ValidationGroup="mail">!</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="style6">
                                <asp:Label ID="Label125" runat="server" 
                Text="Soyadınız:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtGonderenSoyad" runat="server" 
                Width="120px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtGonderenSoyad" 
                ErrorMessage="Soyadınız Alanı Boş Geçilemez" ValidationGroup="mail">!</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="style6">
                                <asp:Label ID="Label126" runat="server" Text="E-mail:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtGonderenMail" runat="server" 
                Width="138px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtGonderenMail" 
                ErrorMessage="Mail Kısmı Boş Geçilemez" ValidationGroup="mail">!</asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtGonderenMail" 
                ErrorMessage="Geçersiz E-Mail Formatı" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="mail">!</asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="style6">
                                <asp:Label ID="Label127" runat="server" Text="Konu:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtGonderenKonu" runat="server" 
                Width="143px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtGonderenKonu" 
                ErrorMessage="Konu Alanı Boş Geçilemez" ValidationGroup="mail">!</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="style6">
                                <asp:Label ID="Label128" runat="server" 
                Text="Mesajınız:"></asp:Label>
                            </td>
                            <td rowspan="3">
                                <asp:TextBox ID="txtMailMesaj" runat="server" 
                Height="130px" TextMode="MultiLine" Width="345px" ValidationGroup="mail"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtMailMesaj" 
                ErrorMessage="Mesajınız Alanı Boş Geçilemez">!</asp:RequiredFieldValidator>
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
                                <asp:Button ID="btnMesajGonder" runat="server" 
                Height="37px" onclick="btnMesajGonder_Click" Text="Mesajı Gönder" 
                Width="128px" ValidationGroup="mail" />
                                <br />
                                <asp:ValidationSummary ID="ValidationSummary2" runat="server" Font-Size="Small" 
                                    Width="309px" ValidationGroup="mail" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:TextBox ID="txtMailSonuc" runat="server" 
                Font-Bold="True" Font-Italic="True" ForeColor="#77933D" Height="25px" 
                ReadOnly="True" Visible="False" Width="282px"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                <asp:Image ID="Image1" runat="server" Height="270px" 
                    ImageUrl="~/images/gmap.jpg" Width="621px" Visible="False" />
                <asp:Panel ID="PanelAdres" runat="server" Visible="False">
                    Müdür müdür müdür ? :Ahmet Takış
                    <br />
                    Telefon : 999 888 77 66<br />
                    Mail : <a href="mailto:ahmet@takisoglu.net">ahmet@takisoglu.net</a><br />
                    adres: beşiktaş/taksim<br />
                    türkiye/istanbul<br />
                    bayi adı : beşiktaş
                </asp:Panel>
                <asp:Panel ID="PanelBayi" runat="server" Visible="False">
                    Beşiktaş / istanbul<br />
                    Taksim /istanbul<br />
                    Boğaz Köprüsü / istanbul
                </asp:Panel>
            </div>
            
</asp:Content>




<asp:Content ID="Content4" runat="server" 
    contentplaceholderid="ContentPlaceHolder3">

           <div class="container">
            <div id="stylefour">
                <ul>
		        <li><a href="index.aspx" title="">Anasayfa<span>Anasayfamıza hoşgeldiniz</span></a></li>
		        <li><a href="kurumsal.aspx" title="">Kurumsal<span>Kurumsal hizmetlerimiz mevcuttur.</span></a></li>
		        <li><a href="urunler.aspx" title="">Ürünlerimiz<span>En kaliteli ürünler hakkında bilgilenmek için tıklayın</span></a></li>
		        <li><a href="bilgikupu.aspx" title="">Bilgi Küpü<span>Bunları biliyor musunuz?</span></a></li>
		        <li><a href="#" title="">Hakkımızda<span>Hakkımızda genel bilgiler Hakkımızda genel bilgiler Hakkımızda genel bilgiler</span></a></li>
		        <li><a href="#" title="">Deneme<span>Deneme Deneme Deneme DENEM DEnene MDEne MDened dMDed mdee Denemedeeefsfsdfssdfsd</span></a></li>
		        <li><a href="iletisim.aspx" title="" class="current">İletişim<span>İstediğiniz herzaman bize ulaşabilirsiniz</span></a></li>
	            </ul>
            </div>
           </div>
        
</asp:Content>





