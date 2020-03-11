using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace DoxaKutuphaneDAL.Facade
{
    public static class Kitap
    {
        public static SqlConnection con = new SqlConnection("server=.;database=DoxaKutuphane;trusted_connection=true");
        
          public static SqlDataAdapter da;
          public static DataTable dt;
   
        public static DataTable YazarGetir(int pYazarId,string pAd,string pSoyad,int pYayinEviId)
        { 
            SqlCommand com = new SqlCommand("YazarGetir", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@YazarId",pYazarId);
            com.Parameters.AddWithValue("@Ad",pAd);
            com.Parameters.AddWithValue("@Soyad",pSoyad);
            com.Parameters.AddWithValue("@YayinEviId",pYayinEviId);
            da = new SqlDataAdapter(com);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static bool KitapEkle(string pKitapAd, int pKategoriId,int pYazarId,int pYayinEviId)
        {

            SqlCommand com = new SqlCommand("KitapEkle", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@KitapAd", pKitapAd);
            com.Parameters.AddWithValue("@KategoriId",pKategoriId);
            com.Parameters.AddWithValue("@YazarId",pYazarId);
            com.Parameters.AddWithValue("@YayinEviId",pYayinEviId);

            bool kontrol = true;
            try
            {     
                DoxaMethodsDAL.Facade.Connection.ConOpen(con);
                com.ExecuteNonQuery();
            }
            catch (Exception)
            {
                kontrol = false;
            }
            finally
            {
                DoxaMethodsDAL.Facade.Connection.ConClose(con);
            }
            return kontrol;
        }
        public static DataTable KitapGetir(string pKitapAd, int pKategoriId, int pYazarId, int pYayinEviId)
        {
            SqlCommand com = new SqlCommand("KitapGetir",con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@KitapAd",pKitapAd);
            com.Parameters.AddWithValue("@KategoriId",pKategoriId);
            com.Parameters.AddWithValue("@YazarId",pYazarId);
            com.Parameters.AddWithValue("@YayinEviId",pYayinEviId);
            da = new SqlDataAdapter(com);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //public static DataTable TumKitaplariGetir()
        //{
        //    SqlCommand com = new SqlCommand("select * from Kitap");
        //}
        public static ArrayList KitapGetir2(string pKitapAd, int pKategoriId, int pYazarId, int pYayinEviId)
        {
            SqlCommand com = new SqlCommand("KitapGetir",con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@KitapAd",pKitapAd);
            com.Parameters.AddWithValue("@KategoriId",pKategoriId);
            com.Parameters.AddWithValue("@YazarId",pYazarId);
            com.Parameters.AddWithValue("@YayinEviId",pYayinEviId);

            DoxaMethodsDAL.Facade.Connection.ConOpen(con);

            ArrayList liste = new ArrayList();

            SqlDataReader dr = com.ExecuteReader();
            
            while (dr.Read())
            {

                DoxaKutuphaneDAL.Entity.Kitap k = new DoxaKutuphaneDAL.Entity.Kitap();
                k.KitapAd = dr["KitapAd"].ToString();
                k.KategoriId = Convert.ToInt32(dr["KategoriId"]);
                k.YazarId = Convert.ToInt32(dr["YazarId"]);
                k.YayinEviId = Convert.ToInt32(dr["YayinEviId"]);

                liste.Add(k);            
            }
            DoxaMethodsDAL.Facade.Connection.ConClose(con);
            dr.Close();
            
            return liste;
        }
    }
}
