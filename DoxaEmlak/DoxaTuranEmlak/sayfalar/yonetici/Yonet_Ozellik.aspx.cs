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

public partial class sayfalar_yonetici_Yonet_Ozellik : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            OzellikGetir();
            OzellikTipGetir();
        }
    }
    public void OzellikGetir()
    {
        ddlListe.Items.Clear();
        ListItem li2 = new ListItem();
        li2.Text = "Özellik Seçiniz...";
        ddlListe.Items.Add(li2);

        foreach (ozellik item in og.ozellikGetirTum())
        {
            ListItem li = new ListItem();
            li.Text = item.OzellikAd;
            li.Value = item.OzellikId + ";" + item.OzellikTipId;
            ddlListe.Items.Add(li);
        }
    }
    ozellikTipGetir otg = new ozellikTipGetir();
    public void OzellikTipGetir()
    {
        ddlOzellikTip.Items.Clear();
        ListItem li2 = new ListItem();
        li2.Text = "Özellik Tip Seçiniz...";
        ddlOzellikTip.Items.Add(li2);
        foreach (ozellikTip item in otg.ozellikTipGetirTum())
        {
            ListItem li = new ListItem();
            li.Text = item.OzellikTipAd;
            li.Value = item.OzellikTipId.ToString();
            ddlOzellikTip.Items.Add(li);
        }
    }
    ozellikGetir og = new ozellikGetir();
    public int AdetGetir(int id)
    {
        return og.ozellikAdet(id);
    }
    protected void lbGuncelle_Click(object sender, EventArgs e)
    {
        if (ddlListe.SelectedIndex != 0 && ddlOzellikTip.SelectedIndex != 0)
        {
            ListItem li = (ListItem)ddlListe.SelectedItem;
            ozellikGuncelle ogg = new ozellikGuncelle();
            string[] IdLer = li.Value.Split(';');
            int sonuc = ogg.ozellikGuncelleId(Convert.ToInt32(IdLer[0]), Convert.ToInt32(ddlOzellikTip.SelectedValue), txtAd.Text);
            if (sonuc > 0)
            {
                lblSonuc.Text = "Güncellendi!";
                lblSayi.Text = "";
                txtAd.Text = "";
                OzellikGetir();
                ddlOzellikTip.SelectedIndex = 0;
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
            ozellikSil os = new ozellikSil();
            string[] IdLer = li.Value.Split(';');
            int sonuc = os.ozellikSilId(Convert.ToInt32(IdLer[0]));
            if (sonuc > 0)
            {
                lblSonuc.Text = "Silindi";
                lblSayi.Text = "";
                txtAd.Text = "";
                OzellikGetir();
                ddlOzellikTip.SelectedIndex = 0;
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
            string[] IdLer = li.Value.Split(';');
            lblSayi.Text = AdetGetir(Convert.ToInt32(IdLer[0])).ToString();
            int indeks = 0;
            foreach (ListItem ot in ddlOzellikTip.Items)
            {
                if (ot.Value == IdLer[1] && ot.Value != null)
                {
                    ddlOzellikTip.SelectedIndex = indeks;
                    break;
                }
                indeks++;
            }
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
            ozellikEkle oe = new ozellikEkle();
            ListItem li = (ListItem)ddlOzellikTip.SelectedItem;
            int sonuc = oe.ozellikEkleString(Convert.ToInt32(li.Value), txtEkle.Text);
            if (sonuc > 0)
            {
                lblSonuc.Text = "Eklendi";
                lblSayi.Text = "";
                txtAd.Text = "";
                txtEkle.Text = "";
                OzellikGetir();
                ddlOzellikTip.SelectedIndex = 0;
            }
            else
            {
                lblSonuc.Text = "Hata Oluştu!";
            }
        }
        else
        {
            lblSonuc.Text = "Lütfen Özellik için isim giriniz.";
        }
    }
}
