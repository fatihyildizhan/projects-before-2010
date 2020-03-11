using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoxaKutuphane
{
    public partial class frmLoad : Form
    {
        public frmLoad()
        {
            InitializeComponent();
        }
        int artisOrani = 0;
        int SuAnkiDeger=0;
        public static frmGiris frmGir = new frmGiris();
        private void timer1_Tick(object sender, EventArgs e)
        {
            artisOrani += 1;
            progressBar1.Step = artisOrani;
            progressBar1.PerformStep();
            SuAnkiDeger = progressBar1.Value;

            if(SuAnkiDeger>=100)
            {
                timer1.Stop();
                this.Visible = false;
                frmGir.ShowDialog();
                progressBar1.Value = 0;
            }
            else if (SuAnkiDeger<=20&&SuAnkiDeger>=0)
            {
                label1.Text = "Loading Doxa Library ...";
            }
            else if(SuAnkiDeger<=40&&SuAnkiDeger>=21)
            {
                label1.Text = "Initializing ...";
            }
            else if(SuAnkiDeger<=70&&SuAnkiDeger>=41)
            {
                label1.Text = "Loading System Files ...";
            }
            else if (SuAnkiDeger <= 99 && SuAnkiDeger >= 71)
            {
                label1.Text = "Completing the Doxa Library ...";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            progressBar1.Value = 0;
            artisOrani  = 0;
            SuAnkiDeger = 0;
            timer1.Start();
        }
    }
}
