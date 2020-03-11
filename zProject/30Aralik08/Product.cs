using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;

namespace _30Aralik08
{
   public class Product
    {
        public Product()
        {

        }


        int productID;

        public int ProductID
        {
            get { return productID; }
            //set { productID = value; }
        }

        string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        string productDesc;

        public string ProductDesc
        {
            get { return productDesc; }
            set { productDesc = value; }
        }

        decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        int categID;

        public int CategID
        {
            get { return categID; }
            set { categID = value; }
        }

        string categoryName;

        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }

        public static ArrayList GetAllProducts()
        {
            SqlConnection con = new SqlConnection("Server = .; Database = DoxaBilgisayar; trusted_Connection = Yes");
            ConOpen(con);
            SqlCommand cmd = new SqlCommand("select P.ProductID, P.ProductName, P.ProductDesc, P.Price,C.CategoryID,C.CategoryName from Product P inner join Category C on P.CategoryID = C.CategoryID",con);
            SqlDataReader rdr = cmd.ExecuteReader();

            ArrayList myResultList = new ArrayList();

            while (rdr.Read())
            {
                Product prd = new Product();
                prd.productID = Convert.ToInt32(rdr[0]);
                prd.productName = rdr[1].ToString();
                prd.productDesc = rdr[2].ToString();
                prd.price = Convert.ToDecimal(rdr[3]);
                prd.categID = Convert.ToInt32(rdr[4]);
                prd.categoryName = rdr[5].ToString();

                myResultList.Add(prd);
            }
            return myResultList;
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


    }
}
