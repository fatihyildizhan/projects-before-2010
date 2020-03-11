using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace BussinessLayer.EmlakTip
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
                    ListItem li = new ListItem(dr["EmlakTip"].ToString(), dr["EmlakTipId"].ToString());
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
                SqlCommand com = new SqlCommand("select * from EmlakTip", con);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    emlakTip et = new emlakTip();
                    et.EmlakTipId = Convert.ToInt32(dr["EmlakTipId"]);
                    et.EmlakTipIsim = dr["EmlakTip"].ToString();
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
    }
}
