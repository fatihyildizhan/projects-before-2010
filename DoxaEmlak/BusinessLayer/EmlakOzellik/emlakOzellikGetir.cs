using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLayer
{
    public class emlakOzellikGetir
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString.ToString());
        public List<ozellik> emlakOzellikGetirId(int emlakId)
        {
            List<ozellik> ozellikler = new List<ozellik>();
            try
            {
                SqlCommand com = new SqlCommand("select OzellikAd, O.OzellikId from Ozellik o , EmlakOzellik eo where o.OzellikId = eo.OzellikId and EmlakId = @emlakId", con);
                com.CommandType = CommandType.Text;
                com.Parameters.AddWithValue("@emlakId",emlakId);

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ozellik o = new ozellik();
                    o.OzellikAd = dr["OzellikAd"].ToString();
                    o.OzellikId = Convert.ToInt32(dr["OzellikId"]);
                    ozellikler.Add(o);
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
            return ozellikler;
        }
    }
}