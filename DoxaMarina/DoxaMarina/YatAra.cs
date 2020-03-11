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
    public partial class YatAra : Form
    {
        public YatAra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (Yat y in Yat.yatListesi)
            {
                ListViewItem li = new ListViewItem();
                li.Text = y.YatAdı;
                li.SubItems.Add(y.YatBoyu.ToString());
                li.SubItems.Add(y.KabinSayisi.ToString());
                listView1.Items.Add(li);
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            Yat y = new Yat();
            

        }

        private void tsmKabinGoster_Click(object sender, EventArgs e)
        {
            KabinGoster kg = new KabinGoster();
            kg.Show();
        }

        private void tsmPlanGoster_Click(object sender, EventArgs e)
        {
            PlanGoster pg = new PlanGoster();
            pg.Show();
        }
    }
}
