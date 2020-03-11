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
using ExceptionLayer;

public partial class sayfalar_yonetici_Yonet_Adres : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            SehirGetir();
            
            // İlçe
            IlceGetir();
            IlceSehirGetir();
            
            // Semt
            SemtGetir();
            SemtIlceGetir();

            // Cadde
            CaddeGetir();
            CaddeSemtGetir();
        }
    }

    HataDEPOSU hDepo = new HataDEPOSU();

    // Şehir

    public void SehirGetir()
    {
        ddlListe.Items.Clear();
        ListItem li2 = new ListItem();
        li2.Text = "Şehir Seçiniz...";
        ddlListe.Items.Add(li2);

        foreach (sehir item in sg.sehirGetirTum())
        {
            ListItem li = new ListItem();
            li.Text = item.SehirAd;
            li.Value = item.SehirId.ToString();
            ddlListe.Items.Add(li);
        }
    }
    sehirGetir sg = new sehirGetir();
    protected void lbGuncelle_Click(object sender, EventArgs e)
    {
        if (ddlListe.SelectedIndex != 0)
        {
            ListItem li = (ListItem)ddlListe.SelectedItem;
            sehirGuncelle sg = new sehirGuncelle();
            int sonuc = sg.sehirGuncelleId(Convert.ToInt32(li.Value), txtAd.Text, 0);
            if (sonuc > 0)
            {
                lblSonuc.Text = "Güncellendi!";
                lblSayi.Text = "";
                txtAd.Text = "";
                SehirGetir();
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
            sehirSil ss = new sehirSil();
            int sonuc = ss.sehirSilId(Convert.ToInt32(li.Value));
            if (sonuc > 0)
            {
                lblSonuc.Text = "Silindi";
                lblSayi.Text = "";
                txtAd.Text = "";
                SehirGetir();
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
            lblSayi.Text = sg.sehirAdet(Convert.ToInt32(li.Value)).ToString();
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
            sehirEkle se = new sehirEkle();
            int sonuc = se.sehirEkleString(txtEkle.Text, 0);
            if (sonuc > 0)
            {
                lblSonuc.Text = "Eklendi";
                lblSayi.Text = "";
                txtAd.Text = "";
                txtEkle.Text = "";
                SehirGetir();
            }
            else
            {
                lblSonuc.Text = "Hata Oluştu!";
            }
        }
        else
        {
            lblSonuc.Text = "Lütfen Şehir için isim giriniz.";
        }
    }

    // İlçe

    public void IlceGetir()
    {
        ddlListeIlce.Items.Clear();
        ListItem li2 = new ListItem();
        li2.Text = "İlçe Seçiniz...";
        ddlListeIlce.Items.Add(li2);

        foreach (ilce item in ig.ilceGetirTum())
        {
            ListItem li = new ListItem();
            li.Text = item.IlceAd;
            li.Value = item.IlceId + ";" + item.SehirId;
            ddlListeIlce.Items.Add(li);
        }
    }
    ilceGetir ig = new ilceGetir();
    public void IlceSehirGetir()
    {
        ddlIlceSehir.Items.Clear();
        ListItem li2 = new ListItem();
        li2.Text = "Şehir Seçiniz...";
        ddlIlceSehir.Items.Add(li2);
        foreach (sehir item in sg.sehirGetirTum())
        {
            ListItem li = new ListItem();
            li.Text = item.SehirAd;
            li.Value = item.SehirId.ToString();
            ddlIlceSehir.Items.Add(li);
        }
    }
    protected void lbGuncelleIlce_Click(object sender, EventArgs e)
    {
        if (ddlListeIlce.SelectedIndex > 0 && ddlIlceSehir.SelectedIndex > 0)
        {
            ListItem li = (ListItem)ddlListeIlce.SelectedItem;
            ilceGuncelle igg = new ilceGuncelle();
            string[] IdLer = li.Value.Split(';');
            int sonuc = igg.ilceGuncelleId(Convert.ToInt32(IdLer[0]), txtAdIlce.Text, Convert.ToInt32(ddlIlceSehir.SelectedValue));
            if (sonuc > 0)
            {
                lblSonucIlce.Text = "Güncellendi!";
                lblSayiIlce.Text = "";
                txtAdIlce.Text = "";
                IlceGetir();
                ddlIlceSehir.SelectedIndex = 0;
            }
            else
            {
                lblSonucIlce.Text = "Hata Oluştu!";
            }
        }
        else
        {
            lblSayiIlce.Text = "";
            txtAdIlce.Text = "";
        }
    }
    protected void lbSilIlce_Click(object sender, EventArgs e)
    {
        try
        {
            if (lblSayiIlce.Text == "0")
            {
                ListItem li = (ListItem)ddlListeIlce.SelectedItem;
                ilceSil iss = new ilceSil();
                string[] IdLer = li.Value.Split(';');
                int sonuc = iss.ilceSilId(Convert.ToInt32(IdLer[0]));
                if (sonuc > 0)
                {
                    lblSonucIlce.Text = "Silindi";
                    lblSayiIlce.Text = "";
                    txtAdIlce.Text = "";
                    IlceGetir();
                    ddlIlceSehir.SelectedIndex = 0;
                }
                else
                {
                    lblSonucIlce.Text = "Hata Oluştu!";
                }
            }
            else
            {
                lblSonucIlce.Text = "Bu özellik şuanda kullanılıyor. Silemezsiniz.";
            }
        }
        catch (Exception ex)
        {
            hDepo.HataYakalaTUM(ex);
        }
    }
    protected void ddlListeIlce_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlListeIlce.SelectedIndex > 0)
        {
            ListItem li = (ListItem)ddlListeIlce.SelectedItem;
            txtAdIlce.Text = li.Text;
            string[] IdLer = li.Value.Split(';');
            lblSayiIlce.Text = ig.ilceAdet(Convert.ToInt32(IdLer[0])).ToString();
            int indeks = 0;
            foreach (ListItem ot in ddlIlceSehir.Items)
            {
                if (ot.Value == IdLer[1] && ot.Value != null)
                {
                    ddlIlceSehir.SelectedIndex = indeks;
                    break;
                }
                indeks++;
            }
        }
        else
        {
            lblSayiIlce.Text = "";
            txtAdIlce.Text = "";
        }
    }
    protected void lbEkleIlce_Click(object sender, EventArgs e)
    {
        if (txtEkleIlce.Text != "" && ddlIlceSehir.SelectedIndex > 0)
        {
            ilceEkle iee = new ilceEkle();
            ListItem li = (ListItem)ddlIlceSehir.SelectedItem;
            int sonuc = iee.ilceEkleString(txtEkleIlce.Text, Convert.ToInt32(li.Value));
            if (sonuc > 0)
            {
                lblSonucIlce.Text = "Eklendi";
                lblSayiIlce.Text = "";
                txtAdIlce.Text = "";
                txtEkleIlce.Text = "";
                IlceGetir();
                ddlIlceSehir.SelectedIndex = 0;
            }
            else
            {
                lblSonucIlce.Text = "Hata Oluştu!";
            }
        }
        else
        {
            lblSonucIlce.Text = "Lütfen İlçe için isim giriniz.";
        }
    }

    // Semt
    public void SemtGetir()
    {
        ddlListeSemt.Items.Clear();
        ListItem li2 = new ListItem();
        li2.Text = "Semt Seçiniz...";
        ddlListeSemt.Items.Add(li2);

        foreach (semt item in sgg.semtGetirTum())
        {
            ListItem li = new ListItem();
            li.Text = item.SemtAd;
            li.Value = item.SemtId + ";" + item.IlceId;
            ddlListeSemt.Items.Add(li);
        }
    }
    semtGetir sgg = new semtGetir();
    public void SemtIlceGetir()
    {
        ddlSemtIlce.Items.Clear();
        ListItem li2 = new ListItem();
        li2.Text = "İlçe Seçiniz...";
        ddlSemtIlce.Items.Add(li2);
        foreach (ilce item in ig.ilceGetirTum())
        {
            ListItem li = new ListItem();
            li.Text = item.IlceAd;
            li.Value = item.IlceId.ToString();
            ddlSemtIlce.Items.Add(li);
        }
    }
    protected void lbGuncelleSemt_Click(object sender, EventArgs e)
    {
        if (ddlListeSemt.SelectedIndex > 0 && ddlSemtIlce.SelectedIndex > 0)
        {
            ListItem li = (ListItem)ddlListeSemt.SelectedItem;
            semtGuncelle sgg = new semtGuncelle();
            string[] IdLer = li.Value.Split(';');
            int sonuc = sgg.semtGuncelleId(Convert.ToInt32(IdLer[0]), txtAdSemt.Text, Convert.ToInt32(ddlSemtIlce.SelectedValue));
            if (sonuc > 0)
            {
                lblSonucSemt.Text = "Güncellendi!";
                lblSayiSemt.Text = "";
                txtAdSemt.Text = "";
                SemtGetir();
                ddlSemtIlce.SelectedIndex = 0;
            }
            else
            {
                lblSonucSemt.Text = "Hata Oluştu!";
            }
        }
        else
        {
            lblSayiSemt.Text = "";
            txtAdSemt.Text = "";
        }
    }
    protected void lbEkleSemt_Click(object sender, EventArgs e)
    {
        if (txtEkleSemt.Text != "" && ddlSemtIlce.SelectedIndex > 0)
        {
            semtEkle see = new semtEkle();
            ListItem li = (ListItem)ddlSemtIlce.SelectedItem;
            int sonuc = see.semtEkleString(txtEkleSemt.Text, Convert.ToInt32(li.Value));
            if (sonuc > 0)
            {
                lblSonucSemt.Text = "Eklendi";
                lblSayiSemt.Text = "";
                txtAdSemt.Text = "";
                txtEkleSemt.Text = "";
                SemtGetir();
                ddlSemtIlce.SelectedIndex = 0;
            }
            else
            {
                lblSonucSemt.Text = "Hata Oluştu!";
            }
        }
        else
        {
            lblSonucSemt.Text = "Lütfen Semt için isim giriniz.";
        }
    }
    protected void lbSilSemt_Click(object sender, EventArgs e)
    {
        try
        {
            if (lblSayiSemt.Text == "0")
            {
                ListItem li = (ListItem)ddlListeSemt.SelectedItem;
                semtSil sss = new semtSil();
                string[] IdLer = li.Value.Split(';');
                int sonuc = sss.semtSilId(Convert.ToInt32(IdLer[0]));
                if (sonuc > 0)
                {
                    lblSonucSemt.Text = "Silindi";
                    lblSayiSemt.Text = "";
                    txtAdSemt.Text = "";
                    SemtGetir();
                    ddlSemtIlce.SelectedIndex = 0;
                }
                else
                {
                    lblSonucSemt.Text = "Hata Oluştu!";
                }
            }
            else
            {
                lblSonucSemt.Text = "Bu özellik şuanda kullanılıyor. Silemezsiniz.";
            }
        }
        catch (Exception ex)
        {
            hDepo.HataYakalaTUM(ex);
        }
    }
    protected void ddlListeSemt_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlListeSemt.SelectedIndex > 0)
        {
            ListItem li = (ListItem)ddlListeSemt.SelectedItem;
            txtAdSemt.Text = li.Text;
            string[] IdLer = li.Value.Split(';');
            lblSayiSemt.Text = sgg.semtAdet(Convert.ToInt32(IdLer[0])).ToString();
            int indeks = 0;
            foreach (ListItem ot in ddlSemtIlce.Items)
            {
                if (ot.Value == IdLer[1] && ot.Value != null)
                {
                    ddlSemtIlce.SelectedIndex = indeks;
                    break;
                }
                indeks++;
            }
        }
        else
        {
            lblSayiSemt.Text = "";
            txtAdSemt.Text = "";
        }
    }

    // Cadde
    public void CaddeGetir()
    {
        ddlListeCadde.Items.Clear();
        ListItem li2 = new ListItem();
        li2.Text = "Cadde Seçiniz...";
        ddlListeCadde.Items.Add(li2);

        foreach (cadde item in cgg.caddeGetirTum())
        {
            ListItem li = new ListItem();
            li.Text = item.CaddeAd;
            li.Value = item.CaddeId + ";" + item.SemtId;
            ddlListeCadde.Items.Add(li);
        }
    }
    caddeGetir cgg = new caddeGetir();
    public void CaddeSemtGetir()
    {
        ddlCaddeSemt.Items.Clear();
        ListItem li2 = new ListItem();
        li2.Text = "Semt Seçiniz...";
        ddlCaddeSemt.Items.Add(li2);
        foreach (semt item in sgg.semtGetirTum())
        {
            ListItem li = new ListItem();
            li.Text = item.SemtAd;
            li.Value = item.SemtId.ToString();
            ddlCaddeSemt.Items.Add(li);
        }
    }
    protected void lbSilCadde_Click(object sender, EventArgs e)
    {
        try
        {
            if (lblSayiCadde.Text == "0")
            {
                ListItem li = (ListItem)ddlListeCadde.SelectedItem;
                caddeSil css = new caddeSil();
                string[] IdLer = li.Value.Split(';');
                int sonuc = css.caddeSilId(Convert.ToInt32(IdLer[0]));
                if (sonuc > 0)
                {
                    lblSonucCadde.Text = "Silindi";
                    lblSayiCadde.Text = "";
                    txtAdCadde.Text = "";
                    CaddeGetir();
                    ddlCaddeSemt.SelectedIndex = 0;
                }
                else
                {
                    lblSonucCadde.Text = "Hata Oluştu!";
                }
            }
            else
            {
                lblSonucCadde.Text = "Bu özellik şuanda kullanılıyor. Silemezsiniz.";
            }
        }
        catch (Exception ex)
        {
            hDepo.HataYakalaTUM(ex);
        }
    }
    protected void lbEkleCadde_Click(object sender, EventArgs e)
    {
        if (txtEkleCadde.Text != "" && ddlCaddeSemt.SelectedIndex > 0)
        {
            caddeEkle cee = new caddeEkle();
            ListItem li = (ListItem)ddlCaddeSemt.SelectedItem;
            int sonuc = cee.caddeEkleString(txtEkleCadde.Text, Convert.ToInt32(li.Value));
            if (sonuc > 0)
            {
                lblSonucCadde.Text = "Eklendi";
                lblSayiCadde.Text = "";
                txtAdCadde.Text = "";
                txtEkleCadde.Text = "";
                CaddeGetir();
                ddlCaddeSemt.SelectedIndex = 0;
            }
            else
            {
                lblSonucCadde.Text = "Hata Oluştu!";
            }
        }
        else
        {
            lblSonucCadde.Text = "Lütfen Cadde için isim giriniz.";
        }
    }
    protected void lbGuncelleCadde_Click(object sender, EventArgs e)
    {
        if (ddlListeCadde.SelectedIndex > 0 && ddlCaddeSemt.SelectedIndex > 0)
        {
            ListItem li = (ListItem)ddlListeCadde.SelectedItem;
            caddeGuncelle cgg = new caddeGuncelle();
            string[] IdLer = li.Value.Split(';');
            int sonuc = cgg.caddeGuncelleId(Convert.ToInt32(IdLer[0]), txtAdCadde.Text, Convert.ToInt32(ddlCaddeSemt.SelectedValue));
            if (sonuc > 0)
            {
                lblSonucCadde.Text = "Güncellendi!";
                lblSayiCadde.Text = "";
                txtAdCadde.Text = "";
                CaddeGetir();
                ddlCaddeSemt.SelectedIndex = 0;
            }
            else
            {
                lblSonucCadde.Text = "Hata Oluştu!";
            }
        }
        else
        {
            lblSayiCadde.Text = "";
            txtAdCadde.Text = "";
        }
    }
    protected void ddlListeCadde_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlListeCadde.SelectedIndex > 0)
        {
            ListItem li = (ListItem)ddlListeCadde.SelectedItem;
            txtAdCadde.Text = li.Text;
            string[] IdLer = li.Value.Split(';');
            lblSayiCadde.Text = cgg.caddeAdet(Convert.ToInt32(IdLer[0])).ToString();
            int indeks = 0;
            foreach (ListItem ot in ddlCaddeSemt.Items)
            {
                if (ot.Value == IdLer[1] && ot.Value != null)
                {
                    ddlCaddeSemt.SelectedIndex = indeks;
                    break;
                }
                indeks++;
            }
        }
        else
        {
            lblSayiCadde.Text = "";
            txtAdCadde.Text = "";
        }
    }
}
