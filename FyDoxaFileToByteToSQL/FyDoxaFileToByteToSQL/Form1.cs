using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FyDoxaFileToByteToSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertToByteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertToByte cb = new ConvertToByte();
            cb.ShowDialog();
        }

        private void convertToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertToFile cf = new ConvertToFile();
            cf.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
