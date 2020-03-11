using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;
using System.Web.Security;
using System.Text;

public partial class User_mesajlar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if(Request.QueryString["kime"]!=null)
            {
                txtKime.Text = Request.QueryString["kime"].ToString();
                GridView1.Visible = false;
                Panel1.Visible = true;
                lblGidenKutusu.Visible = false;
                lblMesajYok.Visible = false;
                GridView2.Visible = false;
            }
            else
            {
            Grid1Doldur();
            }
        }
    }

    private void Grid1Doldur()
    {
        try
        {
            SqlCommand com = new SqlCommand("MesajGetir", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Kime", Membership.GetUser().UserName);
            SqlDataAdapter da = new SqlDataAdapter(com);

            DataTable dt = new DataTable();

            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();

            if (dt.Rows.Count == 0)
            {
                lblMesajYok.Visible = true;
            }
            else
            {
                lblMesajYok.Visible = false;
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
                mail.Subject = "User Mesajlar aspx Hatası";
                mail.Body = "Hata Oluşma Zamanı : " + zaman + " <br/> Ip Adresi : " + ip + " <br/> Yardımcı Link : " + Server.GetLastError().HelpLink + " <br/> Oluşan Son Hata : " + Server.GetLastError().ToString() + " <br/> Inner Exception : " + hata + "  <br/> Son Oluşan Hata'nın Data Bilgisi : " + Server.GetLastError().Data.ToString() + "Exception Adı : " + ex.ToString();
                mail.BodyEncoding = Encoding.Default;
                mail.IsBodyHtml = true;
                mail.Priority = System.Net.Mail.MailPriority.Normal;
                smtp.Send(mail);
            }
            catch (Exception)
            {
            }
            Response.Redirect(Request.RawUrl);
        }
    }
  
    SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ToString());
    protected void btnMesajGonder_Click(object sender, EventArgs e)
    {
        try
        {
             MembershipUser MesajGidenUye = Membership.GetUser(txtKime.Text);
        if (MesajGidenUye == null)
        {
            lblMesajGonderSonuc.Text = "Gönderilecek Üye Sisteme Kayıtlı Değil!";
        }
        else
        {
            MembershipUser mu = Membership.GetUser();

            SqlCommand com = new SqlCommand("MesajGonder", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Kimden", mu.UserName);
            com.Parameters.AddWithValue("@Mail", mu.Email);
            com.Parameters.AddWithValue("@Kime", txtKime.Text);
            com.Parameters.AddWithValue("@Konu", txtKonu.Text);
            com.Parameters.AddWithValue("@Mesaj", txtMesaj.Text);

            bool kontrol = true;
            int sonuc = 0;
            try
            {
                con.Open();
                sonuc = com.ExecuteNonQuery();
            }
            catch
            {
                kontrol = false;
            }
            finally
            {
                con.Close();
            }

            if (kontrol && sonuc > 0)
            {
                lblMesajGonderSonuc.Text = "Mesaj başarıyla gönderildi...";
                txtKime.Text = "";
                txtKonu.Text = "";
                txtMesaj.Text = "";
            }
            else
            {
                lblMesajGonderSonuc.Text = "Bir sorunla karşılaşıldı. Lütfen tekrar deneyiniz!";
            }
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
                mail.Subject = "Application Error";
                mail.Body = "Hata Oluşma Zamanı : " + zaman + " <br/> Ip Adresi : " + ip + " <br/> Yardımcı Link : " + Server.GetLastError().HelpLink + " <br/> Oluşan Son Hata : " + Server.GetLastError().ToString() + " <br/> Inner Exception : " + hata + "  <br/> Son Oluşan Hata'nın Data Bilgisi : " + Server.GetLastError().Data.ToString() + "Exception Adı : "+ex.ToString();
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
    protected void lbGelenKutusu_Click(object sender, EventArgs e)
    {
        GridView1.Visible = true;
        Panel1.Visible = false;
        lblGidenKutusu.Visible = false;
        GridView2.Visible = false;
    }
    protected void lbGidenKutusu_Click(object sender, EventArgs e)
    {

        GridView1.Visible = false;
        Panel1.Visible = false;
        lblGidenKutusu.Visible = true;
        lblMesajYok.Visible = false;
        GridView2.Visible = false;
    }
    protected void lbYeniMesaj_Click(object sender, EventArgs e)
    {

        GridView1.Visible = false;
        Panel1.Visible = true;
        lblGidenKutusu.Visible = false;
        lblMesajYok.Visible = false;
        GridView2.Visible = false;
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {

        if (e.Row.RowIndex > -1)
        {
            string str = (e.Row.FindControl("LinkButton1") as LinkButton).Text;

            if (str.Length > 20)
            {

                (e.Row.FindControl("LinkButton1") as LinkButton).Text = (e.Row.FindControl("LinkButton1") as LinkButton).Text.Substring(0, 20) + "...";
            }
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "MesajGor")
        {
            try
            {
                SqlCommand comm = new SqlCommand("MesajDetayGetirId", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@Id", Convert.ToInt32(e.CommandArgument));
                comm.Parameters.AddWithValue("@Kime", Membership.GetUser().UserName);
                SqlDataAdapter da = new SqlDataAdapter(comm);

                DataTable dt = new DataTable();

                da.Fill(dt);

                GridView2.DataSource = dt;
                GridView2.DataBind();

                comm.CommandText = "MesajOku";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@MesajId", Convert.ToInt32(e.CommandArgument));
                con.Open();
                comm.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
               Response.Redirect(Request.RawUrl);
            }

            GridView1.Visible = false;
            GridView2.Visible = true;
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        Grid1Doldur();
    }
    protected void lbYenile_Click(object sender, EventArgs e)
    {
        GridView1.Visible = true;
        Panel1.Visible = false;
        lblGidenKutusu.Visible = false;
        GridView2.Visible = false;
        Grid1Doldur();
    }
}
