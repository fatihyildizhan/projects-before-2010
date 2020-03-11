using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
namespace SinemaDAL.Facade
{
     public static class Film
    {
         public static bool FilmEkle(string pfilmAd, int pkategoriId, string paciklama, int psure)
         {
             SqlConnection con = new SqlConnection("server=.;database=sinema;uid=sa;pwd=123");
             
             SqlCommand com = new SqlCommand("prc_FilmEkle",con);
             com.CommandType = CommandType.StoredProcedure;
             com.Parameters.AddWithValue("@FilmAd",pfilmAd);
             com.Parameters.AddWithValue("@KategoriId", pkategoriId);
             com.Parameters.AddWithValue("@aciklama", paciklama);
             com.Parameters.AddWithValue("@sure", psure);
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
             return kontrol;
         }
         public static bool FilmGuncelle(int pfilmId,string pfilmAd, int pkategoriId, string paciklama, int psure)
         {
             SqlConnection con = new SqlConnection("server=.;database=sinema;uid=sa;pwd=123");
             SqlCommand com = new SqlCommand("prc_FilmGuncelle", con);
             com.CommandType = CommandType.StoredProcedure;
             com.Parameters.AddWithValue("@FilmID", pfilmId);
             com.Parameters.AddWithValue("@FilmAd", pfilmAd);
             com.Parameters.AddWithValue("@KategoriId", pkategoriId);
             com.Parameters.AddWithValue("@aciklama", paciklama);
             com.Parameters.AddWithValue("@sure", psure);
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

             return kontrol;

         }
         public static bool FilmSil(int pfilmId)
         {
             SqlConnection con = new SqlConnection("server=.;database=sinema;uid=sa;pwd=123");

             SqlCommand com = new SqlCommand("prc_FilmSil", con);
             com.CommandType = CommandType.StoredProcedure;

             com.Parameters.AddWithValue("@FilmID", pfilmId);


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

             return kontrol;

         }
       
         public static ArrayList FilmGetir()
         {
             SqlConnection con = new SqlConnection("server=.;database=sinema;uid=sa;pwd=123");
             SqlCommand com = new SqlCommand("prc_FilmGetir", con);
             com.CommandType = CommandType.StoredProcedure;
             ArrayList filmlistesi = new ArrayList();
             
             con.Open();
             SqlDataReader dr = com.ExecuteReader();
             while (dr.Read())
             {
                 Entity.Film f = new SinemaDAL.Entity.Film();
                 f.FilmId = Convert.ToInt32(dr["FilmId"]);
                 f.FilmAd = dr["FilmAd"].ToString();
                 f.FilmAciklama = dr["Aciklama"].ToString();
                 f.KategoriId = Convert.ToInt32(dr["KategoriID"]);
                 f.Sure = Convert.ToInt32(dr["Sure"]);

                 filmlistesi.Add(f);
             }
             dr.Close();
             con.Close();

             return filmlistesi;
         }
        
         public static Entity.Film FilmGetir(int id)
         {
             SqlConnection con = new SqlConnection("server=.;database=sinema;uid=sa;pwd=123");

             SqlCommand com = new SqlCommand("prc_FilmGetirId", con);
             com.CommandType = CommandType.StoredProcedure;

             com.Parameters.AddWithValue("@FilmId", id);

            

             con.Open();
             SqlDataReader dr = com.ExecuteReader();

             Entity.Film f = null;

             while (dr.Read())
             {
                 f = new SinemaDAL.Entity.Film();

                 f.FilmId = Convert.ToInt32(dr["FilmId"]);
                 f.FilmAd = dr["FilmAd"].ToString();
                 f.FilmAciklama = dr["Aciklama"].ToString();
                 f.KategoriId = Convert.ToInt32(dr["KategoriID"]);
                 f.Sure = Convert.ToInt32(dr["Sure"]);

                
             }
             dr.Close();
             con.Close();


             return f;

         }
    }
}
