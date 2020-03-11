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

public partial class sayfalar_yoneticiWuc_emlakGuncelle_Resim : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Request.QueryString["rid"] != null)
            {
                ResimGetirId(Convert.ToInt32(Request.QueryString["rid"]));
            }
        }
    }
    protected void btnGuncelle_Click(object sender, EventArgs e)
    {
        bool guncellendiMi = r.ResimBilgiGuncelleId(Convert.ToInt32(Request.QueryString["rid"]), txtBaslik.Text);

        if (guncellendiMi)
        {
            lblUyari.Text = "Resim Güncellendi.";
            ResimGetirId(Convert.ToInt32(Request.QueryString["rid"]));
        }
        else
        {
            lblUyari.Text = "Resim Güncellenemedi!";
        }
    }
    Resim r = new Resim();
    public void ResimGetirId(int gelenId)
    {
        Resim rr = r.ResimGetirId(gelenId);
        txtBaslik.Text = rr.Baslik;
    }
    protected void lbGeriDon_Click(object sender, EventArgs e)
    {
        Response.Redirect("emlakEkle_Fotograf.aspx");
    }
}
