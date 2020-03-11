using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BussinessLayer;

namespace BussinessLayer.sayfalar.yonetici
{
    public partial class emlakYonet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                EmlakTipGoster();
            }
        }

        protected void btnEmlakEkle_Click(object sender, EventArgs e)
        {
            Emlak ee = new Emlak();
            ee.EmlakBoyut = prmTxtEmlakBoyut.Text;
            ee.EmlakTipId = Convert.ToInt32(prmDdEmlakTip.SelectedItem.Value);
            ee.EmlakTuru = prmTxtEmlakTuru.Text;
            bool eklendiMi = emlakEkle.emlakEkleEmlak(ee);
        }
        EmlakTip.emlakTipGetir etg = new BussinessLayer.EmlakTip.emlakTipGetir();
        public void EmlakTipGoster()
        {
            foreach (EmlakTip.emlakTip emlakTip in etg.emlakTipGetirTum())
            {
                ListItem li = new ListItem(emlakTip.EmlakTipIsim, emlakTip.EmlakTipId.ToString());
                prmDdEmlakTip.Items.Add(li);
            }
        }
    }
}
