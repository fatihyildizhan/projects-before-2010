using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Net.Mail;
using System.Text;

public partial class deneme : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSifreSifirla_Click(object sender, EventArgs e)
    {
        //MembershipUser muAd = Membership.GetUser(txtKullaniciAd.Text);
        ////Roles.RemoveUserFromRole(muAd.UserName, "User");
        //string UyeAd = Membership.GetUserNameByEmail(txtEPosta.Text);

        //if (UyeAd != null && muAd.UserName.ToLower() == UyeAd.ToLower())
        //{
        //    string onayKodu = Guid.NewGuid().ToString();
        //    ProfileCommon pf = Profile.GetProfile(muAd.UserName);
        //    pf.uyeINFO.OnayKodu = onayKodu;
        //    pf.Save();

        //    SmtpClient smtp = new SmtpClient();
        //    MailAddress sndr = new MailAddress("info@fatihyildizhan.com", "fatihyildizhan.com__Şifre_Sıfırlama_E-Postası ", Encoding.Default);
        //    MailAddress receiver = new MailAddress(muAd.Email, "Şifre Sıfırlama ", Encoding.Default);
        //    MailMessage mail = new MailMessage(sndr, receiver);
        //    mail.Subject = "fatihyildizhan.com_Şifre Sıfırlama";
        //    mail.Body = "Merhaba Sayın " + muAd.UserName + ",<br/> Şifrenizi sıfırlamak için aşağıdaki linke tıklayınız... Güvenlik sebebiyle şifrenizi sıfırladıktan sonra aktivasyon işlemini gerçekleştirmeniz gerekmektedir.. <br> Şifrenizi Değiştirmek için Gerekli Onay Kodunuz: " + onayKodu + "<br/> <a href=" + "https://www.fatihyildizhan.com/UyeIslemleri/change.aspx?yenile=" + muAd.UserName + " <br/> Şifrenizi sıfırlamak için tıklayınız!</a> <br/><br/> Linkin üzerine geldiğinize alt scroll barda gideceği adresi görebilirsiniz...<br/><br/>Şuanda Kullanabileceğiniz Özellikler...<br/><br/>* Üyelik Sistemi ;<br/>* E-Posta ile Aktivasyon İşlemi ;<br/>*Detaylı Üye Profili Oluşturma / Düzenleme ;<br/>* Her konu için örneğin: destek istemek , tavsiyede bulunmak için iletişim paneli ;<br/>* Basit şekilde Java / Uygulama İndirme ;<br/>* Yönetici için Admin Paneli ;<br/><br/>Yakında Kullanıma Sunulacak Özellikler...<br/><br/>* Üyeler arası mesajlaşma ..<br/>* Üyelere özel site ayarları örneğin: Size özel arkaplan rengi , buton rengi , arayüz dili ..<br/>* Üyelere özel istatistik bilgileri ..<br/>* Diğer yazılım dilleri için uygulama indirebilme ..<br/>* Download bölümünden program indirebilme ..<br/>* Şifre değiştirebilme ..<br/><br/>Admin E-Posta Adresi: info@fatihyildizhan.com <br/> www.fatihyildizhan.com";

        //    mail.BodyEncoding = Encoding.Default;
        //    mail.IsBodyHtml = true;
        //    mail.Priority = MailPriority.Normal;
        //    smtp.Send(mail);
        //    lblSifremiUnuttumSonuc.Text = "İşlemi tamamlamak için E-Postanıza gelen linki kullanın.";
        //}
        //else
        //{
        //    lblSifremiUnuttumSonuc.Text = "Kullanıcı Adı Veya E-Posta Bulunamadı!";
        //}
    }
}
