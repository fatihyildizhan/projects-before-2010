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
    public partial class Form1 : Form
    {
        int x;
               public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x -= 1;
            label1.Text = x.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Interval = Convert.ToInt32(comboBox1.SelectedItem);
                x = Convert.ToInt32(textBox1.Text);
                timer1.Start();
            }
            catch
            {
                MessageBox.Show("insan ol !");
            }
            finally
            {
                MessageBox.Show("by Design");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
