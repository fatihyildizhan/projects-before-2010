using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;

        if (Request.QueryString["katId"] != null)
        {
            GridView1.DataSource = Fonksiyon.UrunGetirId(Convert.ToInt32(Request.QueryString["katId"]));
            GridView1.DataBind();
        }
        else
        {
            GridView1.DataSource = Fonksiyon.UrunGetir();
            GridView1.DataBind();
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "urundetaygor")
        {
            int urunumId = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("urunlerDetay.aspx?urunumId=" + urunumId);
        }
    }

}
