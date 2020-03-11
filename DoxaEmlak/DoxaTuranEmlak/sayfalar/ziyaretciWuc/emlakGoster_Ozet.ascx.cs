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

public partial class sayfalar_ziyaretciWuc_emlakGoster_Ozet : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Request.QueryString["katId"] != null)
            {
                // Konut
                if (Request.QueryString["katId"].ToString() == "8")
                {
                    emlakOzetleriGetir(8);
                }
                // Arsa
                else if (Request.QueryString["katId"].ToString() == "13")
                {
                    emlakOzetleriGetir(13);
                }
                // İşyeri
                else if (Request.QueryString["katId"].ToString() == "7")
                {
                    emlakOzetleriGetir(7);
                }
                // Yazlık
                else if (Request.QueryString["katId"].ToString() == "6")
                {
                    emlakOzetleriGetir(6);
                }
                // Devremülk
                else if (Request.QueryString["katId"].ToString() == "1")
                {
                    emlakOzetleriGetir(1);
                }
                // Bina
                else if (Request.QueryString["katId"].ToString() == "11")
                {
                    emlakOzetleriGetir(11);
                }
                else
                {

                }
            }

        }
    }
    emlakGetir eg = new emlakGetir();
    public void emlakOzetleriGetir(int emlakTipId)
    {
        DataList1.DataSource = eg.emlakOzetGetir(emlakTipId);
        DataList1.DataBind();
    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "detay")
        {
            Response.Redirect("emlakGoster_Detay.aspx?emlSayisi=+" + e.CommandArgument);
        }
    }
}
