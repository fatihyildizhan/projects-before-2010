using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoxaMarina
{
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteri mstr = new Musteri();
            mstr.MusteriAd = txtMusteriAd.Text;
            mstr.MusteriSoyad = txtMusteriSoyad.Text;
            mstr.DogumTarih = dateTimePicker1.Value;
            
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {

        }

       
    }
}
