using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Text;

public partial class iletisim : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnMesajGonder_Click(object sender, EventArgs e)
    {
        // Uye u = (Uye)(Session["whois"]);
        DateTime simdi = new DateTime();
        simdi = DateTime.Now.ToLocalTime();
        if (Session["gonderimZamani"] == null || Convert.ToDateTime(Session["gonderimZamani"]) < simdi)
        {
            try
            {
                SmtpClient smtp = new SmtpClient("LocalHost");
                MailAddress sndr = new MailAddress(txtGonderenMail.Text, txtGonderenAd.Text + " " + txtGonderenSoyad.Text);
                MailAddress receiver = new MailAddress("fatih@yildizhanlar.com", "FyDoxaAdmin");
                MailMessage mail = new MailMessage(sndr, receiver);
                mail.Subject = txtGonderenKonu.Text;
                //mail.Body = "Kullanıcı Adı: " + u.KullaniciAd + "\n Mail Adresi: " + u.Email + "\n\n" + txtMailMesaj.Text;
                mail.Body = txtMailMesaj.Text;
                mail.BodyEncoding = Encoding.Default;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.Normal;
                smtp.Send(mail);

                txtMailSonuc.Visible = true;
                txtMailSonuc.Text = "Mailiniz Bize Ulaşmıştır";
                txtGonderenKonu.Text = "";
                txtMailMesaj.Text = "";
                Session["gonderimZamani"] = DateTime.Now.AddMinutes(10);
            }
            catch (Exception)
            {
                txtMailSonuc.Visible = true;
                txtMailSonuc.Text = "İşlem Başarısız Tekrar Deneyiniz!";
            }
        }
        else
        {
            string kalanZaman = Convert.ToString(Convert.ToDateTime(Session["gonderimZamani"]) - simdi);

            txtMailSonuc.Text = kalanZaman.Substring(3, 5) + " dk sonra tekrar mail atabilirsiniz";
        }
    }
    protected void lbEpostaGonder_Click(object sender, EventArgs e)
    {
        PanelMailGonder.Visible = true;
        PanelAdres.Visible = false;
        Image1.Visible = false;
        PanelBayi.Visible = false;
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        PanelMailGonder.Visible = false;
        PanelAdres.Visible = true;
        Image1.Visible = false;
        PanelBayi.Visible = false;
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        PanelMailGonder.Visible = false;
        PanelAdres.Visible = false;
        Image1.Visible = false;
        PanelBayi.Visible = true;
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        PanelMailGonder.Visible = false;
        PanelAdres.Visible = false;
        Image1.Visible = true;
        PanelBayi.Visible = false;
    }
}
