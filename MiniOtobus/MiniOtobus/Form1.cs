using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiniOtobus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void otobusIşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOtobusIslem f = new frmOtobusIslem();
            f.ShowDialog();
        }

        private void seferIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeferIslem s = new frmSeferIslem();
            s.ShowDialog();
        }
    }
}
