using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
namespace DoxaKutuphane.Kitap
{
    public partial class frmKitapAra : Form
    {
        public frmKitapAra()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.;database=DoxaKutuphane;trusted_connection=true;");
        public SqlDataAdapter da;
        public DataTable dt;
        private void frmKitapAra_Load(object sender, EventArgs e)
        {
            KitapDoldur();
            KategoriDoldur();
            YazarDoldur();
            YayinEviDoldur();
        }
        public void KitapDoldur()
        {
            cmbKitapAdAra.Items.Clear();
            SqlCommand com = new SqlCommand("select * from Kitap", con);
           
            DoxaMethodsDAL.Facade.Connection.ConOpen(con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                DoxaKutuphaneDAL.Entity.Kitap k = new DoxaKutuphaneDAL.Entity.Kitap();
                k.KitapId=Convert.ToInt32(dr["KitapId"]);
                k.KitapAd=dr["KitapAd"].ToString();
                cmbKitapAdAra.Items.Add(k);
            }
            DoxaMethodsDAL.Facade.Connection.ConClose(con);
            dr.Close();
        }
        public void KategoriDoldur()
        {
            cmbKategoriAra.Items.Clear();
            SqlCommand com = new SqlCommand("KategoriGetir", con);
            com.CommandType = CommandType.StoredProcedure;
            DoxaMethodsDAL.Facade.Connection.ConOpen(con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                DoxaKutuphaneDAL.Entity.Kategori k = new DoxaKutuphaneDAL.Entity.Kategori();
                k.KategoriId=Convert.ToInt32(dr["KategoriId"]);
                k.KategoriAd=dr["KategoriAd"].ToString();
                cmbKategoriAra.Items.Add(k);
            }
            DoxaMethodsDAL.Facade.Connection.ConClose(con);
            dr.Close();
        }
        public void YayinEviDoldur()
        {
            cmbYayinEviAra.Items.Clear();
            SqlCommand com = new SqlCommand("select * from YayinEvi",con);
            DoxaMethodsDAL.Facade.Connection.ConOpen(con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                DoxaKutuphaneDAL.Entity.YayinEvi y = new DoxaKutuphaneDAL.Entity.YayinEvi();
                y.YayinEviId = Convert.ToInt32(dr["YayinEviId"]);
                y.YayinEviAd = dr["YayinEviAd"].ToString();
                y.YayinEviAdres=Convert.ToString(dr["Adres"]);
                cmbYayinEviAra.Items.Add(y);
            }   
            DoxaMethodsDAL.Facade.Connection.ConClose(con);
            dr.Close();
        }
        public void YazarDoldur()
        {
            cmbYazarAdAra.Items.Clear();
            SqlCommand com = new SqlCommand("select * from Yazar", con); 
            DoxaMethodsDAL.Facade.Connection.ConOpen(con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                DoxaKutuphaneDAL.Entity.Yazar y = new DoxaKutuphaneDAL.Entity.Yazar();
                y.YazarId = Convert.ToInt32(dr["YazarId"]);
                y.Ad = dr["Ad"].ToString();
                y.Soyad = dr["Soyad"].ToString();
                cmbYazarAdAra.Items.Add(y);
            }
            DoxaMethodsDAL.Facade.Connection.ConClose(con);
            dr.Close();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            DoxaKutuphaneDAL.Entity.Kitap ktp =(DoxaKutuphaneDAL.Entity.Kitap)cmbKitapAdAra.SelectedItem;
            DoxaKutuphaneDAL.Entity.Kategori ktgr = (DoxaKutuphaneDAL.Entity.Kategori)cmbKategoriAra.SelectedItem;
            DoxaKutuphaneDAL.Entity.YayinEvi yyn= (DoxaKutuphaneDAL.Entity.YayinEvi)cmbYayinEviAra.SelectedItem;
            DoxaKutuphaneDAL.Entity.Yazar yzr = (DoxaKutuphaneDAL.Entity.Yazar)cmbYazarAdAra.SelectedItem;
            if(chkKategori.Checked&&chkKitapAd.Checked&&chkYayinEvi.Checked&&chkYazarAd.Checked)
            {
                dataGridView1.DataSource = DoxaKutuphaneDAL.Facade.Kitap.KitapGetir(ktp.KitapAd, ktgr.KategoriId, yzr.YazarId, yyn.YayinEviId);
            }
            else if(chkKitapAd.Checked&&chkKategori.Checked)
            {
                dataGridView1.DataSource = DoxaKutuphaneDAL.Facade.Kitap.KitapGetir(ktp.KitapAd, ktgr.KategoriId, 0, 0);
            }
            else if(chkKitapAd.Checked&&chkYayinEvi.Checked)
            {
                dataGridView1.DataSource = DoxaKutuphaneDAL.Facade.Kitap.KitapGetir(ktp.KitapAd, 0, 0, yyn.YayinEviId);
            }
            else if(chkKitapAd.Checked&&chkYazarAd.Checked)
            { 
            dataGridView1.DataSource = DoxaKutuphaneDAL.Facade.Kitap.KitapGetir(ktp.KitapAd, 0, yzr.YazarId, 0);
            }
            else if(chkKategori.Checked&&chkYayinEvi.Checked)
            { 
            dataGridView1.DataSource = DoxaKutuphaneDAL.Facade.Kitap.KitapGetir("", ktgr.KategoriId, 0, yyn.YayinEviId);
            }
            else if(chkKategori.Checked&&chkYazarAd.Checked)
            { 
            dataGridView1.DataSource = DoxaKutuphaneDAL.Facade.Kitap.KitapGetir("", ktgr.KategoriId, yzr.YazarId, 0);
            }
            else if(chkYayinEvi.Checked&&chkYazarAd.Checked)
            { 
            dataGridView1.DataSource = DoxaKutuphaneDAL.Facade.Kitap.KitapGetir("", 0, yzr.YazarId, yyn.YayinEviId);
            }
            else if (chkKategori.Checked)
            {
                dataGridView1.DataSource = DoxaKutuphaneDAL.Facade.Kitap.KitapGetir("", ktgr.KategoriId, 0, 0);
            }
            else if(chkKitapAd.Checked)
            { 
            dataGridView1.DataSource = DoxaKutuphaneDAL.Facade.Kitap.KitapGetir(ktp.KitapAd, 0, 0, 0);
            }
            else if(chkYayinEvi.Checked)
            { 
            dataGridView1.DataSource = DoxaKutuphaneDAL.Facade.Kitap.KitapGetir("", 0, 0, yyn.YayinEviId);
            }
            else if (chkYazarAd.Checked)
            {
                dataGridView1.DataSource = DoxaKutuphaneDAL.Facade.Kitap.KitapGetir("",0,yzr.YazarId, 0);
            }
            else
            {
                MessageBox.Show("Belanı Arıyosun BAK !!!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
