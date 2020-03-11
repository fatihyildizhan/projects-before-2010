using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Collections;

public partial class sayfalar_yoneticiWuc_emlakEkle_Ozellik : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            OzellikGetirTum();
            if (Session["eGuncelleId"] != null)
            {
                lblOzellikEkle.Text = "Özellikleri Güncelle";
                btnOzellikEkle.Text = "Özellik Güncelle Adım 4";
                btnOzellikEkle.Width = 165;
                int emlakId = Convert.ToInt32(Session["eGuncelleId"]);
                GuncelleOzellikGetirId(emlakId);
            }
        }
    }
    public void GuncelleOzellikGetirId(int emlakId)
    {
        emlakOzellikGetir eog = new emlakOzellikGetir();
        List<ozellik> ozellikler = eog.emlakOzellikGetirId(emlakId);
        foreach (ozellik ozl in ozellikler)
        {
            foreach (ListItem li in cblOzellikler.Items)
            {
                if (ozl.OzellikId.ToString() == li.Value.ToString())
                {
                    li.Selected = true;
                    break;
                }
            }
        }
    }
    public void OzellikGetirTum()
    {
        ozellikGetir og = new ozellikGetir();
        List<ozellik> ozellikler = og.ozellikGetirTum();

        ozellikTipGetir ozelTipGetir = new ozellikTipGetir();
        List<ozellikTip> ozelTipler = ozelTipGetir.ozellikTipGetirTum();
        for (int i = 0; i < ozelTipler.Count; i++)
        {
            ListItem lii = new ListItem();
            lii.Enabled = false;
            lii.Text = ozelTipler[i].OzellikTipAd;
            cblOzellikler.Items.Add(lii);

            foreach (ozellik item in ozellikler)
            {
                if (ozelTipler[i].OzellikTipId == item.OzellikTipId)
                {
                    ListItem li = new ListItem();
                    li.Text = item.OzellikAd;
                    li.Value = item.OzellikId.ToString();
                    cblOzellikler.Items.Add(li);
                }
            }
        }
    }
    protected void btnOzellikEkle_Click(object sender, EventArgs e)
    {
        ArrayList ozl = new ArrayList();
        emlakGetir eg = new emlakGetir();
        emlakOzellikEkle eoe = new emlakOzellikEkle();
        foreach (ListItem item in cblOzellikler.Items)
        {
            if (item.Selected)
            {
                ozl.Add(item.Value);
            }
        }
        int emlakinIdsi = 0;
        if (btnOzellikEkle.Text == "Özellik Güncelle Adım 4")
        {
            emlakOzellikSil eos = new emlakOzellikSil();
            int sonucSil = eos.emlakOzellikSilId(Convert.ToInt32(Session["eGuncelleId"]));
            emlakinIdsi = Convert.ToInt32(Session["eGuncelleId"]);
        }
        else
        {
            emlakinIdsi = Convert.ToInt32(Session["sonEmlakId"]);
        }

        int sonuc = eoe.emlakOzellikEkleString(ozl, emlakinIdsi);
        if (sonuc > 0)
        {
            lblSonuc.Text = "Seçilen " + ozl.Count + " özellikten Toplam: " + sonuc + " özellik eklendi.";
        }
        else
        {
            lblSonuc.Text = "Yeni özellik eklenemedi!";
        }
    }
    protected void lbSonrakiAdim_Click(object sender, EventArgs e)
    {
        Response.Redirect("emlakEkle_Fotograf.aspx");
    }
}
