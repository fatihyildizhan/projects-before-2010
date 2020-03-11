using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FyDoxaCsharpOgreniyorum_Ders1
{
    public partial class FyDoxa_Csharp_FormIslemleri : Form
    {
        public FyDoxa_Csharp_FormIslemleri()
        {
            InitializeComponent();
        }

        private void btnKirmizi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void btnMavi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void btnYesil_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btnSiyah_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void btnSaga_Click(object sender, EventArgs e)
        {
            this.Left += 10;
        }

        private void btnSola_Click(object sender, EventArgs e)
        {
            this.Left -= 10;
        }

        private void btnYukari_Click(object sender, EventArgs e)
        {
            this.Top -= 10;
        }

        private void btnAsagi_Click(object sender, EventArgs e)
        {
            this.Top += 10;
        }

        private void btnBaslikDegistir_Click(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
        }

        private void btnSaydamlikArtir_Click(object sender, EventArgs e)
        {
            this.Opacity += 0.1;
        }

        private void btnSaydamlikAzalt_Click(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
        }
    }
}
