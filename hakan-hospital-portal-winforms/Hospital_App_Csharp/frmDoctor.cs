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
    public partial class frmDoctor : Form
    {
        public frmDoctor()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*
            try
            {
              Buraya hata çıkarabilecek kod satırları yazılır.
            }
            catch (Exception)
            {
                
                throw;
             
             Hata oluşursa kod , hata verdiği yerden atlayarak, catch bloğuna düşer.
             Ve kesinlikle kaldığı yerden devam ETMEZ.
             * 
             
             * Burada oluşan hata kullanıcılara gösterilebilir. Veya uyarı verilebilir: Hata oldu gibi...
             
            }
            */

            try
            {
                // DBML uzantılı Linq nesnesinden veritabanının kopyasını oluşturduk. Yeni bir "instance" oluşturduk.
                // using içinde yazmamızın sebebi ise, her kullanıcının işlemi bittikten sonra ram'den gereksiz bilgilerin
                // otomatik olarak silinmesi.
                using (Hospital_DBDataContext db = new Hospital_DBDataContext())
                {
                    // Varolan Doctor sınıfından yeni bir Doctor nesnesi oluşturduk
                    // Ekrandan/kullanıcıdan aldığımız verilerle doctor sınıfından ürettiğimiz "newDoc" değişkenimizin
                    // bilgilerini güncelledik.
                    Doctor newDoc = new Doctor();
                    newDoc.DoctorGender = rbMale.Checked;
                    newDoc.DoctorName = txtName.Text;
                    newDoc.DoctorPhone = txtPhone.Text;
                    newDoc.DoctorProf = txtProfession.Text;
                    newDoc.DoctorSurname = txtSurname.Text;

                    // oluşturduğumuz değişkeni, kopya veritabanımıza ekledik.
                    // "db" isimle kopya veritabanımıza "newDoc" isimli Doctor sınıfından olan değişkenimizi ekledik.
                    db.Doctors.InsertOnSubmit(newDoc);

                    // güncel verinin (yeni doktor eklenmiş veritabanının "db"'nin) gerçek veritabanına değişikliklerinin uygulanması.
                    // yapılan tüm değişiklikler MS Sql 2008 'deki veritabanına yazılır.
                    db.SubmitChanges();
                }
                // Eğer buraya kadar bir sorun olmamışsa, doktor başarıyla eklenmiş demektir.
                // kullanıcıya bilgilendirme mesaj gösterilir.
                MessageBox.Show("Doctor Successfuly Added.");
            }
            // Eğer bir hata oluşursa bu blok çalışır.
            catch (Exception myExName)
            {
                // Bir sorun oluştuğunda kullanıcıya aşağıdaki satır ile, oluşan hatanın mesajı gösterilir.
                // böylece program çalışmaya devam eder ancak , yapılan son işlem gerçekleştirilmez.
                MessageBox.Show("Error: " + myExName.Message);
            }
        }

        // Sayfa oluşturulmadan hemen önce burası çalışır.
        private void frmDoctor_Load(object sender, EventArgs e)
        {
            // Burada herhangi bir işlem yapılabilir.
        }

        // Get Doctor Butonuna tıklandığında bu kod bloğu çalışır.
        // Veritabanındaki tüm doktorlar ListView'ın içine eklenir.
        private void btnGetDoctors_Click(object sender, EventArgs e)
        {
            // Her butona tıklandığında aynı verilerin defalarca kez yazılmasını önlemek için
            // yeni verileri eklemeden önce eskileri silinir.
            lstDoctor.Items.Clear();
            using (Hospital_DBDataContext db = new Hospital_DBDataContext())
            {
                // foreach , for döngüsü ile benzerdir.
                // Doctor => array'in içindeki verilerin tipini belirtir.
                // item => foreach bloğu içerisinde kullanacağımız değişken ismidir. İstediğimizi yazabiliriz.
                // in => içinde döneceğimizi belirtir
                // in'den sonraki yere, hangi array içerisinde döneceğimizi yazıyoruz.
                // db.Doctors.ToList() => veritabanının kopyası olan "db"'nin içindeki "Doctor" tablosunun
                // Array halini getirir.
                // ToList() => toplu verileri array'e dönüştürür.
                foreach (Doctor item in db.Doctors.ToList())
                {
                    // ListView bizden ListViewItem tipinde bir nesne ister.
                    // Tag özelliğine her türde veri verebiliriz. int, string, array, Button herşey...
                    // ListView'ın ilk kolonu "Text" 'dir
                    // Sonraki her kolonu SubItems'dır.
                    
                    ListViewItem li = new ListViewItem();
                    // ListView'ın Tag özelliğine şuandki doktorun tüm bilgilerini ekliyoruz.
                    li.Tag = item;
                    li.Text = item.DoctorName;
                    li.SubItems.Add(item.DoctorSurname);
                    li.SubItems.Add(item.DoctorPhone);

                    // ListViewItem'ı oluşturduktan sonra, ekrandaki ListView'ın item'larına ekliyoruz.
                    lstDoctor.Items.Add(li);
                }
            }
        }

        // ListView'dan satır seçtiğimizde bu kod bloğu çalışır.
        private void lstDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Eğer ListView'ın seçili satırlarının sayısı 0'dan büyükse çalışır.
            // Bu if bloğu hata alınmaması için yazılmıştır.
            if (((ListView)sender).SelectedItems.Count > 0)
            {
                // ListView'dan seçtiğimiz satırdaki bilgilerden "Doctor" sınıfında bir değişken oluşturuyoruz.
                // sender bize ListView döndürür.
                // bu ListView'u Doctor sınıfına "cast / dönüştürmek" çeviririz.
                // Seçili olan satırdaki doktorun tüm bilgilerini alıyoruz / aktarıyoruz.
                // Bu bilgilerden yeni bir "newDoc" isimle dğeişken oluşturuyoruz.
                Doctor newDoc = (Doctor)((ListView)sender).SelectedItems[0].Tag;

                // Sonra, bu bilgileri ekrandaki ilgili yerlere gösteriyoruz.
                txtDoctorInfoName.Text = newDoc.DoctorName;
                txtDoctorInfoPhone.Text = newDoc.DoctorPhone;
                txtDoctorInfoProf.Text = newDoc.DoctorProf;
                txtDoctorInfoSurname.Text = newDoc.DoctorSurname;

                // Eğer DoctorGender True ise Male, değil ise Female'ı seçiyoruz.
                if (newDoc.DoctorGender)
                {
                    rbInfoMale.Checked = true;
                }
                else
                {
                    rbInfoFemale.Checked = true;
                }
            }
        }
    }
}
