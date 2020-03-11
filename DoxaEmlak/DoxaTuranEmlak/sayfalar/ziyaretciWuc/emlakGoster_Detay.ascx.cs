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

public partial class sayfalar_ziyaretciWuc_emlakGoster_Detay : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            emlakDetayGoster(Convert.ToInt32(Request.QueryString["idm"]));
        }
    }

    public void emlakDetayGoster(int emlakId)
    {
        emlakGetir eg = new emlakGetir();
        gridEmlakDetay.DataSource = eg.emlakGetirIdDetay(emlakId);
        gridEmlakDetay.DataBind();
    }

}
