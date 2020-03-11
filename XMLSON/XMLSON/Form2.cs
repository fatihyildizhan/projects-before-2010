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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server=.;database=northwind;uid=sa;pwd=123;MultipleActiveResultSets=true");
       
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand comCalisan = new SqlCommand("select employeeId,firstname from employees",con);

            SqlCommand comSiparis = new SqlCommand("select orderId from orders where employeeId=@id", con);

            con.Open();

            SqlDataReader drCalisan = comCalisan.ExecuteReader();

            while (drCalisan.Read())
            {
            
                listBox1.Items.Add(drCalisan["firstname"].ToString());
                listBox1.Items.Add("-----");

                comSiparis.Parameters.AddWithValue("@id", Convert.ToInt32(drCalisan["EmployeeID"]));
                
                SqlDataReader drSiparis = comSiparis.ExecuteReader();
                while (drSiparis.Read())
                {
                    listBox1.Items.Add(drSiparis["OrderId"].ToString());
                }

                drSiparis.Close();



                comSiparis.Parameters.Clear();

            
            }
            drCalisan.Close();
        

            con.Close();




        }
    }
}
