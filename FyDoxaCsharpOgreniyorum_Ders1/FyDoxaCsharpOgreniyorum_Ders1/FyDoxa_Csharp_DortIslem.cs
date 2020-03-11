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
    public partial class FyDoxa_Csharp_DortIslem : Form
    {
        public FyDoxa_Csharp_DortIslem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sonuc = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
            MessageBox.Show(sonuc.ToString());
        }
    }
}
