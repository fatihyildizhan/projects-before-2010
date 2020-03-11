using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace BusinessLayer
{
    public class fiyatGetir
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString.ToString());
        public fiyat fiyatGetirEmlakId(int gelenEmlakId)
        {
            fiyat f = new fiyat();
            try
            {
                SqlCommand com = new SqlCommand("select * from Fiyat where EmlakId=@emlakId", con);
                com.Parameters.AddWithValue("@emlakId",gelenEmlakId);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    f.Dolar = Convert.ToInt32(dr["dolar"]);
                    f.EmlakId = Convert.ToInt32(dr["EmlakId"]);
                    f.Euro = Convert.ToInt32(dr["Euro"]);
                    f.Pound = Convert.ToInt32(dr["Pound"]);
                    f.Tl = Convert.ToInt32(dr["TL"]);
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
            return f;
        }
    }
}
