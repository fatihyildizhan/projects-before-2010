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
    public partial class FyDoxa_Csharp_ButtonEventleri : Form
    {
        public FyDoxa_Csharp_ButtonEventleri()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tıklandım");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Üstüme Geldin!");
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Terkedildim!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Blue)
            {
                button3.BackColor = Color.Red;
            }
            else
            {
                button3.BackColor = Color.Blue;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(button3.Text=="button3")
            {
                button3.Text = "FyDoxa 2009";
            }
            else
            {
                button3.Text = "button3";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button3.ForeColor == Color.Bisque)
            {
                button3.ForeColor = Color.Aqua;
            }
            else
            {
                button3.ForeColor = Color.Bisque;
            }
        }

        private void button3_ForeColorChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Yazı Rengim Değişti.");
        }

        private void button3_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Text'im değişti.");
        }

        private void button3_BackColorChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Arkaplan Rengim Değişti");
        }
    }
}
