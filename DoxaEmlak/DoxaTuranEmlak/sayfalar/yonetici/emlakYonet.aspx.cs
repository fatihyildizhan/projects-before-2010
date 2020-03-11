using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class sayfalar_yonetici_emlakYonet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            EmlakGetirTum();
        }
    }
    public void EmlakGetirTum()
    {
        emlakGetir eg = new emlakGetir();
        dtlEmlaklar.DataSource = eg.emlakGetirTumDetay();
        dtlEmlaklar.DataBind();
    }
    protected void dtlEmlaklar_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "sil")
        {
            Session["emlakkSill"] = e.CommandArgument;
            pnlEmlakSil.Visible = true;
        }
        else
        {
            Session["eGuncelleId"] = e.CommandArgument;
            Response.Redirect("emlakEkle_Basla.aspx");
        }
    }
    protected void lbEmlakSil_Click(object sender, EventArgs e)
    {
        emlakSil ess = new emlakSil();
        int ssonucc = ess.emlakSilMetod(Convert.ToInt32(Session["emlakkSill"].ToString()));
        if (ssonucc > 0)
        {
            EmlakGetirTum();
            lblSonuc.Text = "Emlak Başarıyla Silindi.";
        }
        else
        {
            lblSonuc.Text = "Emlak Silinemedi!";
        }
    }
    protected void lbIptal_Click(object sender, EventArgs e)
    {
        pnlEmlakSil.Visible = false;
    }
}
