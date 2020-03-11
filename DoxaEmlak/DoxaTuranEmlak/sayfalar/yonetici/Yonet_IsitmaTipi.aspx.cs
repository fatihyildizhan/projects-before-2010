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

public partial class sayfalar_yonetici_Yonet_IsitmaTipi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            IsitmaTipGetir();
        }
    }

    public void IsitmaTipGetir()
    {
        ddlListe.Items.Clear();
        ListItem li2 = new ListItem();
        li2.Text = "Isıtma Tipi Seçiniz...";
        ddlListe.Items.Add(li2);

        isitmaTipGetir ist = new isitmaTipGetir();
        
        foreach (isitmaTip item in ist.isitmaTipGetirTum())
        {
            ListItem li = new ListItem();
            li.Text = item.IsitmaTipAd;
            li.Value = item.IsitmaTipId.ToString();
            ddlListe.Items.Add(li);
        }
    }
    public int AdetGetir(int id)
    {
        isitmaTipGetir ist = new isitmaTipGetir();
        return ist.isitmaTipAdet(id);
    }
    protected void lbGuncelle_Click(object sender, EventArgs e)
    {
        if (ddlListe.SelectedIndex != 0)
        {
            ListItem li = (ListItem)ddlListe.SelectedItem;
            isitmaTipGuncelle itg = new isitmaTipGuncelle();
            int sonuc = itg.isitmaTipGuncelleId(Convert.ToInt32(li.Value), txtAd.Text);
            if (sonuc > 0)
            {
                lblSonuc.Text = "Güncellendi!";
                lblSayi.Text = "";
                txtAd.Text = "";
                IsitmaTipGetir();
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
            isitmaTipSil its = new isitmaTipSil();
            int sonuc = its.isitmaTipSilId(Convert.ToInt32(li.Value));
            if (sonuc > 0)
            {
                lblSonuc.Text = "Silindi";
                lblSayi.Text = "";
                txtAd.Text = "";
                IsitmaTipGetir();
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
            isitmaTipEkle ite = new isitmaTipEkle();
            int sonuc = ite.isitmaTipEkleString(txtEkle.Text);
            if (sonuc > 0)
            {
                lblSonuc.Text = "Eklendi";
                lblSayi.Text = "";
                txtAd.Text = "";
                txtEkle.Text = "";
                IsitmaTipGetir();
            }
            else
            {
                lblSonuc.Text = "Hata Oluştu!";
            }
        }
        else
        {
            lblSonuc.Text = "Lütfen Isıtma Tipi için isim giriniz.";
        }
    }
}
