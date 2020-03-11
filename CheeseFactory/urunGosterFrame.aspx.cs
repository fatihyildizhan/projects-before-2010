using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class urunGosterFrame : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataList1.DataSource = Fonksiyon.UrunGetirId(Convert.ToInt32(Request.QueryString["katId"]));
        DataList1.DataBind();
    }
}
