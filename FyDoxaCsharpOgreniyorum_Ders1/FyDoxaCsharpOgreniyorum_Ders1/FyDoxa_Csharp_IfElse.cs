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
    public partial class FyDoxa_Csharp_IfElse : Form
    {
        public FyDoxa_Csharp_IfElse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < numericUpDown2.Value)
            {
                MessageBox.Show("Soldaki Değer Büyüktür!");
            }
            else if (numericUpDown1.Value > numericUpDown2.Value)
            {
                MessageBox.Show("Sağdaki Değer Büyüktür!");
            }
            else
            {
                MessageBox.Show("İki Değer Eşittir!");
            }
        }
    }
}
