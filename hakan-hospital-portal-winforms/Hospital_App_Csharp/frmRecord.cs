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
    public partial class frmRecord : Form
    {
        public frmRecord()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                using (Hospital_DBDataContext db = new Hospital_DBDataContext())
                {
                    Record newRec = new Record();
                    newRec.DoctorID = Convert.ToInt32(cmbDoctorSelect.SelectedValue);
                    newRec.PatientID = Convert.ToInt32(cmbPatientSelect.SelectedValue);
                    newRec.RecordAttendent = Convert.ToInt32(nupAttendent.Value);
                    newRec.RecordCheckIn = dtpCheckIn.Value;
                    newRec.RecordCheckOut = dtpCheckOut.Value;
                    newRec.RecordCost = Convert.ToDecimal(txtCost.Text);
                    newRec.RecordDisease = txtDisease.Text;
                    newRec.RecordVisitor = Convert.ToInt32(nupVisitor.Value);

                    db.Records.InsertOnSubmit(newRec);
                    db.SubmitChanges();
                    MessageBox.Show("Record Successfully Created.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frmRecord_Load(object sender, EventArgs e)
        {
            using (Hospital_DBDataContext db = new Hospital_DBDataContext())
            {
                List<Doctor> myDoctors = new List<Doctor>();

                foreach (Doctor item in db.Doctors.ToList())
                {
                    item.DoctorName += " " + item.DoctorSurname;
                    myDoctors.Add(item);
                }

                cmbDoctorSelect.DataSource = myDoctors;
                cmbDoctorSelect.DisplayMember = "DoctorName";
                cmbDoctorSelect.ValueMember = "DoctorID";

                List<Patient> myPatientsArray = new List<Patient>();

                foreach (Patient myPatient in db.Patients.ToList())
                {
                    myPatient.PatientName += " " + myPatient.PatientSurname;
                    myPatientsArray.Add(myPatient);
                }

                cmbPatientSelect.DataSource = myPatientsArray;
                cmbPatientSelect.DisplayMember = "PatientName";
                cmbPatientSelect.ValueMember = "PatientID";
            }
        }

        // GetRecords butonuna tıklandığında çalışır.
        // Show Records Ekranı
        private void btnGetRecords_Click(object sender, EventArgs e)
        {
            // Ekranda aynı bilgilerin tekrarlanmaması için önceki bilgileri siliyoruz.
            lstRecords.Items.Clear();

            // Veritabanının kopyasını db isimli değişkene atıyoruz.
            // using içinde kullanıyoruzki performanslı olsun.
            // işimiz bittiğinde (verileri getirdiğimizde, yeni kayıt oluşturduğumuzda) bağlantıyı hemen kapatıyoruz.
            // gereksiz bilgileri Ram'den siliyoruz.
            using (Hospital_DBDataContext db = new Hospital_DBDataContext())
            {
                // LinQ ile join sorgusu  gerçekleştiriyoruz.
                // Veritabanındaki Record, Patient ve Doctor tablolarını Join ile bağlıyoruz.
                // Böylece bu 3 tablodaki bilgilere de ulaşabiliyoruz.
                // "var patientsDoctorsRecordsAll" sorgu sonucunda tüm bilgiler bu değişkende tutuluyor.
                // "var" değişken tipi, her türde veriyi tutabilir.
                // from'dan sonra sorgu içinde kullanacağımız 1.Tablo için değişken ismini KENDİMİZ belirliyoruz = > myRecords
                // sonra bu değişkene verilerin geleceği tabloyu "in TabloAdı" şeklinde yazıyoruz.
                // sonra, 1.tabloyu yani Records'u 2.Tablo ile yani myDoctors ile join=birleştirme bağlıyoruz.
                // join'den sonra 2.Tablonun değişken ismini KENDİMİZ belirliyoruz. = > myDoctors
                // sonra bu değişkene verilerin geleceği tabloyu "in TabloAdı" şeklinde yazıyoruz.
                // sonra "on" kelimesini kullanarak join işlemine başlıyoruz.
                // hangi tabloladaki hangi kolonları eşleştireceksek "equals" kelimesiyle yazıyoruz.
                // sonra 3. tablo ekleyeceğimiz için tekrar "join" yazıyoruz.
                // 3. tablodaki verilerin tutulacağı değişken adını KENDİMİZ belirliyoruz.
                // verilerin geleceği tablo adını "in" den sonra belirtiyoruz.
                // yine join yapacağımız kolonları seçiyoruz.

                // sorgu işlemi bittikten sonra, hangi kolonların/bilgilerin getirileceğini "select new {  getirilecek kolon adları , birden fazlaysa ',' virgül ile ayrılır }" belirtiyoruz.
                // sorgu sonucundaki tüm veriler yeni bir tablo şeklinde "var patientsDoctorsRecordsAll" içerisinde tutulur.
                var patientsDoctorsRecordsAll = from myRecords in db.Records
                                                join myDoctors in db.Doctors on myRecords.DoctorID equals myDoctors.DoctorID
                                                join myPatients in db.Patients on myRecords.PatientID equals myPatients.PatientID
                                                select new
                                                {
                                                    myRecords.RecordID,
                                                    myRecords.RecordCheckIn,
                                                    myPatients.PatientName,
                                                    myPatients.PatientSurname,
                                                    myDoctors.DoctorName,
                                                    myDoctors.DoctorSurname
                                                };

                // Yeni "patientsDoctorsRecordsAll" isimli tablonun içindeki verileri tek tek okumak yerine
                // foreach döngüsüyle kolay bir şekilde ListView'da listeliyoruz.
                foreach (var patientsDoctorsRecordsColumn in patientsDoctorsRecordsAll)
                {
                    // Her bir satır okunduğunda yeni bir ListViewItem oluşturuyoruz.
                    // Böylece her bilgi ayrı satırlarda görünüyor.
                    ListViewItem li = new ListViewItem();
                    // Tag özelliğine bu Record seçildiğinde detaylarına ulaşabilmek için RecordID bilgisini ekliyoruz.
                    li.Tag = patientsDoctorsRecordsColumn.RecordID;
                    li.Text = patientsDoctorsRecordsColumn.RecordCheckIn.ToString();
                    li.SubItems.Add(patientsDoctorsRecordsColumn.DoctorName + " " + patientsDoctorsRecordsColumn.DoctorSurname);
                    li.SubItems.Add(patientsDoctorsRecordsColumn.PatientName + " " + patientsDoctorsRecordsColumn.PatientSurname);

                    lstRecords.Items.Add(li);
                }
            }
        }

        // ListView'ın elemanlarını seçtiğimizde bu event çalışır.
        private void lstRecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ListView)sender).SelectedItems.Count > 0)
            {
                // 134. satırda eklediğimiz RecordID bilgisini burda ListView'un Tag özelliğinden okuyoruz.
                // Böylece bu recordID'ye kayıtlı bilgileri getiriyoruz.
                // veritabanındaki diğer REcord'lar bizi ilgilendirmiyor.
                int myRecordID = Convert.ToInt32(((ListView)sender).SelectedItems[0].Tag);
                
                using (Hospital_DBDataContext db = new Hospital_DBDataContext())
                {
                    // 3 tabloyu birbirine satır 113.deki gibi bağlıyoruz.
                    // Ek olarak 3 tablodaki tüm verileri/kolonları getiriyoruz.
                    // Sorgu sonucundaki veriler "patientsDoctorsRecordsOneColumnAllInfo" isimli yeni oluşturulan tabloda/değişkende  tutulur.
                    // Herhangi bir veriye ulaşmak istersek bu patientsDoctorsRecordsOneColumnAllInfo değişkenden ulaşmalıyız.
                    var patientsDoctorsRecordsOneColumnAllInfo = (from myRecords in db.Records
                                                                  // Sadece tek satırın gelmesini istediğimiz için RecordID'si seçtiğimiz satırdaki RecordID ile aynı olan
                                                                  // Record bilgisini getiriyoruz.
                                                                  where myRecords.RecordID == myRecordID
                                                                  join myDoctors in db.Doctors on myRecords.DoctorID equals myDoctors.DoctorID
                                                                  join myPatients in db.Patients on myRecords.PatientID equals myPatients.PatientID
                                                                  select new
                                                                  {
                                                                      // Record tablosundaki verileri getiriyoruz.
                                                                      myRecords.RecordAttendent,
                                                                      myRecords.RecordCheckIn,
                                                                      myRecords.RecordCheckOut,
                                                                      myRecords.RecordCost,
                                                                      myRecords.RecordDisease,
                                                                      myRecords.RecordID,
                                                                      myRecords.RecordVisitor,
                                                                      // Patient tablosundaki verileri getiriyoruz.
                                                                      myPatients.PatientAddress,
                                                                      myPatients.PatientBirthDate,
                                                                      myPatients.PatientCity,
                                                                      myPatients.PatientGender,
                                                                      myPatients.PatientID,
                                                                      myPatients.PatientMarialStatus,
                                                                      myPatients.PatientName,
                                                                      myPatients.PatientPhone,
                                                                      myPatients.PatientSurname,
                                                                      // Doctor tablosundaki verileri getiriyoruz.
                                                                      myDoctors.DoctorGender,
                                                                      myDoctors.DoctorID,
                                                                      myDoctors.DoctorName,
                                                                      myDoctors.DoctorPhone,
                                                                      myDoctors.DoctorProf,
                                                                      myDoctors.DoctorSurname
                                                                  }).SingleOrDefault();

                    // ListView'dan seçilen kayıttaki doktorun tüm bilgilerini göster
                    gbDoctor.Text = "DoctorID : " + patientsDoctorsRecordsOneColumnAllInfo.DoctorID;
                    txtDoctorName.Text = patientsDoctorsRecordsOneColumnAllInfo.DoctorName;
                    txtDoctorPhone.Text = patientsDoctorsRecordsOneColumnAllInfo.DoctorPhone;
                    txtDoctorProfession.Text = patientsDoctorsRecordsOneColumnAllInfo.DoctorProf;
                    txtDoctorSurname.Text = patientsDoctorsRecordsOneColumnAllInfo.DoctorSurname;
                    if (patientsDoctorsRecordsOneColumnAllInfo.DoctorGender)
                    {
                        rbDoctorMale.Checked = true;
                    }
                    else
                    {
                        rbDoctorFemale.Checked = true;
                    }

                    // ListView'dan seçilen kayıttaki hastanın tüm bilgilerini göster
                    gbPatient.Text = "PatientID : " + patientsDoctorsRecordsOneColumnAllInfo.PatientID;
                    txtPatientAddress.Text = patientsDoctorsRecordsOneColumnAllInfo.PatientAddress;
                    txtPatientName.Text = patientsDoctorsRecordsOneColumnAllInfo.PatientName;
                    txtPatientSurname.Text = patientsDoctorsRecordsOneColumnAllInfo.PatientSurname;
                    dtpPatientBirthDate.Value = patientsDoctorsRecordsOneColumnAllInfo.PatientBirthDate;

                    // ListView'dan seçilen kayıttaki kayıtların tüm bilgilerini göster
                    gbRecord.Text = "RecordID : " + patientsDoctorsRecordsOneColumnAllInfo.RecordID;
                    // ToString() herhangi bir değeri "string" tipine dönüştürmemizi sağlayan metoddur.
                    txtRecordInfoCost.Text = patientsDoctorsRecordsOneColumnAllInfo.RecordCost.ToString();
                    txtRecordInfoDisease.Text = patientsDoctorsRecordsOneColumnAllInfo.RecordDisease;
                    dtpRecordInfoCheckIn.Value = patientsDoctorsRecordsOneColumnAllInfo.RecordCheckIn;
                    dtpRecordInfoCheckOut.Value = patientsDoctorsRecordsOneColumnAllInfo.RecordCheckOut;
                    // Convert yapmamızın sebebi, sağdaki veri tipinin soldaki ile uyuşmaması.
                    // sağdaki veri tipini soldaki değişken ile aynı tipte olması için Convert sınıfının metodlarını kullanıyoruz.
                    nupRecordInfoAttendent.Value = Convert.ToInt32(patientsDoctorsRecordsOneColumnAllInfo.RecordAttendent);
                    nupRecordInfoVisitor.Value = Convert.ToInt32(patientsDoctorsRecordsOneColumnAllInfo.RecordVisitor);

                }
            }
        }
    }
}
