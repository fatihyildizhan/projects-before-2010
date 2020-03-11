using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
/// <summary>
/// Summary description for ConnectionProvider
/// </summary>
internal class ConnectionProvider
{
     
    private ConnectionProvider()
    { }

    internal static SqlConnection GetConnection()
    {
        SqlConnection _instance = new SqlConnection();
        _instance.ConnectionString = ConnectionProvider.ConnectionString;
        return _instance;
    }

    internal static string GetConnectionString()
    {

        return ConnectionProvider.ConnectionString;
    }


    private static string ConnectionString
    {
        get
        {
            string theConnectionString = "";
            theConnectionString = WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
 
            return theConnectionString;

        }
    }
}