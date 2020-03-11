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
    public partial class FyDoxa_Csharp_HelloWorld : Form
    {
        public FyDoxa_Csharp_HelloWorld()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya");
        }
    }
}
