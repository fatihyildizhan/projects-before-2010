using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Management_manageRoles : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataSource = Roles.GetRolesForUser();
        GridView1.DataBind();
    }
    protected void btnRolEkle_Click(object sender, EventArgs e)
    {
        Roles.CreateRole(txtRolAd.Text);
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Yönet")
        {
            Response.Write("Yönet");
        }
    }
}
