using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace BusinessLayer
{
    public class emlakTipGetir
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString.ToString());
        public ListItemCollection emlakTipGetirTum1()
        {
            ListItemCollection lic = new ListItemCollection();
            try
            {
                SqlCommand com = new SqlCommand("select * from EmlakTip", con);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ListItem li = new ListItem(dr["EmlakTipAd"].ToString(), dr["EmlakTipId"].ToString());
                    lic.Add(li);
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
            return lic;
        }
        public List<emlakTip> emlakTipGetirTum()
        {
            List<emlakTip> emlakTipler = new List<emlakTip>();
            try
            {
                SqlCommand com = new SqlCommand("select * from EmlakTip  order by EmlakTipAd", con);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    emlakTip et = new emlakTip();
                    et.EmlakTipId = Convert.ToInt32(dr["EmlakTipId"]);
                    et.EmlakTipAd = dr["EmlakTipAd"].ToString();
                    emlakTipler.Add(et);
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
            return emlakTipler;
        }
        public emlakTip emlakTipGetirId(int eTipId)
        {
            emlakTip et = new emlakTip();
            try
            {
                SqlCommand com = new SqlCommand("select * from EmlakTip where EmlakTipId=@etip", con);
                com.Parameters.AddWithValue("@etip",eTipId);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    et.EmlakTipId = Convert.ToInt32(dr["EmlakTipId"]);
                    et.EmlakTipAd = dr["EmlakTipAd"].ToString();
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
            return et;
        }
        public int emlakTipAdet(int id)
        {
            int adet = 0;
            try
            {
                SqlCommand com = new SqlCommand("select count(*) from Emlak where EmlakTipId=@id", con);
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
