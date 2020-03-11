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

public partial class sayfalar_yonetici_Yonet_OzellikTip : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            OzellikTipGetir();
        }
    }

    public void OzellikTipGetir()
    {
        ddlListe.Items.Clear();
        ListItem li2 = new ListItem();
        li2.Text = "Özellik Tip Seçiniz...";
        ddlListe.Items.Add(li2);

        foreach (ozellikTip item in otg.ozellikTipGetirTum())
        {
            ListItem li = new ListItem();
            li.Text = item.OzellikTipAd;
            li.Value = item.OzellikTipId.ToString();
            ddlListe.Items.Add(li);
        }
    }
    ozellikTipGetir otg = new ozellikTipGetir();
    public int AdetGetir(int id)
    {
        return otg.ozellikTipAdet(id);
    }
    protected void lbGuncelle_Click(object sender, EventArgs e)
    {
        if (ddlListe.SelectedIndex != 0)
        {
            ListItem li = (ListItem)ddlListe.SelectedItem;
            ozellikTipGuncelle otgg = new ozellikTipGuncelle();
            int sonuc = otgg.ozellikTipGuncelleId(Convert.ToInt32(li.Value), txtAd.Text);
            if (sonuc > 0)
            {
                lblSonuc.Text = "Güncellendi!";
                lblSayi.Text = "";
                txtAd.Text = "";
                OzellikTipGetir();
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
            ozellikTipSil ots = new ozellikTipSil();
            int sonuc = ots.ozellikTipSilId(Convert.ToInt32(li.Value));
            if (sonuc > 0)
            {
                lblSonuc.Text = "Silindi";
                lblSayi.Text = "";
                txtAd.Text = "";
                OzellikTipGetir();
            }
            else
            {
                lblSonuc.Text = "Hata Oluştu!";
            }
        }
        else
        {
            lblSonuc.Text = "Bu özellik tipi şuanda kullanılıyor. Silemezsiniz.";
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
            ozellikTipEkle ote =new ozellikTipEkle();
            int sonuc = ote.ozellikTipEkleString(txtEkle.Text);
            if (sonuc > 0)
            {
                lblSonuc.Text = "Eklendi";
                lblSayi.Text = "";
                txtAd.Text = "";
                txtEkle.Text = "";
                OzellikTipGetir();
            }
            else
            {
                lblSonuc.Text = "Hata Oluştu!";
            }
        }
        else
        {
            lblSonuc.Text = "Lütfen Özellik Tipi için isim giriniz.";
        }
    }
}
