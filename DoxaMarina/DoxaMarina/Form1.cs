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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yatEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            YatEkle yat = new YatEkle();
            yat.ShowDialog();
        }

        private void yatAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YatAra yat = new YatAra();
            yat.ShowDialog();
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriEkle musteri = new MusteriEkle();
            musteri.ShowDialog();
        }

        private void müşteriAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriAra musteri = new MusteriAra();
            musteri.ShowDialog();
        }
    }
}
