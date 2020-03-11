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
    public partial class ResimGoster : Form
    {
        public ResimGoster()
        {
            InitializeComponent();
        }

        private void btnResimGoster_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\FyDoxa\Documents\FyDoxaDenemeKlasoru\Resim.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            pictureBox1.Image = (Image)bf.Deserialize(fs);
            fs.Close();
        }
    }
}
