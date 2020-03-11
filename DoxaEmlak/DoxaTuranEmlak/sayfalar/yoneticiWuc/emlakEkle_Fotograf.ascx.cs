using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class sayfalar_yoneticiWuc_emlakEkle_Fotograf : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ResimGetirTum();
            if (Session["eGuncelleId"] != null)
            {
                LbEmlakEkleBitir.Text = "Emlak Güncellemeyi Bitir";
            }
        }
    }
    resimBoyutlandir rb = new resimBoyutlandir();
    Resim r = new Resim();
    protected void btnResimEkle_Click(object sender, EventArgs e)
    {
        bool eklendiMi = false;

        if (FileUpload1.HasFile)
        {
            rb = new resimBoyutlandir(FileUpload1);
            string[] gelenResimler = rb.resminBoyutunuKucult();
            eklendiMi = r.ResimEkle(txtBaslik.Text, Convert.ToInt32(Session["sonEmlakId"].ToString()), gelenResimler[1], gelenResimler[0]);

            if (eklendiMi)
            {
                lblUyari.Text = "Resim Eklendi.";
                ResimGetirTum();
            }
            else
            {
                lblUyari.Text = "Resim Eklenemedi!";
            }

        }
        else
        {
            lblUyari.Text = "Lütfen Resim Seçiniz!";
        }
    }
    public void ResimGetirTum()
    {
        DataList1.DataSource = r.ResimGetirTum(Convert.ToInt32(Session["sonEmlakId"].ToString()));
        DataList1.DataBind();
    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "Guncelle")
        {
            Server.Transfer("emlakGuncelle_Resim.aspx?rid=" + e.CommandArgument);
        }
        else if (e.CommandName == "Sil")
        {
            Panel1.Visible = true;
            Session["idm"] = e.CommandArgument;   
        }
    }
    protected void lbEvet_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        r.ResimSilId(Convert.ToInt32(Session["idm"].ToString()));
        ResimGetirTum();
    }
    protected void lbHayir_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
    }
    protected void LbEmlakEkleBitir_Click(object sender, EventArgs e)
    {
        Session["eGuncelleId"] = null;
        Response.Redirect("emlakYonet.aspx");
    }
}
