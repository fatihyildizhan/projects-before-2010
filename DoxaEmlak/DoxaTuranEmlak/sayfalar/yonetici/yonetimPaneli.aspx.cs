using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class sayfalar_yonetici_yonetimPaneli : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            EmlakSayisiGetir();
        }
    }
    public void EmlakSayisiGetir()
    { 
        emlakGetir eg = new emlakGetir();
        lblTplmEmlkSys.Text = eg.emlakToplamSayisiGetir().ToString();
    }
}
