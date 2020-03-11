using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class urunlerDetay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     GridView1.DataSource = Fonksiyon.UrunDetayGetirId(Convert.ToInt32(Request.QueryString["urunumId"]));
     GridView1.DataBind();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "oncekisayfa")
        {
            int Id = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("urunler.aspx?katId=" + Id);
        }
    }
  
}
