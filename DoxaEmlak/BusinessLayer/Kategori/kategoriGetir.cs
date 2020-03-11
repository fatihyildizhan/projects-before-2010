using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace BusinessLayer
{
    public class kategoriGetir
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString.ToString());
       
        public List<kategori> kategoriGetirTum()
        {
            List<kategori> kategoriler = new List<kategori>();
            try
            {
                SqlCommand com = new SqlCommand("select * from kategori  order by KategoriAd", con);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    kategori k = new kategori();
                    k.KategoriAd = dr["KategoriAd"].ToString();
                    k.KategoriId = Convert.ToInt32(dr["KategoriId"]);
                    kategoriler.Add(k);
                }
                dr.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return kategoriler;
        }
        public kategori kategoriGetirId(int kategoriId)
        {
            kategori k = new kategori();
            try
            {
                SqlCommand com = new SqlCommand("select * from Kategori where KategoriId=@kid", con);
                com.Parameters.AddWithValue("@kid", kategoriId);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    k.KategoriAd = dr["KategoriAd"].ToString();
                    k.KategoriId = Convert.ToInt32(dr["KategoriId"]);
                }
                dr.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return k;
        }
        public int KategoriAdet(int id)
        {
            int adet = 0;
            try
            {
                SqlCommand com = new SqlCommand("select count(*) from Emlak where KategoriId=@id", con);
                com.CommandType = CommandType.Text;
                com.Parameters.AddWithValue("@id", id);

                con.Open();
                adet = Convert.ToInt32(com.ExecuteScalar());
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return adet;
        }
    }
}
