using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_MakaleGoster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
        {
            //string id = Context.Request.RawUrl.Split('/')[4];
            Session["makaleId"] = Request.QueryString["id"];
            //Session["makaleId"] = id;
            Functions.MakaleOkunmaSayisiArtir(Convert.ToInt32(Session["makaleId"]));
            GridView1.DataSource = Functions.MakaleGetir(Convert.ToInt32(Session["makaleId"]));
            GridView1.DataBind();
        }
        else
        {
            Response.Redirect("index.aspx");
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "uyeMesajGonder")
        {
            Response.Redirect("https://www.fatihyildizhan.com/User/mesajlar.aspx?kime=" + e.CommandArgument.ToString());
        }
        else if (e.CommandName == "UygulamaIndir")
        {
            Functions.MakaleIndirmeSayisiArtir(Convert.ToInt32(Session["makaleId"]));
            Response.Redirect(e.CommandArgument.ToString());
        }
    }
}
