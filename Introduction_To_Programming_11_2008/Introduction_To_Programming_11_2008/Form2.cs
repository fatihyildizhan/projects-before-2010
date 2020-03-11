using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Introduction_To_Programming_11_2008
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string timeUser=dateTimePicker1.Value.ToLongTimeString();


            
                dateTimePicker2.Value.ToLocalTime();
                long asd = dateTimePicker1.Value.ToFileTime();


        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
