using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace BusinessLayer
{
    public class adresGetir
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString.ToString());
        public adres adresGetirId(int gelenEmlakId)
        {
            adres a = new adres();
            try
            {
                
                SqlCommand com = new SqlCommand("prcAdresGetirId", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@emlakId",gelenEmlakId);

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    a.AdresTarifi = dr["AdresTarifi"].ToString();
                    a.EmlakId = Convert.ToInt32(dr["EmlakId"]);
                    a.IlceAd = dr["IlceAd"].ToString();
                    a.IlceId = Convert.ToInt32(dr["IlceId"]);
                    a.SehirAd = dr["SehirAd"].ToString();
                    a.SehirId = Convert.ToInt32(dr["SehirId"]);
                    a.SemtAd = dr["SemtAd"].ToString();
                    a.SemtId = Convert.ToInt32(dr["SemtId"]);
                    a.CaddeId = Convert.ToInt32(dr["CaddeId"]);
                    a.CaddeAd = dr["CaddeAd"].ToString();
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
            return a;
        }
    }
}
