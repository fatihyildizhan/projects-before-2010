using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.Caching;

public partial class cSharp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            GridDoldurcSharp();
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "detaygoster")
        {
            int id = Convert.ToInt32(e.CommandArgument);
            //DataTable dt = Functions.MakaleGetir(id);
            //string yazi = dt.Rows[0].ItemArray[2].ToString();

            Response.Redirect("https://www.fatihyildizhan.com/User/MakaleGoster.aspx?id="+id);
        }
    }

    public void GridDoldurcSharp()
    {
        if (Cache["cSharp"] == null)
        {
            SqlCacheDependency dep = new SqlCacheDependency("DoxaWeb", "Makale");
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ToString());
            SqlCommand com = new SqlCommand("MakaleGetirKategori", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@KonuId", 2);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Cache.Insert("cSharp", dt, dep);
        }

        GridView1.DataSource = Cache["cSharp"] as DataTable;
        GridView1.DataBind();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridDoldurcSharp();
    }
}
