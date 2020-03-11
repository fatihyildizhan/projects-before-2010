using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Text;

public partial class userOnay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnUyeAktifEt_Click(object sender, EventArgs e)
    {
        try
        {
        MembershipUser mu = Membership.GetUser(txtKullaniciAd.Text);
        ProfileCommon pf = Profile.GetProfile(txtKullaniciAd.Text);

        if (mu != null && pf.uyeINFO.OnayKodu == txtOnayKodu.Text)
        {
            Roles.AddUserToRole(mu.UserName, "User");
            lblOnaySonuc.Text = "Üyeliğiniz aktifleştirilmiştir...";
            btnGiriseGit.Visible = true;
        }
        else
        {
            lblOnaySonuc.Text = "Onay işlemi gerçekleşmedi..Tekrar deneyiniz veya Admin ile iletişime geçiniz...";
        }
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
                mail.Subject = "UserOnay aspx Hatası";
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
    protected void btnGiriseGit_Click(object sender, EventArgs e)
    {
        Response.Redirect("index.aspx");
    }
}
