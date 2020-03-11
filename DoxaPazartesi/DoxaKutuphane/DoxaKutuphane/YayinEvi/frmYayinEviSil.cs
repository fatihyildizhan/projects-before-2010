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
    public partial class frmYayinEviSil : Form
    {
        public frmYayinEviSil()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.;database=DoxaKutuphane;trusted_connection=true");
        private void frmYayinEviSil_Load(object sender, EventArgs e)
        {
            ComboDoldur();
        }
        public void ComboDoldur()
        {
            cmbYayinEvSil.Items.Clear();
            SqlCommand com = new SqlCommand("select * from YayinEvi",con);
            DoxaMethodsDAL.Facade.Connection.ConOpen(con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                DoxaKutuphaneDAL.Entity.YayinEvi y = new DoxaKutuphaneDAL.Entity.YayinEvi();
                y.YayinEviId = Convert.ToInt32(dr["YayinEviId"]);
                y.YayinEviAd = dr["YayinEviAd"].ToString();
                y.YayinEviAdres=Convert.ToString(dr["Adres"]);
                cmbYayinEvSil.Items.Add(y);
            }
            
            DoxaMethodsDAL.Facade.Connection.ConClose(con);
            dr.Close();
        }

        private void btnYayinEvSil_Click(object sender, EventArgs e)
        {
            DoxaKutuphaneDAL.Entity.YayinEvi y =(DoxaKutuphaneDAL.Entity.YayinEvi)cmbYayinEvSil.SelectedItem;
            bool kontrol=DoxaKutuphaneDAL.Facade.YayinEvi.YayinEviSil(y.YayinEviId);
            if (kontrol)
            { 
                MessageBox.Show("Yayın Evi Başarıyla silinmiştir"); 
            }
            else
            {
                MessageBox.Show("Yayın Evi Silinemedi!");
            }
            ComboDoldur();
            cmbYayinEvSil.Text = "";
        }
    }
}
