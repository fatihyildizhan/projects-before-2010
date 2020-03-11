using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using BusinessLayer;

public partial class sayfalar_ziyaretciWuc_slideDeckEmlak : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            emlakOzetleriGetir(11);
        }
    }
    emlakGetir eg = new emlakGetir();
    public void emlakOzetleriGetir(int emlakTipId)
    {
        DataList1.DataSource = eg.emlakOzetGetir(emlakTipId);
        DataList1.DataBind();
    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "detay")
        {
            Response.Redirect("emlakGoster_Detay.aspx?idm=+" + e.CommandArgument);
        }
    }
}
