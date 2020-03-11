using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace FyDoxaToplanti
{
    public static class ConState
    {
        public static SqlConnection con = new SqlConnection("server=.;database=.;uid=.;pwd=.");

        public static void conOpen()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void conClose()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
