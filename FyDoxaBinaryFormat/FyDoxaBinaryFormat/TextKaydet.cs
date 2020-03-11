using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FyDoxaBinaryFormat
{
    public partial class TextKaydet : Form
    {
        public TextKaydet()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\FyDoxa\Documents\FyDoxaDenemeKlasoru\Dene.FyDoxa", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, txtText.Text);
            fs.Close();
        }
    }
}
