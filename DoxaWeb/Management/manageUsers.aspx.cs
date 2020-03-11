using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Management_manageUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataSource = Membership.GetAllUsers();
        GridView1.DataBind();
    }
   
    protected void lbKullaniciSil_Command(object sender, CommandEventArgs e)
    {
        Session["name"] = null;
        Session["name"] = e.CommandArgument.ToString();
        GridView1.Visible = false;
        lblAktifAd.Visible = false;
        lbKullaniciSilOnay.Visible = true;
        lbIptal.Visible = true;
        Image1.Visible = true;
    }
    protected void lbKullaniciYonet_Command(object sender, CommandEventArgs e)
    {
        Session["name"] = null;
        Session["name"] = e.CommandArgument.ToString();
        Response.Redirect("https://www.fatihyildizhan.com/Management/editUsers.aspx");
    }
    protected void lbKullaniciSilOnay_Click(object sender, EventArgs e)
    {
        Membership.DeleteUser(Session["name"].ToString());
        GridView1.Visible = true;
        lblAktifAd.Visible = true;
        lbKullaniciSilOnay.Visible = false;
        lbIptal.Visible = false;
        Image1.Visible = false;
    }
    protected void lbIptal_Click(object sender, EventArgs e)
    {
        GridView1.Visible = true;
        lblAktifAd.Visible = true;
        lbKullaniciSilOnay.Visible = false;
        lbIptal.Visible = false;
        Image1.Visible = false;
    }
    
}
