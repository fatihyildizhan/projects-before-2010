using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace SQLGirisDAL.Facade
{
   public static class SQLGiris
    {
       public static void SQLConnection()
         {
             SqlConnection con = new SqlConnection("server=.;database=Sinema;uid=sa;pwd=123");  
         }
    }
}
