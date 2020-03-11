using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace parmakYarisi
{
    public partial class lastGameForm : Form
    {
        public lastGameForm(int WPM, float accuracy, int gainingXP, Boolean flag)
        {
            InitializeComponent();

            if (flag)
            {
                lblInfo.Text = "Tebrikler yarışı bitirdiniz. Yarış detaylarınız aşağıdadır.";
                lblWPM.Text = WPM.ToString() + " WPM";
                lblAccuracy.Text = "% " + String.Format("{0:F1}", accuracy);
                lblXP.Text = gainingXP.ToString() + " XP";
            }
            else
            {
                lblInfo.Text = "Yarışı 3 dakikalık süre içinde bitiremediniz.";
                lblWPM.Text = "0 WPM";
                lblAccuracy.Text = "% 0";
                lblXP.Text = "0 XP";
            }
        }

        private void btnClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }
    }
}
