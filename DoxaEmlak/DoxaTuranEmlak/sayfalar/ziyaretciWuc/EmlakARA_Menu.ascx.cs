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

public partial class sayfalar_ziyaretciWuc_EmlakARA_Menu : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            SehirGetirTum();
            EmlakTipGetirTum();
            KategoriGetirTum();
        }
    }
    public void EmlakTipGetirTum()
    {
        ListItem lii = new ListItem();
        lii.Text = "Emlak Tipi Seçiniz...";
        ddEmlakTipler.Items.Add(lii);

        emlakTipGetir etg = new emlakTipGetir();
        foreach (emlakTip item in etg.emlakTipGetirTum())
        {
            ListItem li = new ListItem();
            li.Text = item.EmlakTipAd;
            li.Value = item.EmlakTipId.ToString();
            ddEmlakTipler.Items.Add(li);
        }
    }
    public void KategoriGetirTum()
    {
        ListItem liii = new ListItem();
        liii.Text = "Kategori Seçiniz...";
        ddKategori.Items.Add(liii);
        kategoriGetir kg = new kategoriGetir();
        foreach (kategori ktg in kg.kategoriGetirTum())
        {
            ListItem li = new ListItem();
            li.Text = ktg.KategoriAd;
            li.Value = ktg.KategoriId.ToString();
            ddKategori.Items.Add(li);
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
    protected void btnEmlakAra_Click(object sender, EventArgs e)
    {
        string sorguTablo = "select Emlak.EmlakId from Emlak ";
        string sorguKriter = "";
        bool kriterEklendiMi = false;

        if (ddKategori.SelectedIndex > 0)
        {
            kriterEklendiMi = true;
            sorguKriter += " where KategoriId=" + ddKategori.SelectedValue + " ";
        }

        if (ddEmlakTipler.SelectedIndex > 0 && !kriterEklendiMi)
        {
            kriterEklendiMi = true;
            sorguKriter += " where EmlakTipId=" + ddEmlakTipler.SelectedValue + " ";
        }
        else if (ddEmlakTipler.SelectedIndex > 0)
        {
            sorguKriter += " and EmlakTipId=" + ddEmlakTipler.SelectedValue + " ";
        }

        if (ddCaddeler.SelectedIndex > 0 && !kriterEklendiMi)
        {
            kriterEklendiMi = true;
            sorguTablo += ", Adres ";
            sorguKriter += " where Emlak.EmlakId=Adres.EmlakId and Adres.CaddeId=" + ddCaddeler.SelectedValue + " ";
        }
        else if (ddCaddeler.SelectedIndex > 0)
        {
            sorguTablo += ", Adres";
            sorguKriter += " and Emlak.EmlakId=Adres.EmlakId and Adres.CaddeId=" + ddCaddeler.SelectedValue + " ";
        }

        if (txtFiyat.Text != "0" && txtFiyat.Text != "" && !kriterEklendiMi)
        {
            kriterEklendiMi = true;
            sorguTablo += ", Fiyat ";
            if (rbFiyatEsitBuyuk.Checked)
            {
                sorguKriter += " where Emlak.EmlakId=Fiyat.EmlakId and Fiyat.TL <=" + txtFiyat.Text;
            }
            else
            {
                sorguKriter += " where Emlak.EmlakId=Fiyat.EmlakId and Fiyat.TL >=" + txtFiyat.Text;
            }
        }
        else if (txtFiyat.Text != "0" && txtFiyat.Text != "")
        {
            sorguTablo += ", Fiyat ";
            if (rbFiyatEsitBuyuk.Checked)
            {
                sorguKriter += " and Emlak.EmlakId=Fiyat.EmlakId and Fiyat.TL <=" + txtFiyat.Text;
            }
            else
            {
                sorguKriter += " and Emlak.EmlakId=Fiyat.EmlakId and Fiyat.TL >=" + txtFiyat.Text;
            }
        }

        if (txtReferans.Text != "0" && txtReferans.Text != "" && !kriterEklendiMi)
        {
            kriterEklendiMi = true;
            if (rbReferansBuyuk.Checked)
            {
                sorguKriter += " where EmlakReferansNo <=" + txtReferans.Text;
            }
            else
            {
                sorguKriter += " where EmlakReferansNo >=" + txtReferans.Text;
            }
        }
        else if (txtReferans.Text != "0" && txtReferans.Text != "")
        {
            if (rbReferansBuyuk.Checked)
            {
                sorguKriter += " and EmlakReferansNo <=" + txtReferans.Text;
            }
            else
            {
                sorguKriter += " and EmlakReferansNo >=" + txtReferans.Text;
            }
        }
        emlakOzetleriGetir(sorguTablo + sorguKriter);
    }
    protected void lbSifirla_Click(object sender, EventArgs e)
    {
        txtFiyat.Text = "0";
        txtReferans.Text = "0";
        ddEmlakTipler.SelectedIndex = 0;
        ddIlceler.SelectedIndex = 0;
        ddSehirler.SelectedIndex = 0;
        ddSemtler.SelectedIndex = 0;
        ddKategori.SelectedIndex = 0;
        ddCaddeler.SelectedIndex = 0;
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
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "detay")
        {
            Response.Redirect("emlakGoster_Detay.aspx?emlSayisi=" + e.CommandArgument);
        }
    }
    emlakGetir eg = new emlakGetir();
    public void emlakOzetleriGetir(string Sorgu)
    {
        DataList1.DataSource = eg.emlakAraMenu(Sorgu);
        DataList1.DataBind();
    }
    protected void lbDetayliArama_Click(object sender, EventArgs e)
    {
        Response.Redirect("arama.aspx");
    }
}
