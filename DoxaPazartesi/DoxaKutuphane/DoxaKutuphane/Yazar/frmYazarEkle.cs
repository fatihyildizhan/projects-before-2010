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
    public partial class frmYazarEkle : Form
    {
        public frmYazarEkle()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.;database=DoxaKutuphane;trusted_connection=true");
        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            DoxaKutuphaneDAL.Entity.YayinEvi y =(DoxaKutuphaneDAL.Entity.YayinEvi)cmbYazarYynEvEkle.SelectedItem;
            bool kontrol = DoxaKutuphaneDAL.Facade.Yazar.YazarEkle(txtYazarAdEkle.Text, txtYazarSoyadEkle.Text, y.YayinEviId);
            if (kontrol)
            {
                MessageBox.Show("Mission is successful!");
            }
            else
            {
                MessageBox.Show("There is a Problem!");
            }

        }

        private void frmYazarEkle_Load(object sender, EventArgs e)
        {
            ComboDoldur();
        }
       public void ComboDoldur()
        {
            cmbYazarYynEvEkle.Items.Clear();
            SqlCommand com = new SqlCommand("select * from YayinEvi",con);
            DoxaMethodsDAL.Facade.Connection.ConOpen(con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                DoxaKutuphaneDAL.Entity.YayinEvi y = new DoxaKutuphaneDAL.Entity.YayinEvi();
                y.YayinEviId = Convert.ToInt32(dr["YayinEviId"]);
                y.YayinEviAd = dr["YayinEviAd"].ToString();
                y.YayinEviAdres=Convert.ToString(dr["Adres"]);
                cmbYazarYynEvEkle.Items.Add(y);
            }
            
            DoxaMethodsDAL.Facade.Connection.ConClose(con);
            dr.Close();
        }
    }
}
