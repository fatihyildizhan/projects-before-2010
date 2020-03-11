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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1;

            try
            {
                sayi1 = Convert.ToInt32(textBox1.Text);

                if (sayi1 < 100)
                {
                    MessageBox.Show("sayi küçük");
                }
                else if (sayi1 > 100)
                {
                    MessageBox.Show("sayi büyük");
                }
                else
                {
                    MessageBox.Show("sayi eşit");
                }
            }
            catch
            {
                MessageBox.Show("insan ol");
            }
            




        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
