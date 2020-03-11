using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using System.IO;
using System.Data.SqlClient;

namespace DoxaSMO
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Server svr = new Server(".");
        private void btnProc_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();


            foreach (Table tbl in svr.Databases["DoxaTours"].Tables)
            {
                string parametre = "";
                sb.AppendLine("\n\n--------" + tbl.Name + " Tablosuna Ekle Proc'u --------");
                sb.AppendLine("create proc " + tbl.Name + "Ekle");
                string sorgu = "insert into "+tbl.Name + " values(";

                foreach (Column clm in tbl.Columns)
                {
                    if (clm.Identity == false)
                    {
                        if (clm.DataType.SqlDataType == SqlDataType.Int || clm.DataType.SqlDataType == SqlDataType.DateTime)
                        {
                            parametre += "@" + clm.Name + " " + clm.DataType.SqlDataType.ToString() + ",\n";
                        }
                        else
                        {
                            parametre += "@" + clm.Name + " " + clm.DataType.SqlDataType.ToString() + " (" + clm.DataType.MaximumLength.ToString() + "),\n";
                        }
                        sorgu += "@" + clm.Name + ",";
                    }
                }
                parametre = parametre.Remove(parametre.Length - 2, 1);
                parametre += "as\n";

                sorgu = sorgu.Remove(sorgu.Length - 1, 1);

                sorgu += ")";

                sb.Append(parametre);
                sb.Append(sorgu);
           
                rTxtProc.Text = sb.ToString();
            }
        }

        private void btnEntity_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();

            foreach (Table t in svr.Databases["DoxaTours"].Tables)
            {
                sb.AppendLine("using System;");
                sb.AppendLine("using System.Collections.Generic;");
                sb.AppendLine("using System.Text;");
                sb.AppendLine("namespace Entity.Proje");
                sb.AppendLine("{");

                sb.AppendLine("public class " + t.Name);
                sb.AppendLine("{");

                foreach (Column c in t.Columns)
                {
                    sb.AppendLine(TipDonustur(c.DataType.SqlDataType) + " _" + c.Name + ";");
                    sb.AppendLine("public " + TipDonustur(c.DataType.SqlDataType) + " " + c.Name);
                    sb.AppendLine("{");
                    sb.AppendLine("get{ return _" + c.Name + ";}");
                    sb.AppendLine("set { _" + c.Name + "=value;}");

                    sb.AppendLine("}");


                }
                sb.AppendLine("}");
                sb.AppendLine("}");


                sb.AppendLine("********************************");

                StreamWriter sw = new StreamWriter("C:\\Entiti\\" + t.Name + ".cs");
                sw.WriteLine(sb.ToString());
                sw.Close();
            }

        }
        public string TipDonustur(SqlDataType tip)
        {
            string ctip = "";
            switch (tip)
            {
                case SqlDataType.Decimal:
                case SqlDataType.Float:
                case SqlDataType.Money:
                    ctip = "decimal";
                    break;
                case SqlDataType.BigInt:
                case SqlDataType.TinyInt:
                case SqlDataType.Int:
                    ctip = "int";
                    break;
                case SqlDataType.Char:
                case SqlDataType.NChar:
                case SqlDataType.NText:
                case SqlDataType.NVarChar:
                case SqlDataType.VarChar:
                case SqlDataType.VarCharMax:
                case SqlDataType.NVarCharMax:
                    ctip = "string";
                    break;
            }
            return ctip;
        }
    }
}
