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
using System.Collections.Generic;
using BusinessLayer.Emlak;
using ExceptionLayer;

public partial class sayfalar_ziyaretciWuc_emlakARA_Dinamik : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            OzellikGetirTum();
        }
    }
    public void OzellikGetirTum()
    {
        try
        {
            ozellikGetir og = new ozellikGetir();
            List<ozellik> ozellikler = og.ozellikGetirTum();

            ozellikTipGetir ozelTipGetir = new ozellikTipGetir();
            List<ozellikTip> ozelTipler = ozelTipGetir.ozellikTipGetirTum();
            for (int i = 0; i < ozelTipler.Count; i++)
            {
                ListItem lii = new ListItem();
                lii.Enabled = false;
                lii.Text = ozelTipler[i].OzellikTipAd;
                cblOzellikler.Items.Add(lii);

                foreach (ozellik item in ozellikler)
                {
                    if (ozelTipler[i].OzellikTipId == item.OzellikTipId)
                    {
                        ListItem li = new ListItem();
                        li.Text = item.OzellikAd;
                        li.Value = item.OzellikId.ToString();
                        cblOzellikler.Items.Add(li);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            hDepo.HataYakalaTUM(ex);
        }
    }
    HataDEPOSU hDepo = new HataDEPOSU();
    protected void lbEvAraDinamik_Click(object sender, EventArgs e)
    {
        DbManager dm = new DbManager(false);
        try
        {
            ArrayList ozllklr = new ArrayList();
            foreach (ListItem ozellik in cblOzellikler.Items)
            {
                if (ozellik.Selected)
                {
                    ozllklr.Add(ozellik.Value);
                }
            }
            emlakAra ea = new emlakAra();
            emlakGetir eg = new emlakGetir();
            dtlistEmlak.DataSource = eg.emlakAraDinamikSorgu(ea.evAraDinamikSorguOlustur(ozllklr));
            dtlistEmlak.DataBind();
        }
        catch (Exception ex)
        {
            hDepo.HataYakalaTUM(ex);
        }
    }
    protected void dtlistEmlak_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "detay")
        {
            Response.Redirect("emlakGoster_Detay.aspx?emlSayisi=+" + e.CommandArgument);
        }
    }
}
