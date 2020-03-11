using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class sozlesme : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnYonlendir_Click(object sender, EventArgs e)
    {
        Session["sozlesme"] = "Kabul";
        Response.Redirect("https://www.fatihyildizhan.com/createNewAccount.aspx");
    }
}
