using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ParmakYarisiApiDbLayer;

namespace parmakYarisi
{
    public partial class top10Form : Form
    {
        String[,] topTen;
        pyApiTop10 apiTopTen = new pyApiTop10();
        public top10Form()
        {
            InitializeComponent();
        }

        private void btnClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void top10Form_Load(object sender, EventArgs e)
        {
            topTen = apiTopTen.pyGetTopTen();
            fillLabels();
        }

        private void fillLabels()
        {
            lblName1.Text = topTen[0, 0];
            lblName2.Text = topTen[1, 0];
            lblName3.Text = topTen[2, 0];
            lblName4.Text = topTen[3, 0];
            lblName5.Text = topTen[4, 0];
            lblName6.Text = topTen[5, 0];
            lblName7.Text = topTen[6, 0];
            lblName8.Text = topTen[7, 0];
            lblName9.Text = topTen[8, 0];
            lblName10.Text = topTen[9, 0];

            lblXP1.Text = topTen[0, 1];
            lblXP2.Text = topTen[1, 1];
            lblXP3.Text = topTen[2, 1];
            lblXP4.Text = topTen[3, 1];
            lblXP5.Text = topTen[4, 1];
            lblXP6.Text = topTen[5, 1];
            lblXP7.Text = topTen[6, 1];
            lblXP8.Text = topTen[7, 1];
            lblXP9.Text = topTen[8, 1];
            lblXP10.Text = topTen[9, 1];
        }

        private void btnZiebart_Click(object sender, EventArgs e)
        {

        }
    }
}
