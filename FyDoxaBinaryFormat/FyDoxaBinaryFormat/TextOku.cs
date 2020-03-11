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
    public partial class TextOku : Form
    {
        public TextOku()
        {
            InitializeComponent();
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\FyDoxa\Documents\FyDoxaDenemeKlasoru\Dene.FyDoxa", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            txtText.Text=bf.Deserialize(fs).ToString();
            fs.Close();
        }
    }
}
