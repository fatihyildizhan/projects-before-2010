using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Drawing;

/// <summary>
/// Summary description for SqlHelper
/// </summary>
public class SqlHelper
{
    public class SQLHelper
    {
        public static string GetDataColumnValue_String(DataTable TableName, int RowNum, string ColumnName)
        {
            string return_value = "";
            if (TableName.Rows[RowNum][ColumnName].ToString() != "")
            {
                return_value = TableName.Rows[RowNum][ColumnName].ToString();
            }
            return return_value;
        }

        public static int GetDataColumnValue_Int(DataTable TableName, int RowNum, string ColumnName)
        {
            return Convert.ToInt32(TableName.Rows[RowNum][ColumnName]);
        }

        public static Boolean GetDataColumnValue_Bool(DataTable TableName, int RowNum, string ColumnName)
        {
            return Convert.ToBoolean(TableName.Rows[RowNum][ColumnName]);
        }

        public static DateTime GetDataColumnValue_DateTime(DataTable TableName, int RowNum, string ColumnName)
        {
            DateTime return_value = DateTime.MinValue;
            if (TableName.Rows[RowNum][ColumnName].ToString() != "")
            {
                return_value = Convert.ToDateTime(TableName.Rows[RowNum][ColumnName]);
            }
            return return_value;
        }

        public static Color GetDataColumnValue_Color(DataTable TableName, int RowNum, string ColumnName)
        {
            Color return_value = Color.White;
            if (TableName.Rows[RowNum][ColumnName].ToString() != "")
            {
                return_value = Color.FromName(TableName.Rows[RowNum][ColumnName].ToString());
            }
            return return_value;
        }
    }
}
