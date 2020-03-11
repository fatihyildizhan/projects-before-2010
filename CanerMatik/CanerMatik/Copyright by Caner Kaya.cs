using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CanerMatik
{
    public partial class Copyright_by_Caner_Kaya : Form
    {
        public Copyright_by_Caner_Kaya()
        {
            InitializeComponent();
        }

        public static long ticks;
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ticks != 0)
            {
                ticks-=10000000;
                TimeSpan tss = new TimeSpan(ticks);

                txtSayacDakika.Text = tss.Minutes.ToString();
                txtSayacSaat.Text = tss.Hours.ToString();
                txtSayacSaniye.Text = tss.Seconds.ToString();
            }
            else
            {
                MessageBox.Show("Test");
                timer1.Stop();
            }
        }

        private void Copyright_by_Caner_Kaya_Load(object sender, EventArgs e)
        {
            //Control.CheckForIllegalCrossThreadCalls = false;
           // backgroundWorker1.RunWorkerAsync();
            timer2.Start();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            this.Text = "Licensed by Caner Kaya. Tarih Ve Saat: " + DateTime.Now.ToString();
            
            //if (ticks != 0)
            //{
            //    ticks -= 100000;
            //    TimeSpan tss = new TimeSpan(ticks);

            //    txtSayacDakika.Text = tss.Minutes.ToString();
            //    txtSayacSaat.Text = tss.Hours.ToString();
            //    txtSayacSaniye.Text = tss.Seconds.ToString();
            //}
            //else
            //{
            //    timer1.Stop();
            //}
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Text ="Licensed by Caner Kaya. Tarih Ve Saat: "+DateTime.Now.ToString();
        }

        private void btnGeriSay_Click(object sender, EventArgs e)
        {
            TimeSpan ts = dateTimePicker3.Value.TimeOfDay;
            ticks = ts.Ticks;
            timer1.Start();
            // backgroundWorker1.RunWorkerAsync();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            TimeSpan sd = dateTimePicker1.Value.TimeOfDay;
            TimeSpan sd2 = dateTimePicker2.Value.TimeOfDay;

            TimeSpan toplamSaat = sd + sd2;

            txtGenelSaat.Text = toplamSaat.ToString();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            TimeSpan sd = dateTimePicker1.Value.TimeOfDay;

            TimeSpan sd2 = dateTimePicker2.Value.TimeOfDay;

            TimeSpan toplamSaat = sd - sd2;

            txtGenelSaat.Text = toplamSaat.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

       
    }
}
