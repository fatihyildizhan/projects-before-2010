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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnWorkerCalistir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20000; i++)
            {
                this.Text = i.ToString();
            }
        }

        private void btnArkaPlanDegistir_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        Color[] clr = new Color[] { Color.AliceBlue, Color.AntiqueWhite, Color.Red, Color.Plum, Color.Blue, Color.CadetBlue, Color.DeepSkyBlue, Color.Indigo, Color.Peru };
        private void btnMbox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BackGroundWorker Olmayınca Herşey Beklemek Zorunda... Mesajınız: " + txtMesaj.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            this.BackColor = clr[r.Next(0, clr.Length)];
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
