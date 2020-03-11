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

public partial class sayfalar_yoneticiWuc_emlakYonet_Emlak : System.Web.UI.UserControl
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
        dlEmlaklarYonetim.DataSource = eg.emlakOzetGetir(emlakTipId);
        dlEmlaklarYonetim.DataBind();
    }
    protected void dlEmlaklarYonetim_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "guncelle")
        {
            Response.Redirect("emlakGoster_Detay.aspx?idm=+" + e.CommandArgument);
        }
        else if (e.CommandName == "sil")
        {
            Panel1.Visible = true;
            Session["idm"] = e.CommandArgument;  
        }
    }
    protected void lbEvet_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        // r.ResimSilId(Convert.ToInt32(Session["idm"].ToString()));
        // ResimGetirTum();
    }
    protected void lbHayir_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
    }
}
