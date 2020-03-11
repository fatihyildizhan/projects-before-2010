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

public partial class sayfalar_yonetici_Yonet_Kategori : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            KategoriGetir();
        }
    }

    public void KategoriGetir()
    {
        ddlListe.Items.Clear();
        ListItem li2 = new ListItem();
        li2.Text = "Kategori Seçiniz...";
        ddlListe.Items.Add(li2);

        foreach (kategori item in kg.kategoriGetirTum())
        {
            ListItem li = new ListItem();
            li.Text = item.KategoriAd;
            li.Value = item.KategoriId.ToString();
            ddlListe.Items.Add(li);
        }
    }
    kategoriGetir kg = new kategoriGetir();
    public int AdetGetir(int id)
    {
        return kg.KategoriAdet(id);
    }
    protected void lbGuncelle_Click(object sender, EventArgs e)
    {
        if (ddlListe.SelectedIndex != 0)
        {
            ListItem li = (ListItem)ddlListe.SelectedItem;
            kategoriGuncelle kg = new kategoriGuncelle();
            int sonuc = kg.kategoriGuncelleId(Convert.ToInt32(li.Value), txtAd.Text);
            if (sonuc > 0)
            {
                lblSonuc.Text = "Güncellendi!";
                lblSayi.Text = "";
                txtAd.Text = "";
                KategoriGetir();
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
            kategoriSil ks = new kategoriSil();
            int sonuc = ks.kategoriSilId(Convert.ToInt32(li.Value));
            if (sonuc > 0)
            {
                lblSonuc.Text = "Silindi";
                lblSayi.Text = "";
                txtAd.Text = "";
                KategoriGetir();
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
            kategoriEkle ke = new kategoriEkle();
            int sonuc = ke.kategoriEkleString(txtEkle.Text);
            if (sonuc > 0)
            {
                lblSonuc.Text = "Eklendi";
                lblSayi.Text = "";
                txtAd.Text = "";
                txtEkle.Text = "";
                KategoriGetir();
            }
            else
            {
                lblSonuc.Text = "Hata Oluştu!";
            }
        }
        else
        {
            lblSonuc.Text = "Lütfen Kategori için isim giriniz.";
        }
    }
}
