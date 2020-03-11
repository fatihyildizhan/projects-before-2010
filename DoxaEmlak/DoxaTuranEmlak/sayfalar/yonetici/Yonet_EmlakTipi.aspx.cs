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

public partial class sayfalar_yonetici_Yonet_EmlakTipi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            EmlakTipGetir();
        }
    }

    public void EmlakTipGetir()
    {
        ddlListe.Items.Clear();
        ListItem li2 = new ListItem();
        li2.Text = "Emlak Tip Seçiniz...";
        ddlListe.Items.Add(li2);
        
        foreach (emlakTip item in etg.emlakTipGetirTum())
        {
            ListItem li = new ListItem();
            li.Text = item.EmlakTipAd;
            li.Value = item.EmlakTipId.ToString();
            ddlListe.Items.Add(li);
        }
    }
    emlakTipGetir etg = new emlakTipGetir();
    public int AdetGetir(int id)
    {
        return etg.emlakTipAdet(id);
    }
    protected void lbGuncelle_Click(object sender, EventArgs e)
    {
        if (ddlListe.SelectedIndex != 0)
        {
            ListItem li = (ListItem)ddlListe.SelectedItem;
            emlakTipGuncelle etgg = new emlakTipGuncelle();
            int sonuc = etgg.emlakTipGuncelleId(Convert.ToInt32(li.Value), txtAd.Text);
            if (sonuc > 0)
            {
                lblSonuc.Text = "Güncellendi!";
                lblSayi.Text = "";
                txtAd.Text = "";
                EmlakTipGetir();
            }
            else
            {
                lblSonuc.Text = "Hata Oluştu!";
            }
        }
        else
        {
            lblSayi.Text = "";
            txtAd.Text = "";
        }
    }
    protected void lbSil_Click(object sender, EventArgs e)
    {
        if (lblSayi.Text == "0")
        {
            ListItem li = (ListItem)ddlListe.SelectedItem;
            emlakTipSil ets = new emlakTipSil();
            int sonuc = ets.emlakTipSilId(Convert.ToInt32(li.Value));
            if (sonuc > 0)
            {
                lblSonuc.Text = "Silindi";
                lblSayi.Text = "";
                txtAd.Text = "";
                EmlakTipGetir();
            }
            else
            {
                lblSonuc.Text = "Hata Oluştu!";
            }
        }
        else
        {
            lblSonuc.Text = "Bu özellik şuanda kullanılıyor. Silemezsiniz.";
        }
    }
    protected void ddlListe_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlListe.SelectedIndex != 0)
        {
            ListItem li = (ListItem)ddlListe.SelectedItem;
            txtAd.Text = li.Text;
            lblSayi.Text = AdetGetir(Convert.ToInt32(li.Value)).ToString();
        }
        else
        {
            lblSayi.Text = "";
            txtAd.Text = "";
        }
    }
    protected void lbEkle_Click(object sender, EventArgs e)
    {
        if (txtEkle.Text != "")
        {
            emlakTipEkle ete = new emlakTipEkle();
            int sonuc = ete.emlakTipEkleString(txtEkle.Text);
            if (sonuc > 0)
            {
                lblSonuc.Text = "Eklendi";
                lblSayi.Text = "";
                txtAd.Text = "";
                txtEkle.Text = "";
                EmlakTipGetir();
            }
            else
            {
                lblSonuc.Text = "Hata Oluştu!";
            }
        }
        else
        {
            lblSonuc.Text = "Lütfen Emlak Tipi için isim giriniz.";
        }
    }
}
