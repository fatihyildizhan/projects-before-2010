using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class RSSreader : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
             if (!Page.IsPostBack)
        {
            if (Request.QueryString["rss"] != null && Session["kanal"] != null)
            {
                if (Session["kanal"].ToString() == "NTV")
                {
                    GridView3.Visible = false;
                    GridView1.Visible = false;
                    GridView2.Visible = true;
                    GridView2.PageSize = 3;
                    GridView2.DataSource = Functions.rssOkuNTV(Request.QueryString["rss"].ToString());
                    if (!Page.IsPostBack)
                    {
                        GridView2.Columns[0].HeaderText += " * NTV " + Session["header"].ToString();
                    }
                    GridView2.DataBind();
                }
                else if (Session["kanal"].ToString() == "HURRIYET")
                {
                    GridView3.Visible = false;
                    GridView2.Visible = false;
                    GridView1.Visible = true;
                    GridView1.PageSize = 7;
                    GridView1.DataSource = Functions.rssOkuHurriyet(Request.QueryString["rss"].ToString());
                    if (!Page.IsPostBack)
                    {
                        GridView1.Columns[0].HeaderText += " * HÜRRİYET " + Session["header"].ToString();
                    }
                    GridView1.DataBind();
                }
                else if (Session["kanal"].ToString() == "EKOLAY")
                {
                    GridView2.Visible = false;
                    GridView1.Visible = false;
                    GridView3.Visible = true;
                    GridView3.PageSize = 7;
                    GridView3.DataSource = Functions.rssOkuEKOLAY(Request.QueryString["rss"].ToString());
                    if (!Page.IsPostBack)
                    {
                        GridView3.Columns[0].HeaderText += " * E-KOLAY " + Session["header"].ToString();
                    }
                    GridView3.DataBind();
                }
                else
                {
                    GridView3.Visible = false;
                    GridView2.Visible = false;
                    GridView1.Visible = true;
                    GridView1.PageSize = 7;
                    GridView1.DataSource = Functions.rssOkuHurriyet(Request.QueryString["rss"].ToString());
                    if (!Page.IsPostBack)
                    {
                        GridView1.Columns[0].HeaderText += " * HÜRRİYET " + Session["header"].ToString();
                    }
                    GridView1.DataBind();
                    GridView1.DataBind();
                }
            }
            else
            {
                GridView3.Visible = false;
                GridView2.Visible = false;
                GridView1.Visible = true;
                GridView1.PageSize = 7;
                GridView1.DataSource = Functions.rssOkuHurriyet("http://rss.hurriyet.com.tr/rss.aspx?sectionId=1");
                GridView1.DataBind();
                GridView1.DataBind();
            }
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
                mail.Subject = "RSS Reader ascx Hatası";
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
    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
        GridView2.DataSource = Functions.rssOkuNTV(Request.QueryString["rss"].ToString());
        GridView2.DataBind();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataSource = Functions.rssOkuHurriyet(Request.QueryString["rss"].ToString());
        GridView1.DataBind();
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowIndex > -1)
        {
            if ((e.Row.FindControl("Label2") as Label).Text.Length > 80)
            {

                (e.Row.FindControl("Label2") as Label).Text = ((e.Row.FindControl("Label2") as Label).Text).Substring(0, 80) + "...";
            }
        }
    }
    protected void GridView3_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView3.PageIndex = e.NewPageIndex;
        GridView3.DataSource = Functions.rssOkuEKOLAY(Request.QueryString["rss"].ToString());
        GridView3.DataBind();
    }
    protected void GridView3_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowIndex > -1)
        {
            if ((e.Row.FindControl("Label4") as Label).Text.Length > 80)
            {

                (e.Row.FindControl("Label4") as Label).Text = ((e.Row.FindControl("Label4") as Label).Text).Substring(0, 80) + "...";
            }
        }
    }
}
