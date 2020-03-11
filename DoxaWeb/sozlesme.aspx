<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageSayfalar.master" AutoEventWireup="true" CodeFile="sozlesme.aspx.cs" Inherits="sozlesme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style7
        {
            width: 101%;
            text-align:center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content4" runat="server" 
    contentplaceholderid="ContentPlaceHolder4">
                        <div class="style7">
                            <asp:Panel ID="PanelSozlesme" runat="server" Height="500px">
                                <div>
                                    1) Bu forumların yöneticileri ve moderatörleri her ne kadar, her türlü uygunsuz
                                    <br />
                                    ve itiraz edilebilecek içerik ve materyali olabildiğince kısa sürede forumdan
                                    <br />
                                    silecek olsalar da, bütün mesajların incelenmesi mümkün olamayabilmektedir.
                                    <br />
                                    Forumlara gönderilen her mesaj, onu gönderenin görüşlerini yansıtmakta ve 
                                    yazarının
                                    <br />
                                    sorumluluğu altında olup, kendilerine ait mesajlar dışında moderatörler, 
                                    adminler
                                    <br />
                                    ya da webmasterlar kullanıcı mesajlarının içeriğinden dolayı sorumlu 
                                    tutulamazlar.
                                    <br />
                                    <br />
                                    2) Forumlarımızda, aşağılayıcı, alaycı, başkalarını küçümseyen, adminlere veya
                                    <br />
                                    kullanıcılara saygısızlık içeren, müstehcen, kaba, iftira niteliğinde, nefret
                                    <br />
                                    dolu, tehdit edici, huzursuzluk çıkartmaya yönelik, başka kullanıcıların 
                                    kimliğini
                                    <br />
                                    açıklayıcı, kopya yazılım, warez, crack, nocd, şifre kırma, hack ve hile 
                                    kullanımıyla
                                    <br />
                                    ilgili, Türkiye Cumhuriyeti yasalarına, uluslararası kanun, tüzük veya 
                                    anlaşmalara,
                                    <br />
                                    ülkemiz çıkarlarına, kişilik haklarına veya genel toplum ahlak kurallarına 
                                    aykırı,
                                    <br />
                                    din, dil, ırk, cinsiyet ve benzeri ayrımcılıkları destekleyen konular açmak
                                    <br />
                                    ve içerikler göndermek, linkler vermek ve tartışmaları amacının dışına ve diğer
                                    <br />
                                    kullanıcıları rahatsız edecek boyutlara taşımak yasaktır.
                                    <br />
                                    <br />
                                    Yukarıdaki hususların dikkate alınmaması durumunda, kullanıcı derhal ve süresiz
                                    <br />
                                    olarak siteden uzaklaştırılır ve lüzumu halinde servis sağlayıcısı da haberdar
                                    <br />
                                    edilir. Her mesajın IP adresi ve giriş tarihi gerektiğinde yetkili makamlara
                                    <br />
                                    verilmek üzere kaydedilmektedir. Kullanıcılar, bu forumun moderatörlerinin,
                                    <br />
                                    adminlerinin veya webmasterının, kendi iradeleri doğrultusunda herhangi bir
                                    <br />
                                    başlığı silme, taşıma, kilitleme yetkisi olduğunu kabul etmektedirler. 
                                    Kullanıcılar,
                                    <br />
                                    girdikleri her bilginin veritabanında saklanacağını kabul etmektedirler. Her
                                    <br />
                                    ne kadar bu bilgiler, 3. şahıslara verilmeyecek olsalar da, herhangi bir &#39;hack&#39;
                                    <br />
                                    olayı sonucunda bu bilgilerin 3. şahısların eline geçmesi halinde, webmaster,
                                    <br />
                                    moderatör ya da adminler sorumlu tutulamazlar.
                                    <br />
                                    <table class="style7">
                                        <tr>
                                            <td>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Button ID="btnYonlendir" runat="server" onclick="btnYonlendir_Click" 
                                                    Text="Kabul Et" />
                                            </td>
                                        </tr>
                                    </table>
                                    <br />
                                    
                                    </div>
                            </asp:Panel>
    </div>
                      
</asp:Content>










