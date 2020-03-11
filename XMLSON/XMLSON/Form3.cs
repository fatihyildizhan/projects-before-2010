using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace XMLSON
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.;database=northwind;uid=sa;pwd=123");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand com1 = new SqlCommand("insert into employees(firstname,lastname) values('MGH','MGH')", con);


            SqlCommand com2 = new SqlCommand("insert into employees(firstname,lastname) values('DEF','sssss')", con);

            SqlTransaction trn=null;
            try
            {
                con.Open();

                trn = con.BeginTransaction();

                com1.Transaction = trn;
                com2.Transaction = trn;

                com1.ExecuteNonQuery();
                com2.ExecuteNonQuery();



                trn.Commit();
            }

            catch
            {
                trn.Rollback();
            }

            finally 
            {
                con.Close();
            }
        }
    }
}
