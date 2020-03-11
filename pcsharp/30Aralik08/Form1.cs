using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _30Aralik08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UrunDoldur();

        }

        private void UrunDoldur()
        {
            listView1.Items.Clear();
          

            foreach (object obj in Product.GetAllProducts())
            {
                Product prd = (Product)obj;
                ListViewItem li = new ListViewItem();
                li.Tag = prd;
                li.Text = prd.ProductID.ToString();
                li.SubItems.Add(prd.ProductName);
                li.SubItems.Add(prd.ProductDesc);
                li.SubItems.Add(prd.Price.ToString());
                li.SubItems.Add(prd.CategoryName);
                listView1.Items.Add(li);
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            UrunGuncelle urn = new UrunGuncelle((listView1.SelectedItems[0].Tag as Product));
            urn.ShowDialog();
            UrunDoldur();
        }
    }
}
