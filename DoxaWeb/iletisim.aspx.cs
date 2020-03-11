using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Text;

public partial class User_iletisim : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnMesajGonder_Click(object sender, EventArgs e)
    {
        DateTime simdi = new DateTime();
        simdi = DateTime.Now.ToLocalTime();
        if (Session["gonderimZamani"] == null || Convert.ToDateTime(Session["gonderimZamani"]) < simdi)
        {
            try
            {
                SmtpClient smtp = new SmtpClient();
                MailAddress sndr = new MailAddress(txtGonderenMail.Text, txtGonderenAd.Text + " " + txtGonderenSoyad.Text);
                MailAddress receiver = new MailAddress("fatih@yildizhanlar.com", "FyDoxaAdmin");
                MailMessage mail = new MailMessage(sndr, receiver);
                mail.Subject = txtGonderenKonu.Text;
                mail.Body = txtMailMesaj.Text;
                mail.BodyEncoding = Encoding.Default;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.Normal;
                smtp.Send(mail);

                txtMailSonuc.Visible = true;
                txtMailSonuc.Text = "E-Postanız Bize Ulaşmıştır";
                txtGonderenKonu.Text = "";
                txtMailMesaj.Text = "";
                Session["gonderimZamani"] = DateTime.Now.AddMinutes(10);
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
                    mail.Subject = "İletişim aspx Hatası";
                    mail.Body = "Hata Oluşma Zamanı : " + zaman + " <br/> Ip Adresi : " + ip + " <br/> Yardımcı Link : " + Server.GetLastError().HelpLink + " <br/> Oluşan Son Hata : " + Server.GetLastError().ToString() + " <br/> Inner Exception : " + hata + "  <br/> Son Oluşan Hata'nın Data Bilgisi : " + Server.GetLastError().Data.ToString() + "Exception Adı : " + ex.ToString();
                    mail.BodyEncoding = Encoding.Default;
                    mail.IsBodyHtml = true;
                    mail.Priority = System.Net.Mail.MailPriority.Normal;
                    smtp.Send(mail);
                }
                catch (Exception)
                {
                }
                txtMailSonuc.Visible = true;
                txtMailSonuc.Text = "İşlem Başarısız Tekrar Deneyiniz!";
            }
        }
        else
        {
            string kalanZaman = Convert.ToString(Convert.ToDateTime(Session["gonderimZamani"]) - simdi);

            txtMailSonuc.Text = kalanZaman.Substring(3, 5) + " dakika sonra e-posta gönderebilirsiniz.";
        }
    }
}
