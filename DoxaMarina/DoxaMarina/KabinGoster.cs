using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoxaMarina
{
    public partial class KabinGoster : Form
    {
        public KabinGoster()
        {
            InitializeComponent();
        }

        private void KabinGoster_Load(object sender, EventArgs e)
        {
            int counter = 0;
            int left = 0;
            for (int i = 0; i < 20; i++)
            {
                if (i % 2!=0)
                {
                    Button b = new Button();
                    b.Text = "b1";
                    b.Top = counter;
                    b.Left = left;
                    b.BackColor = Color.Red;
                    this.panel1.Controls.Add(b);
                    left += 40;
                }
                else
                {
                    counter = counter + 20;
                }
                
            }
            
        }
    }
}
