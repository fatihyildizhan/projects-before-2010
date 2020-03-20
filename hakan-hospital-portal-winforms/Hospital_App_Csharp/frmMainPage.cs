using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital_App_Csharp
{
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // this , seçili olan formu ifade eder.
            // Burada frmHomePage'i ifade eder.
            this.Close();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            // frmPatien sınıfından yeni bir değişken oluşturduk.
            frmPatient patientPage = new frmPatient();
            
            // Show(); ile sayfa açtığımızda ana ekrana ulaşabiliriz.
            // patientPage.Show();

            // ShowDialog(); ile sayfa açıldığında ana ekrana ulaşamayız.
            patientPage.ShowDialog();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            frmDoctor doctorPage = new frmDoctor();
            doctorPage.ShowDialog();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            frmRecord recordPage = new frmRecord();
            recordPage.ShowDialog();
        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("Hastana Otomasyon Programı Açılıyor...");
        }
    }
}
