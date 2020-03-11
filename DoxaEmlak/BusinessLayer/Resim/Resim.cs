using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Collections.Generic;

/// <summary>
/// Summary description for Resim
/// </summary>
/// 
namespace BusinessLayer
{

    public class Resim
    {
        #region fields
        int id;
        string baslik;
        string tarih;
        int galeriId;
        string resimKucuk;
        string resimBuyuk;
        #endregion

        #region properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Baslik
        {
            get { return baslik; }
            set { baslik = value; }
        }

        public string Tarih
        {
            get { return tarih; }
            set { tarih = value; }
        }

        public int GaleriId
        {
            get { return galeriId; }
            set { galeriId = value; }
        }

        public string ResimKucuk
        {
            get { return resimKucuk; }
            set { resimKucuk = value; }
        }

        public string ResimBuyuk
        {
            get { return resimBuyuk; }
            set { resimBuyuk = value; }
        }
        #endregion

        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);


        public List<Resim> ResimGetirTum(int gelenId)
        {
            List<Resim> resimler = new List<Resim>();
            SqlCommand com = new SqlCommand("select * from Resim where emlakId=@emlakId", con);
            com.CommandType = CommandType.Text;
            com.Parameters.AddWithValue("@emlakId", gelenId);
            try
            {
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    Resim r = new Resim();
                    r.Baslik = dr["r-baslik"].ToString();
                    r.GaleriId = Convert.ToInt32(dr["emlakId"]);
                    r.Id = Convert.ToInt32(dr["r-id"]);
                    r.ResimBuyuk = "../../resimler/emlaklar/Buyuk/" + dr["r-resimBuyuk"].ToString();
                    r.ResimKucuk = "../../resimler/emlaklar/Kucuk/" + dr["r-resimKucuk"].ToString();
                    r.Tarih = Convert.ToDateTime(dr["r-tarih"]).ToShortDateString();
                    resimler.Add(r);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return resimler;
        }

        public Resim ResimGetirId(int gelenId)
        {
            Resim r = new Resim();
            SqlCommand com = new SqlCommand("select * from Resim where [r-id]=@id", con);
            com.CommandType = CommandType.Text;
            com.Parameters.AddWithValue("@id", gelenId);
            try
            {
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    r.Baslik = dr["r-baslik"].ToString();
                    r.GaleriId = Convert.ToInt32(dr["emlakId"]);
                    r.Id = Convert.ToInt32(dr["r-id"]);
                    r.ResimBuyuk = "../Resimler/Buyuk/" + dr["r-resimBuyuk"].ToString();
                    r.ResimKucuk = "../Resimler/Kucuk/" + dr["r-resimKucuk"].ToString();
                    r.Tarih = Convert.ToDateTime(dr["r-tarih"]).ToShortDateString();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return r;
        }

        public bool ResimEkle(string gelenBaslik, int gelenEmlakId, string gelenResimKucuk, string gelenResimBuyuk)
        {
            bool eklendiMi = false;
            SqlCommand com = new SqlCommand("ResimEkle", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@baslik", gelenBaslik);
            com.Parameters.AddWithValue("@emlakId", gelenEmlakId);
            com.Parameters.AddWithValue("@resimKucuk", gelenResimKucuk);
            com.Parameters.AddWithValue("@resimBuyuk", gelenResimBuyuk);

            try
            {
                con.Open();
                int value = com.ExecuteNonQuery();
                if (value > 0)
                {
                    eklendiMi = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return eklendiMi;
        }

        public bool ResimBilgiGuncelleId(int gelenId, string gelenBaslik)
        {
            bool guncellendiMi = false;
            SqlCommand com = new SqlCommand("update Resim set [r-baslik]=@baslik where [r-id]=@id", con);
            com.CommandType = CommandType.Text;
            com.Parameters.AddWithValue("@id", gelenId);
            com.Parameters.AddWithValue("@baslik", gelenBaslik);

            try
            {
                con.Open();
                int value = com.ExecuteNonQuery();
                if (value > 0)
                {
                    guncellendiMi = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return guncellendiMi;
        }

        public bool ResimResimGuncelleId(int gelenId, string gelenResimKucuk, string gelenResimBuyuk)
        {
            bool guncellendiMi = false;
            SqlCommand com = new SqlCommand("ResimResimGuncelleId", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", gelenId);
            com.Parameters.AddWithValue("@resimKucuk", gelenResimKucuk);
            com.Parameters.AddWithValue("@resimBuyuk", gelenResimBuyuk);

            try
            {
                con.Open();
                int value = com.ExecuteNonQuery();
                if (value > 0)
                {
                    guncellendiMi = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return guncellendiMi;
        }

        public bool ResimSilId(int gelenId)
        {
            bool silindiMi = false;
            SqlCommand com = new SqlCommand("delete Resim where [r-id]=@id", con);
            com.CommandType = CommandType.Text;
            com.Parameters.AddWithValue("@id", gelenId);

            try
            {
                con.Open();

                int value = com.ExecuteNonQuery();

                if (value > 0)
                {
                    silindiMi = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return silindiMi;
        }
    }

}