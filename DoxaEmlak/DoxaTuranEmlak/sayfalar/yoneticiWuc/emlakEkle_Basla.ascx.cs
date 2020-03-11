using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using ExceptionLayer;

public partial class sayfalar_yoneticiWuc_emlakEkle_Basla : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            DDdoldur();
            EmlakTipGetir();
            IsitmaTipGetir();
            kategoriGetirTum();
            if (Session["eGuncelleId"] != null)
            {
                lblEmlakBaslik.Text = "Emlak Güncelle";
                btnEmlakEkleBasla.Text = "Emlak Güncelle Adım 1";
                btnEmlakEkleBasla.Width = 160;
                int emlakId = Convert.ToInt32(Session["eGuncelleId"].ToString());
                GuncelleEmlakGetirId(emlakId);
            }
        }
    }
    public void GuncelleEmlakGetirId(int emlakId)
    {
        emlakGetir egg = new emlakGetir();
        emlak e = new emlak();
        e = egg.emlakGetirId(emlakId);
        txtAidat.Text = e.Aidat;
        txtBalkonSayisi.Text = e.BalkonSayisi.ToString();
        txtBanyoSayisi.Text = e.BanyoSayisi.ToString();
        txtBinadakiKatSayisi.Text = e.BinadakiKatSayisi.ToString();
        txtBinaYasi.Text = e.BinaYasi.ToString();
        txtBulunduguKat.Text = e.BulunduguKat.ToString();
        txtDeposit.Text = e.Deposit.ToString();
        txtDurumu.Text = e.Durumu;
        txtEmlakAciklamasi.Text = e.EmlakAciklama;
        txtEmlakBaslik.Text = e.EmlakBaslik;
        txtEmlakM2.Text = e.EmlakM2;
        txtEmlakReferansNo.Text = e.EmlakReferansNo.ToString();
        txtOdaSayisi.Text = e.OdaSayisi;
        txtTapuDurumu.Text = e.TapuDurumu;

        cbKrediyeUygunMu.Checked = e.KrediyeUygun;
        int indeks = 0;
        foreach (ListItem kategori in ddEmlakKategori.Items)
        {
            if (kategori.Value.ToString() == e.KategoriId.ToString())
            {
                ddEmlakKategori.SelectedIndex = indeks;
                indeks = 0;
                break;
            }
            indeks++;
        }
        foreach (ListItem emlakTip in ddEmlakTipi.Items)
        {
            if (emlakTip.Value.ToString() == e.EmlakTipId.ToString())
            {
                ddEmlakTipi.SelectedIndex = indeks;
                indeks = 0;
                break;
            }
            indeks++;
        }
        foreach (ListItem isitmaTip in ddIsitmaTipi.Items)
        {
            if (isitmaTip.Value.ToString() == e.IsitmaTipId.ToString())
            {
                ddIsitmaTipi.SelectedIndex = indeks;
                indeks = 0;
                break;
            }
            indeks++;
        }
    }
    public void DDdoldur()
    {
        ListItem li = new ListItem();
        li.Text = "Emlak tipini Seçiniz...";
        ddEmlakTipi.Items.Add(li);

        ListItem li2 = new ListItem();
        li2.Text = "Isıtma tipini Seçiniz...";
        ddIsitmaTipi.Items.Add(li2);

        ListItem li3 = new ListItem();
        li3.Text = "Kategori Seçiniz...";
        ddEmlakKategori.Items.Add(li3);
    }
    public void EmlakTipGetir()
    {
        try
        {
            emlakTipGetir etg = new emlakTipGetir();
            foreach (emlakTip item in etg.emlakTipGetirTum())
            {
                ListItem li = new ListItem();
                li.Text = item.EmlakTipAd;
                li.Value = item.EmlakTipId.ToString();
                ddEmlakTipi.Items.Add(li);
            }
        }
        catch (Exception ex)
        {
            hDepo.HataYakalaTUM(ex);
        }
    }
    HataDEPOSU hDepo = new HataDEPOSU();
    public void IsitmaTipGetir()
    {
        try
        {
            isitmaTipGetir itg = new isitmaTipGetir();
            foreach (isitmaTip item in itg.isitmaTipGetirTum())
            {
                ListItem li = new ListItem();
                li.Text = item.IsitmaTipAd;
                li.Value = item.IsitmaTipId.ToString();
                ddIsitmaTipi.Items.Add(li);
            }
        }
        catch (Exception ex)
        {
            hDepo.HataYakalaTUM(ex);
        }
    }
    public void kategoriGetirTum()
    {
        try
        {
            kategoriGetir kg = new kategoriGetir();
            foreach (kategori item in kg.kategoriGetirTum())
            {
                ListItem li = new ListItem();
                li.Text = item.KategoriAd.ToString();
                li.Value = item.KategoriId.ToString();
                ddEmlakKategori.Items.Add(li);
            }
        }
        catch (Exception ex)
        {
            hDepo.HataYakalaTUM(ex);
        }
    }
    protected void btnEmlakEkleBasla_Click(object sender, EventArgs e)
    {
        try
        {
            if (ddEmlakKategori.SelectedIndex != 0 && ddEmlakTipi.SelectedIndex != 0 && ddIsitmaTipi.SelectedIndex != 0)
            {
                emlak emlk = new emlak();
                emlk.Aidat = txtAidat.Text;
                emlk.BanyoSayisi = txtBanyoSayisi.Text;
                emlk.BinadakiKatSayisi = Convert.ToInt32(txtBanyoSayisi.Text);
                emlk.BinaYasi = Convert.ToInt32(txtBinaYasi.Text);
                emlk.BulunduguKat = Convert.ToInt32(txtBulunduguKat.Text);
                emlk.Deposit = txtDeposit.Text;
                emlk.Durumu = txtDurumu.Text;
                emlk.EmlakAciklama = txtEmlakAciklamasi.Text;
                emlk.EmlakBaslik = txtEmlakBaslik.Text;
                emlk.EmlakM2 = txtEmlakM2.Text;
                emlk.EmlakReferansNo = Convert.ToInt32(txtEmlakReferansNo.Text);
                emlk.EmlakTipId = Convert.ToInt32(ddEmlakTipi.SelectedValue);
                emlk.IsitmaTipId = Convert.ToInt32(ddIsitmaTipi.SelectedValue);
                emlk.KrediyeUygun = Convert.ToBoolean(cbKrediyeUygunMu.Checked);
                emlk.OdaSayisi = txtOdaSayisi.Text;
                emlk.TapuDurumu = txtTapuDurumu.Text;
                emlk.KategoriId = Convert.ToInt32(ddEmlakKategori.SelectedValue);
                emlk.BalkonSayisi = Convert.ToInt32(txtBalkonSayisi.Text);

                if (btnEmlakEkleBasla.Text == "Emlak Ekle Adım 1")
                {
                    emlakEkle ee = new emlakEkle();
                    int sonuc = ee.emlakEkleString(emlk);
                    if (sonuc > 0)
                    {
                        lblSonuc.Text = "Emlak Eklendi.";
                        SonEmlakIdGetir();
                        btnEmlakEkleBasla.Enabled = false;
                    }
                    else
                    {
                        lblSonuc.Text = "Ekleme başarısız!";
                    }
                }
                else
                {
                    emlk.EmlakId = Convert.ToInt32(Session["eGuncelleId"]);
                    emlakGuncelle eggg = new emlakGuncelle();
                    int sonuc = eggg.emlakGuncelleMetod(emlk);
                    if (sonuc > 0)
                    {
                        lblSonuc.Text = "Emlak Güncellendi.";
                    }
                    else
                    {
                        lblSonuc.Text = "Güncelleme Başarısız!";
                    }
                }
            }
            else
            {
                lblSonuc.Text = "Lütfen Kategori, EmlakTip, IsıtmaTip bölümlerini doldurunuz.";
            }
        }
        catch (Exception ex)
        {
            hDepo.HataYakalaTUM(ex);
        }
    }
    public void SonEmlakIdGetir()
    {
        emlakGetir eg = new emlakGetir();
        Session["sonEmlakId"] = eg.emlakIdGetirSonEklenen();
    }
    protected void lbSonrakiAdim_Click(object sender, EventArgs e)
    {
        Response.Redirect("emlakEkle_Fiyat.aspx");
    }
}
