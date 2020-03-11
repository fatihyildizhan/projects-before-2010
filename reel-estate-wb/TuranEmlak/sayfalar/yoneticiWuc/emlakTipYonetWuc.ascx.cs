using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinessLayer;

namespace BussinessLayer.sayfalar.yoneticiWuc
{
    public partial class emlakTipYonetWuc : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                emlakTipGetirGrid();
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "guncelle")
            {

            }
            else if(e.CommandName == "sil")
            {
                pnlSil.Visible = true;
                Session["silId"] = e.CommandArgument;
            }
        }

        protected void lbEvet_Click(object sender, EventArgs e)
        {
            emlakTipSil et = new emlakTipSil();
            bool silindiMi = et.emlakTipSilId(Convert.ToInt32(Session["silId"]));
            if (silindiMi)
            {
                lblSonuc.Text = "Seçilen emlak tipi silindi.";
                emlakTipGetirGrid();
            }
            else
            {
                lblSonuc.Text = "Silme işlemi sırasında hata oluştu.";
            }
            pnlSil.Visible = false;
        }

        protected void lbIptal_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "Silme işlemi iptal edilmiştir.";
            pnlSil.Visible = false;
        }
        public void emlakTipGetirGrid()
        {
            EmlakTip.emlakTipGetir eetg = new BussinessLayer.EmlakTip.emlakTipGetir();
            gridEmlakTip.DataSource = eetg.emlakTipGetirTum();
            gridEmlakTip.DataBind();
        }

        protected void btnEmlakTipEkle_Click(object sender, EventArgs e)
        {
            emlakTipEkle ete = new emlakTipEkle();
            bool eklendiMi = ete.emlakTipEkleString(txtEmlakTip.Text.Trim());
            if(eklendiMi)
            {
                lblSonuc.Text = "Emlak tipi eklendi.";
                emlakTipGetirGrid();
            }
            else
            {
                lblSonuc.Text = "Emlak tipi eklerken sorun oluştu.";
            }
        }
    }
}