using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FyProject05
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BackColor =(Color) comboBox1.SelectedItem;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(Color.Red);
            comboBox1.Items.Add(Color.Yellow);
            comboBox1.Items.Add(Color.Fuchsia);
            comboBox1.Items.Add(Color.Aqua);
        }
    }
}
