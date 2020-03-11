using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class User_guncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     

        if (!Page.IsPostBack)
        {
            txtDogumTarih.Text = Profile.uyeINFO.DogumTarihi;
            RadioButtonList1.SelectedValue = Profile.uyeINFO.Cinsiyet;
            txtAd.Text = Profile.uyeINFO.Ad;
            txtAktivite.Text = Profile.uyeINFO.Aktivite;
            txtCepTelefonu.Text = Profile.uyeINFO.Cepno;
            txtFavoriSoz.Text = Profile.uyeINFO.FavoriSozu;
            txtIlgiAlani.Text = Profile.uyeINFO.IlgiAlani;
            txtLise.Text = Profile.uyeINFO.Lise;
            txtMemleket.Text = Profile.uyeINFO.Memleket;
            txtMeslek.Text = Profile.uyeINFO.Meslek;
            txtMsn.Text = Profile.uyeINFO.Msn;
            txtNickName.Text = Profile.uyeINFO.Nickname;
            txtRuhDurumu.Text = Profile.uyeINFO.RuhDurumu;
            txtSoyad.Text = Profile.uyeINFO.Soyad;
            txtUniBolum.Text = Profile.uyeINFO.UniBolum;
            txtUnivetsite.Text = Profile.uyeINFO.Universite;
            txtWebSitesi.Text = Profile.uyeINFO.Websitesi;
            txtYasadigiSehir.Text = Profile.uyeINFO.YasadigiSehir;
        }
    }
    protected void btnGuncelle_Click(object sender, EventArgs e)
    {
        try
        {
            Profile.uyeINFO.DogumTarihi = txtDogumTarih.Text;
            Profile.uyeINFO.Ad = txtAd.Text;
            Profile.uyeINFO.Soyad = txtSoyad.Text;
            Profile.uyeINFO.Cinsiyet = RadioButtonList1.SelectedItem.Text;
            Profile.uyeINFO.Aktivite = txtAktivite.Text;
            Profile.uyeINFO.Cepno = txtCepTelefonu.Text;
            Profile.uyeINFO.Msn = txtMsn.Text;
            Profile.uyeINFO.Nickname = txtNickName.Text;
            Profile.uyeINFO.RuhDurumu = txtRuhDurumu.Text;
            Profile.uyeINFO.UniBolum = txtUniBolum.Text;
            Profile.uyeINFO.Universite = txtUnivetsite.Text;
            Profile.uyeINFO.Websitesi = txtWebSitesi.Text;
            Profile.uyeINFO.YasadigiSehir = txtYasadigiSehir.Text;
            Profile.uyeINFO.FavoriSozu = txtFavoriSoz.Text;
            Profile.uyeINFO.IlgiAlani = txtIlgiAlani.Text;
            Profile.uyeINFO.Lise = txtLise.Text;
            Profile.uyeINFO.Memleket = txtMemleket.Text;
            Profile.uyeINFO.Meslek = txtMeslek.Text;
        }
        catch (Exception ex)
        {
            try
            {
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
                System.Net.Mail.MailAddress sndr = new System.Net.Mail.MailAddress("fatih@yildizhanlar.com");
                System.Net.Mail.MailAddress receiver = new System.Net.Mail.MailAddress("fatih@yildizhanlar.com", "FyDoxaAdmin");
                string ip = Request.ServerVariables["REMOTE_ADDR"].ToString();
                string zaman = DateTime.Now.ToLongTimeString();
                string hata = "Inner Exception";
                if (Server.GetLastError().InnerException != null) { hata = Server.GetLastError().InnerException.Message; }

                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage(sndr, receiver);
                mail.Subject = "Üye Profil Güncelleme Hatası";
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
