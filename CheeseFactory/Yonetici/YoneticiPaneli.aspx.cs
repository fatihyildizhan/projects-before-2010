using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Yonetici_YoneticiPaneli : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            SqlCommand com = new SqlCommand("select * from Kategori", con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                ddlKategori.Items.Add(dr["KategoriAd"].ToString());
            }
            dr.Close();
            con.Close();
        }
    }
    SqlConnection con = new SqlConnection("server=.;database=Takisoglu;uid=sa;pwd=123;");
    protected void btnUrunEkle_Click(object sender, EventArgs e)
    {
        SqlCommand com = new SqlCommand("UrunEkle",con);
        com.CommandType = CommandType.StoredProcedure;
        com.Parameters.AddWithValue("@UrunAd",txtUrunAd.Text);
        com.Parameters.AddWithValue("@KategoriId",Convert.ToInt32(Session["katId"]));
        com.Parameters.AddWithValue("@Aciklama",txtAciklama.Text);
        com.Parameters.AddWithValue("@Agirlik",txtAgirlik.Text+" "+RadioButtonList1.SelectedItem.Text);
        com.Parameters.AddWithValue("@Resim",txtResimYolu.Text);

        bool kontrol = true;
        try
        {
            con.Open();
            com.ExecuteNonQuery();
        }
        catch
        {
            kontrol = false;
        }
        finally
        {
            con.Close();
        }

        if (kontrol)
        {
            lblUrunEkleSonuc.Text = "Ürün başarıyla eklendi";
        }
        else
        {
            lblUrunEkleSonuc.Text = "Ürün ekleme başarısız";
        }

    }
    protected void ddlKategori_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlCommand com = new SqlCommand("select KategoriId from Kategori",con);
        con.Open();
        int sonuc = Convert.ToInt32(com.ExecuteScalar());
        Session["katId"] = sonuc;
        con.Close();
    }
    protected void btnUrunDetayEkle_Click(object sender, EventArgs e)
    {
        SqlCommand com = new SqlCommand("UrunDetayEkle",con);
        com.CommandType = CommandType.StoredProcedure;
        com.Parameters.AddWithValue("@UrunId",Convert.ToInt32(DropDownList1.SelectedItem.Value));
        com.Parameters.AddWithValue("@AdetAgirligi",txtAdetAgirligi.Text);
        com.Parameters.AddWithValue("@KoliIciAdedi",Convert.ToInt32(txtKoliIciAdedi.Text));
        com.Parameters.AddWithValue("@AmbalajTipi",txtAmbalajTipi.Text);
        com.Parameters.AddWithValue("@AmbalajAgirligi",txtAmbalajAgirligi.Text+""+RadioButtonList2.SelectedItem);
        com.Parameters.AddWithValue("@KacGramIcin",Convert.ToInt32(txtKacGramIcin.Text));
        com.Parameters.AddWithValue("@Enerji", Convert.ToInt32(txtEnerji.Text));
        com.Parameters.AddWithValue("@Protein", Convert.ToInt32(txtProtein.Text));
        com.Parameters.AddWithValue("@Yag", Convert.ToInt32(txtYag.Text));
        com.Parameters.AddWithValue("@Tuz", Convert.ToDecimal(txtTuz.Text));
        com.Parameters.AddWithValue("@Kalsiyum", Convert.ToInt32(txtKolestrol.Text));
        com.Parameters.AddWithValue("@Fosfor",Convert.ToInt32(txtFosfor.Text));
        com.Parameters.AddWithValue("@Kolestrol",Convert.ToInt32(txtKolestrol.Text));
        bool kontrol = true;
        try
        {
            con.Open();
            com.ExecuteNonQuery();
        }
        catch(Exception ex)
        {
            kontrol = false;
            lblUrunDetayEkleSonuc.Text = ex.ToString();
        }
        finally
        {
            con.Close();
        }

        if (kontrol)
        {
            lblUrunDetayEkleSonuc.Text = "Ürün başarıyla eklendi";
        }
        else
        {
            lblUrunDetayEkleSonuc.Text = "Ürün ekleme başarısız";
        }
        
    }
}
