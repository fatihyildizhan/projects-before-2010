using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using ExceptionLayer;

public partial class sayfalar_yoneticiWuc_emlakEkle_Adres : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            SehirGetirTum();
            if (Session["eGuncelleId"] != null)
            {
                lblAdresEkle.Text = "Adres Güncelle";
                btnAdresEkle.Text = "Adres Güncelle Adım 3";
                btnAdresEkle.Width = 150;
                int emlakId = Convert.ToInt32(Session["eGuncelleId"]);
                GuncelleAdresGetirId(emlakId);
            }
        }
    }
    public void GuncelleAdresGetirId(int emlakId)
    {
        adresGetir agg = new adresGetir();
        adres adr = agg.adresGetirId(emlakId);
        txtAdresTarif.Text = adr.AdresTarifi;
        
        IlceGetirTum(adr.SehirId);
        
        AdresBOSDoldurIlce();
        SemtGetirTum(adr.IlceId);
        
        AdresBOSDoldurSemt();
        CaddeGetirTum(adr.SemtId);

        int indeks = 0;
        foreach (ListItem sehirim in ddSehirler.Items)
        {
            if (sehirim.Value.ToString() == adr.SehirId.ToString())
            {
                ddSehirler.SelectedIndex = indeks;
                indeks = 0;
                break;
            }
            indeks++;
        }
        foreach (ListItem ilcem in ddIlceler.Items)
        {
            if (ilcem.Value.ToString() == adr.IlceId.ToString())
            {
                ddIlceler.SelectedIndex = indeks;
                indeks = 0;
                break;
            }
            indeks++;
        }
        foreach (ListItem semtim in ddSemtler.Items)
        {
            if (semtim.Value.ToString() == adr.SemtId.ToString())
            {
                ddSemtler.SelectedIndex = indeks;
                indeks = 0;
                break;
            }
            indeks++;
        }
        foreach (ListItem caddem in ddCaddeler.Items)
        {
            if (caddem.Value.ToString() == adr.CaddeId.ToString())
            {
                ddCaddeler.SelectedIndex = indeks;
                indeks = 0;
                break;
            }
            indeks++;
        }

    }
    public void AdresBOSDoldurSehir()
    {
        ddIlceler.Items.Clear();
        ListItem liii = new ListItem();
        liii.Text = "İlçe Seçiniz...";
        ddIlceler.Items.Add(liii);

        ddSemtler.Items.Clear();
        ListItem liis = new ListItem();
        liis.Text = "Semt Seçiniz...";
        ddSemtler.Items.Add(liis);


        ddCaddeler.Items.Clear();
        ListItem liic = new ListItem();
        liic.Text = "Cadde Seçiniz...";
        ddCaddeler.Items.Add(liic);
    }
    public void AdresBOSDoldurIlce()
    {
        ddSemtler.Items.Clear();
        ListItem liis = new ListItem();
        liis.Text = "Semt Seçiniz...";
        ddSemtler.Items.Add(liis);


        ddCaddeler.Items.Clear();
        ListItem liic = new ListItem();
        liic.Text = "Cadde Seçiniz...";
        ddCaddeler.Items.Add(liic);
    }
    public void AdresBOSDoldurSemt()
    {
        ddCaddeler.Items.Clear();
        ListItem liic = new ListItem();
        liic.Text = "Cadde Seçiniz...";
        ddCaddeler.Items.Add(liic);
    }
    public void SehirGetirTum()
    {
        ddSehirler.Items.Clear();
        ListItem lii = new ListItem();
        lii.Text = "Şehir Seçiniz...";
        ddSehirler.Items.Add(lii);

        AdresBOSDoldurSehir();
        sehirGetir sg = new sehirGetir();
        foreach (sehir item in sg.sehirGetirTum())
        {
            ListItem li = new ListItem();
            li.Text = item.SehirAd;
            li.Value = item.SehirId.ToString();
            ddSehirler.Items.Add(li);
        }
    }
    public void IlceGetirTum(int sehirId)
    {
        AdresBOSDoldurSehir();
        ilceGetir ig = new ilceGetir();
        foreach (ilce item in ig.ilceGetirSehirId(sehirId))
        {
            ListItem li = new ListItem();
            li.Text = item.IlceAd;
            li.Value = item.IlceId.ToString();
            ddIlceler.Items.Add(li);
        }
    }
    public void SemtGetirTum(int IlceId)
    {
        AdresBOSDoldurSemt();
        semtGetir sg = new semtGetir();
        foreach (semt item in sg.semtGetirIlceId(IlceId))
        {
            ListItem li = new ListItem();
            li.Text = item.SemtAd;
            li.Value = item.SemtId.ToString();
            ddSemtler.Items.Add(li);
        }
    }
    public void CaddeGetirTum(int semtId)
    {
        caddeGetir cg = new caddeGetir();
        foreach (cadde item in cg.caddeGetirSemtId(semtId))
        {
            ListItem li = new ListItem();
            li.Text = item.CaddeAd;
            li.Value = item.CaddeId.ToString();
            ddCaddeler.Items.Add(li);
        }
    }
    protected void ddSehirler_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            IlceGetirTum(Convert.ToInt32(ddSehirler.SelectedValue));
        }
        catch (Exception ex)
        {
            hDepo.HataYakalaTUM(ex);
        }
    }
    HataDEPOSU hDepo = new HataDEPOSU();
    protected void ddIlceler_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            AdresBOSDoldurIlce();
            SemtGetirTum(Convert.ToInt32(ddIlceler.SelectedValue));
        }
        catch (Exception ex)
        {
            hDepo.HataYakalaTUM(ex);
        }
    }
    protected void btnAdresEkle_Click(object sender, EventArgs e)
    {
        adres adr = new adres();
        adr.AdresTarifi = txtAdresTarif.Text;
        adr.IlceId = Convert.ToInt32(ddIlceler.SelectedValue);
        adr.SehirId = Convert.ToInt32(ddSehirler.SelectedValue);
        adr.SemtId = Convert.ToInt32(ddSemtler.SelectedValue);
        adr.CaddeId = Convert.ToInt32(ddCaddeler.SelectedValue);

        if (btnAdresEkle.Text == "Adres Ekle Adım 3")
        {
            adr.EmlakId = Convert.ToInt32(Session["sonEmlakId"]);
            adresEkle ae = new adresEkle();
            int sonuc = ae.adresEkleString(adr);
            if (sonuc > 0)
            {
                lblAdresSonuc.Text = "Adres Eklendi.";
                btnAdresEkle.Enabled = false;
            }
            else
            {
                lblAdresSonuc.Text = "Ekleme Başarısız!";
            }
        }
        else
        {
            adr.EmlakId = Convert.ToInt32(Session["eGuncelleId"]);
            adresGuncelle agg = new adresGuncelle();
            int sonuc = agg.adresGuncelleId(adr);
            if (sonuc > 0)
            {
                lblAdresSonuc.Text = "Adres Güncellendi.";
            }
            else
            {
                lblAdresSonuc.Text = "Güncelleme Başarısız!";
            }
        }
    }
    protected void lbSonrakiAdim_Click(object sender, EventArgs e)
    {
        Response.Redirect("emlakEkle_Ozellik.aspx");
    }
    protected void ddSemtler_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            AdresBOSDoldurSemt();
            CaddeGetirTum(Convert.ToInt32(ddSemtler.SelectedValue));
        }
        catch (Exception ex)
        {
            hDepo.HataYakalaTUM(ex);
        }
    }
}
