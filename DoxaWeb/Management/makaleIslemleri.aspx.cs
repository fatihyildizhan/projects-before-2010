using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class Management_makaleIslemleri : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //SqlCommand com = new SqlCommand("select * from Konu",con);
        //con.Open();
        //SqlDataReader dr = com.ExecuteReader();
        //while (dr.Read())
        //{
        //    Konu k = new Konu();
        //    k.Aciklama = dr["Aciklama"].ToString();
        //    k.KonuAd = dr["KonuAd"].ToString();
        //    k.KonuId = Convert.ToInt32(dr["KonuId"]);
            
        //    ddlKonuAd.Items.Add(k.ToString());
        //}
        //dr.Close();
        //con.Close();
    }
    SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ToString());

    protected void btnMakaleEkle_Click(object sender, EventArgs e)
    {
       
        Makale m = new Makale();
        m.Aciklama = txtAciklama.Text;
        m.Link = txtLink.Text;
        m.MakaleAd = txtMakaleAd.Text;
        m.Ozet = txtOzet.Text;
        m.KonuId = Convert.ToInt32(txtKonuId.Text);
        m.Yazar = txtYazar.Text;
        Functions.MakaleEklee(m);
    }
}
