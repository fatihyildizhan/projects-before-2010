using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Caching;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

public partial class java : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            GridDoldurJava();
        }
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "detaygoster")
        {
            int id = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("https://www.fatihyildizhan.com/User/MakaleGoster.aspx?id=" + id);
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridDoldurJava();
    }
    public void GridDoldurJava()
    {
        if (Cache["Java"] == null)
        {
            SqlCacheDependency dep = new SqlCacheDependency("DoxaWeb", "Makale");
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ToString());
            SqlCommand com = new SqlCommand("MakaleGetirKategori", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@KonuId", 1);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Cache.Insert("Java", dt, dep);
        }

        GridView1.DataSource = Cache["Java"] as DataTable;
        GridView1.DataBind();
    }
}
