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

public partial class sayfalar_ziyaretciWuc_emlakGoster_Detay_Admin : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack && Request.QueryString["emlSayisi"] != null)
        {
            EmlakGetirTum(Convert.ToInt32(Request.QueryString["emlSayisi"]));
        }
    }
    public void EmlakGetirTum(int gelenEmlakId)
    {
        emlakGetir eg = new emlakGetir();
        dtlEmlaklar.DataSource = eg.emlakGetirIDTumDetay(gelenEmlakId);
        dtlEmlaklar.DataBind();
    }
}
