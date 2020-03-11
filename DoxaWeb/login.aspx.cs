using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Net.Mail;
using System.Text;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void LoginButton0_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Login1.Visible = false;
    }
    protected void btnSifreSifirla_Click(object sender, EventArgs e)
    {
        try
        {
             MembershipUser muAd = Membership.GetUser(txtKullaniciAd.Text);
        string UyeAd = Membership.GetUserNameByEmail(txtEPosta.Text);
       
        if (UyeAd!=null && muAd.UserName.ToLower() == UyeAd.ToLower() )
        {
            string onayKodu = Guid.NewGuid().ToString();
            ProfileCommon pf = Profile.GetProfile(muAd.UserName);
            pf.uyeINFO.OnayKodu = onayKodu;
            pf.Save();

            SmtpClient smtp = new SmtpClient();
            MailAddress sndr = new MailAddress("info@fatihyildizhan.com", "fatihyildizhan.com__Şifre_Sıfırlama_E-Postası ", Encoding.Default);
            MailAddress receiver = new MailAddress(muAd.Email, "Şifre Sıfırlama ", Encoding.Default);
            MailMessage mail = new MailMessage(sndr, receiver);
            mail.Subject = "fatihyildizhan.com__Şifre Sıfırlama";
            mail.Body = "<P>Merhaba Sayın&nbsp;" + muAd.UserName + ",</P><P>&nbsp;&nbsp;&nbsp; Aktivasyon Kodunuz : " + onayKodu + "</P><P>&nbsp;&nbsp;Şifrenizi değiştirmek için <A title=Tıklayın... href=" + "https://www.fatihyildizhan.com/change.aspx" + " target=_blank>Tıklayın...</A></P><P>&nbsp;&nbsp; Beklenmedik bir hata oluştuğunda lütfen <A href=" + "mailto:info@fatihyildizhan.com" + ">info@fatihyildizhan.com</A> adresine mail atınız. Mesajınız en geç 1 gün içerisinde cevaplanacaktır.</P><P>Sitenin içeriği Programlama Dilleri, Programlar, Haberler ve Download bölümlerinden oluşmaktadır. İstek ve Önerileriniz için iletişim bölümünü kullanabilirsiniz...&nbsp;&nbsp;<BR><BR>Son Eklenen Özellikler...<BR><SPAN class=style7><BR class=style6></SPAN><STRONG><U><FONT size=2><SPAN class=style6><SPAN class=style7>*** SSL desteği eklenmiştir...Bilgileri sitenin altındaki logodan edinebilirsiniz;</SPAN></SPAN><BR><BR></FONT></U>** Haberler bölümünden RSS leri takip edebilirsiniz ;<BR>** Java Uygulamaları ;<BR>** C# Uygulamaları ;<BR><BR></STRONG>*** Programlama Dilleri'ndeki mevcut konular için RSS yayını başlamıştır;<BR>(Sayfanın altında RSS linkini bulabilirsiniz..)<BR><BR>*** Sql Cache Dependency ;<I><BR></I>(SqlCache Dependency Nedir ? Sayfayı herhangi bir değişiklik olana kadar serverda saklar ve sitenin çalışma performansını artırır.)<BR><BR>Şuanda Kullanabileceğiniz Özellikler...<BR><BR>*Programla Dillerine İstatistik;<BR>* Üyelik Sistemi ;<BR>-- Üyeler arası mesajlaşma ;<BR>&nbsp;&nbsp;&nbsp; -Gelen Kutusu, Yenile, Mesaj Oku...<BR>&nbsp;&nbsp;&nbsp; *Giden Kutusu Yakında...<BR>* E-Posta ile Aktivasyon İşlemi ;<BR>* Detaylı Üye Profili Oluşturma / Düzenleme ;<BR>* Her konu için örneğin: destek istemek , tavsiyede bulunmak için iletişim paneli ;<BR>* Basit şekilde Java / Uygulama İndirme ;<BR>* Yönetici için Admin Paneli ;<BR><BR>Yakında Kullanıma Sunulacak Özellikler...<BR><BR>* Üyelere özel site ayarları örneğin: Size özel arkaplan rengi , buton rengi , arayüz dili ..<BR>* Üyelere özel istatistik bilgileri ..<BR>* Diğer yazılım dilleri için uygulama indirebilme ..<BR><BR>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Görüşmek Üzere...<BR></P>";

            mail.BodyEncoding = Encoding.Default;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.Normal;
            smtp.Send(mail);
            lblSifremiUnuttumSonuc.Text = "İşlemi tamamlamak için E-Postanıza gelen linki kullanın.";
        }
        else
        {
            lblSifremiUnuttumSonuc.Text = "Kullanıcı Adı Veya E-Posta Bulunamadı!";
        }
        }
        catch (Exception ex)
        {
            try
            {
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
                System.Net.Mail.MailAddress sndr = new System.Net.Mail.MailAddress("");
                System.Net.Mail.MailAddress receiver = new System.Net.Mail.MailAddress("", "");
                string ip = Request.ServerVariables["REMOTE_ADDR"].ToString();
                string zaman = DateTime.Now.ToLongTimeString();
                string hata = "Inner Exception";
                if (Server.GetLastError().InnerException != null) { hata = Server.GetLastError().InnerException.Message; }

                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage(sndr, receiver);
                mail.Subject = "Şifre Sıfırlama login aspx Hatası";
                mail.Body = "Hata Oluşma Zamanı : " + zaman + " <br/> Ip Adresi : " + ip + " <br/> Yardımcı Link : " + Server.GetLastError().HelpLink + " <br/> Oluşan Son Hata : " + Server.GetLastError().ToString() + " <br/> Inner Exception : " + hata + "  <br/> Son Oluşan Hata'nın Data Bilgisi : " + Server.GetLastError().Data.ToString() + "Exception Adı : " + ex.ToString();
                mail.BodyEncoding = Encoding.Default;
                mail.IsBodyHtml = true;
                mail.Priority = System.Net.Mail.MailPriority.Normal;
                smtp.Send(mail);
            }
            catch (Exception)
            {
            }
        }
    }
}
