using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;

namespace _30Aralik08
{
    class Category
    {
        public Category()
        {

        }


        int categoryID;

        public int CategoryID
        {
            get { return categoryID; }
           // set { categoryID = value; }
            // ReadOnly
        }

        string categoryAdi;

        public string CategoryAdi
        {
            get { return categoryAdi; }
            set { categoryAdi = value; }
        }


        string categoryDesc;

        public string CategoryDesc
        {
            get { return categoryDesc; }
            set { categoryDesc = value; }
        }

        public static ArrayList GetAllCategories()
        {
            SqlConnection con = new SqlConnection("Server = .; Database = DoxaBilgisayar; trusted_Connection = Yes");
            ConOpen(con);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Category";
           
           
            SqlDataReader rdr = cmd.ExecuteReader();
            ArrayList ResultList = new ArrayList();
            while (rdr.Read())
            {
                Category ctg = new Category();
                ctg.categoryID = Convert.ToInt32(rdr[0]);
                ctg.categoryAdi = rdr[1].ToString();
                ctg.categoryDesc = rdr[2].ToString();
                ResultList.Add(ctg);
            }
            return ResultList;
        }

        private static void ConOpen(SqlConnection con)
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        
        private static void ConClose(SqlConnection con)
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        //public override string ToString()
        //{
        //        return this.categoryAdi;
        //}

    }
}
