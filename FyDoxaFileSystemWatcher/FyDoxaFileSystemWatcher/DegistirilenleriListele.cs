using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FyDoxaFileSystemWatcher
{
    public partial class DegistirilenleriListele : Form
    {
        public DegistirilenleriListele()
        {
            InitializeComponent();
        }
        List<Rapor> degistirilenListesi = new List<Rapor>();
        int sayac = 0;
        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Rapor r = new Rapor();
            r.IslemTipi = "Değiştirildi";
            r.IslemAdi = e.Name;
            r.FullPath = e.FullPath;
            r.IslemTarihi = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
            degistirilenListesi.Add(r);
            sayac++;

            if (sayac == 3)
            {
                listView1.Items.Clear();
                foreach (Rapor rapor in degistirilenListesi)
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = rapor.IslemTipi;
                    li.SubItems.Add(rapor.IslemTarihi);
                    li.SubItems.Add(rapor.IslemAdi);
                    li.SubItems.Add(rapor.FullPath);
                    listView1.Items.Add(li);
                    sayac = 0;
                }
            }
        }
    }
}
