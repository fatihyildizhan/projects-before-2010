using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FyDoxaBackGroundWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100000; i++)
            {
                this.Text = i.ToString();
            }
        }

        private void btnMbox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BackGroundWorker ile Aynı Anda Birçok İşlem Yapabilirsiniz... Mesajınız: "+txtMesaj.Text);
        }

        private void btnArkaPlanDegistir_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnWorkerCalistir_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        Color[] clr = new Color[]{ Color.AliceBlue, Color.AntiqueWhite,Color.Red,Color.Plum,Color.Blue,Color.CadetBlue,Color.DeepSkyBlue,Color.Indigo,Color.Peru };

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            this.BackColor = clr[r.Next(0, clr.Length)];
        }

    }
}
