using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Management_security : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblTkS.Text = (Membership.GetAllUsers().Count).ToString();
        lblTrS.Text = (Roles.GetAllRoles().Count()).ToString();
    }
    protected void btnRolAcKapat_Click(object sender, EventArgs e)
    {
        
    }
    protected void btnKullaniciOlustur_Click(object sender, EventArgs e)
    {

    }
}
