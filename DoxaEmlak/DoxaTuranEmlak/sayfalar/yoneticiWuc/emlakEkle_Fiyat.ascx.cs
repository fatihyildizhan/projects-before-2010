using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using ExceptionLayer;

public partial class sayfalar_yoneticiWuc_emlakEkle_Fiyat : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["eGuncelleId"] != null)
            {
                lblFiyatEkle.Text = "Fiyat Güncelle";
                btnEkleFiyat.Text = "Fiyat Güncelle Adım 2";
                btnEkleFiyat.Width = 150;
                int emlakId = Convert.ToInt32(Session["eGuncelleId"].ToString());
                GuncelleFiyatGetirId(emlakId);
            }
        }
    }
    public void GuncelleFiyatGetirId(int emlakId)
    {
        fiyatGetir fg = new fiyatGetir();
        fiyat f = fg.fiyatGetirEmlakId(emlakId);
        txtDolar.Text = f.Dolar.ToString();
        txtEuro.Text = f.Euro.ToString();
        txtPound.Text = f.Pound.ToString();
        txtTL.Text = f.Tl.ToString();
    }
    protected void btnDetayEkle_Click(object sender, EventArgs e)
    {
        try
        {
            if (btnEkleFiyat.Text == "Fiyat Ekle Adım 2")
            {
                fiyatEkle fe = new fiyatEkle();
                int sonuc = fe.fiyatEkleString(Convert.ToInt32(Session["sonEmlakId"]), Convert.ToInt32(txtTL.Text), Convert.ToInt32(txtEuro.Text), Convert.ToInt32(txtDolar.Text), Convert.ToInt32(txtPound.Text));
                if (sonuc > 0)
                {
                    lblFiyatSonuc.Text = "Fiyat eklendi.";
                    btnEkleFiyat.Enabled = false;
                }
                else
                {
                    lblFiyatSonuc.Text = "İşlem başarısız.";
                }
            }
            else
            {
                fiyatGuncelle fgg = new fiyatGuncelle();
                int sonuc = fgg.fiyatGuncelleEmlakId(Convert.ToInt32(Session["eGuncelleId"]), Convert.ToInt32(txtTL.Text), Convert.ToInt32(txtEuro.Text), Convert.ToInt32(txtDolar.Text), Convert.ToInt32(txtPound.Text));
                if (sonuc > 0)
                {
                    lblFiyatSonuc.Text = "Fiyat Güncellendi.";
                }
                else
                {
                    lblFiyatSonuc.Text = "Güncelleme başarısız!";
                }
            }
        }
        catch (Exception ex)
        {
            hDepo.HataYakalaTUM(ex);
        }
    }
    HataDEPOSU hDepo = new HataDEPOSU();
    protected void lbSonrakiAdim_Click(object sender, EventArgs e)
    {
        Response.Redirect("emlakEkle_Adres.aspx");
    }
}
