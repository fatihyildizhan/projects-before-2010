using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoxaKutuphane
{
    public partial class frmYayinEviGuncelle : Form
    {
        public frmYayinEviGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.;database=DoxaKutuphane;trusted_connection=true;");
        private void frmYayinEviGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void btnYynEviListele_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlCommand com = new SqlCommand("select * from YayinEvi",con);

            DoxaMethodsDAL.Facade.Connection.ConOpen(con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem li = new ListViewItem();
                li.Text = Convert.ToString(dr["YayinEviId"]);
                li.SubItems.Add(dr["YayinEviAd"].ToString());
                li.SubItems.Add(Convert.ToString(dr["Adres"]));
                li.Tag = dr["YayinEviId"].ToString();
                listView1.Items.Add(li);
            }
            
            DoxaMethodsDAL.Facade.Connection.ConClose(con);
            dr.Close();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            ListViewItem li = listView1.SelectedItems[0];
            txtYynEvIdGnc.Text = li.Tag.ToString();
            txtYynEvAdGnc.Text = li.SubItems[1].Text;
            txtYynEvAdrsGnc.Text=li.SubItems[2].Text;
        }

        private void btnYayinEviGnc_Click(object sender, EventArgs e)
        {
            
           bool kontrol = DoxaKutuphaneDAL.Facade.YayinEvi.YayinEviGuncelle(Convert.ToInt32(txtYynEvIdGnc.Text), txtYynEvAdGnc.Text, txtYynEvAdrsGnc.Text);
           if (kontrol)
           {
               MessageBox.Show("Yayın Evi Bilgileri Güncellenmiştir...");
           }
           else
           {
               MessageBox.Show("Bilgiler Güncellenemedi!");
           }
        }
    }
}
