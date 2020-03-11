using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoxaKutuphane.Kitap
{
    public partial class frmKitapAraDinamik : Form
    {
        public frmKitapAraDinamik()
        {
            InitializeComponent();
        }

        // SqlConnection Which From ADO.NET
        SqlConnection con = new SqlConnection("server=.;database=DoxaKutuphane;trusted_connection=true;");
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            // SQLCommand Which From ADO.NET
            SqlCommand com = new SqlCommand("TumKitaplariGetir",con);
            
            com.CommandType=CommandType.StoredProcedure;
            DoxaMethodsDAL.Facade.Connection.ConOpen(con);
            // SQLDataReader Which From ADO.NET
            SqlDataReader dr = com.ExecuteReader();


            while(dr.Read())
            {   
                string ktpAd=dr["Kitap Adı"].ToString();
                string ktgrAd=dr["Kategori Adı"].ToString();
                string yazar=dr["Yazar"].ToString();
                string yynevAd=dr["Yayın Evi Adı"].ToString();
                if(txtKtpAdDnmk.Text=="")
                {
                    listView1.Items.Clear();
                }
                else if (ktpAd.StartsWith(txtKtpAdDnmk.Text))
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = ktpAd;
                    li.SubItems.Add(ktgrAd);
                    li.SubItems.Add(yazar);
                    li.SubItems.Add(yynevAd);
                    listView1.Items.Add(li);
                }
            }
            dr.Close();
            DoxaMethodsDAL.Facade.Connection.ConClose(con);
            label2.Text = listView1.Items.Count.ToString();
        }

        private void txtKtgrDnmk_TextChanged(object sender, EventArgs e)
        {
             listView1.Items.Clear();
            SqlCommand com = new SqlCommand("TumKitaplariGetir",con);
            com.CommandType=CommandType.StoredProcedure;
            
            DoxaMethodsDAL.Facade.Connection.ConOpen(con);
            SqlDataReader dr = com.ExecuteReader();

            while(dr.Read())
            {   
                string ktpAd=dr["Kitap Adı"].ToString();
                string ktgrAd=dr["Kategori Adı"].ToString();
                string yazar=dr["Yazar"].ToString();
                string yynevAd=dr["Yayın Evi Adı"].ToString();
                
                if(txtKtgrDnmk.Text=="")
                {
                    listView1.Items.Clear();
                }
                else if (ktgrAd.StartsWith(txtKtgrDnmk.Text))
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = ktpAd;
                    li.SubItems.Add(ktgrAd);
                    li.SubItems.Add(yazar);
                    li.SubItems.Add(yynevAd);
                    listView1.Items.Add(li);
                }
            }
            dr.Close();
            DoxaMethodsDAL.Facade.Connection.ConClose(con); 
            label2.Text = listView1.Items.Count.ToString();
        }

        private void txtYzrDnmk_TextChanged(object sender, EventArgs e)
        {
             listView1.Items.Clear();
            SqlCommand com = new SqlCommand("TumKitaplariGetir",con);
            com.CommandType=CommandType.StoredProcedure;
            
            DoxaMethodsDAL.Facade.Connection.ConOpen(con);
            SqlDataReader dr = com.ExecuteReader();

            while(dr.Read())
            {   
                string ktpAd=dr["Kitap Adı"].ToString();
                string ktgrAd=dr["Kategori Adı"].ToString();
                string yazar=dr["Yazar"].ToString();
                string yynevAd=dr["Yayın Evi Adı"].ToString();
                
                if(txtYzrDnmk.Text=="")
                {
                    listView1.Items.Clear();
                }
                else if (yazar.StartsWith(txtYzrDnmk.Text))
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = ktpAd;
                    li.SubItems.Add(ktgrAd);
                    li.SubItems.Add(yazar);
                    li.SubItems.Add(yynevAd);
                    listView1.Items.Add(li);
                }
            }
            dr.Close();
            DoxaMethodsDAL.Facade.Connection.ConClose(con); 
            label2.Text = listView1.Items.Count.ToString();
        }

        private void txtYynEviDnmk_TextChanged(object sender, EventArgs e)
        {
             listView1.Items.Clear();
            SqlCommand com = new SqlCommand("TumKitaplariGetir",con);
            com.CommandType=CommandType.StoredProcedure;
            
            DoxaMethodsDAL.Facade.Connection.ConOpen(con);
            SqlDataReader dr = com.ExecuteReader();

            while(dr.Read())
            {   
                string ktpAd=dr["Kitap Adı"].ToString();
                string ktgrAd=dr["Kategori Adı"].ToString();
                string yazar=dr["Yazar"].ToString();
                string yynevAd=dr["Yayın Evi Adı"].ToString();
                
                if(txtYynEviDnmk.Text=="")
                {
                    listView1.Items.Clear();
                }
                else if (yynevAd.StartsWith(txtYynEviDnmk.Text))
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = ktpAd;
                    li.SubItems.Add(ktgrAd);
                    li.SubItems.Add(yazar);
                    li.SubItems.Add(yynevAd);
                    listView1.Items.Add(li);
                }
            }
            dr.Close();
            DoxaMethodsDAL.Facade.Connection.ConClose(con);
            label2.Text = listView1.Items.Count.ToString();
        }
        public void temizle()
        {
            txtKtgrDnmk.Clear();
            txtKtpAdDnmk.Clear();
            txtYynEviDnmk.Clear();
            txtYzrDnmk.Clear();
        }
        private void frmKitapAraDinamik_Load(object sender, EventArgs e)
        {
            txtKtgrDnmk.ReadOnly = true;
            txtKtpAdDnmk.ReadOnly = true;
            txtYynEviDnmk.ReadOnly = true;
            txtYzrDnmk.ReadOnly = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtKtgrDnmk.ReadOnly = true;
            txtKtpAdDnmk.ReadOnly = false;
            txtYynEviDnmk.ReadOnly = true;
            txtYzrDnmk.ReadOnly = true;
            txtKtpAdDnmk.Focus();
            temizle();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtKtgrDnmk.ReadOnly = false;
            txtKtpAdDnmk.ReadOnly = true;
            txtYynEviDnmk.ReadOnly = true;
            txtYzrDnmk.ReadOnly = true;
            txtKtgrDnmk.Focus();
            temizle();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtKtgrDnmk.ReadOnly = true;
            txtKtpAdDnmk.ReadOnly = true;
            txtYynEviDnmk.ReadOnly = true;
            txtYzrDnmk.ReadOnly = false;
            txtYzrDnmk.Focus();
            temizle();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtKtgrDnmk.ReadOnly = true;
            txtKtpAdDnmk.ReadOnly = true;
            txtYynEviDnmk.ReadOnly = false;
            txtYzrDnmk.ReadOnly = true;
            txtYynEviDnmk.Focus();
            temizle();
        }     
    }
}
