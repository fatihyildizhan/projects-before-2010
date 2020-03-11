using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Management_editUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            MembershipUser mu = Membership.GetUser(Session["name"].ToString());
            Session["user"] = mu;
            txtKullaniciAd.Text = (Session["user"] as MembershipUser).UserName;
            txtEposta.Text = (Session["user"] as MembershipUser).Email;
            txtAciklama.Text = (Session["user"] as MembershipUser).Comment;
            chkAktiflik.Checked = (Session["user"] as MembershipUser).IsApproved;
       
            ddlRoller.DataSource = Roles.GetAllRoles();
            ddlRoller.DataBind();
        }
    }
    protected void btnGuncelle_Click(object sender, EventArgs e)
    {
        if (ddlRoller.SelectedItem.ToString() != "Doxa")
        {
            Roles.AddUserToRole(txtKullaniciAd.Text, ddlRoller.SelectedItem.ToString());
        }
        else
        {
            ddlRoller.Items.Clear();
        }

        (Session["user"] as MembershipUser).Comment = txtAciklama.Text;
        (Session["user"] as MembershipUser).Email = txtEposta.Text;
        (Session["user"] as MembershipUser).IsApproved = chkAktiflik.Checked;

         Membership.UpdateUser((Session["user"] as MembershipUser));
    }
}
