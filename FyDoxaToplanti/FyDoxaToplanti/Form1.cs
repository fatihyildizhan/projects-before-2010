using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FyDoxaToplanti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnToplantiEkle_Click(object sender, EventArgs e)
        {
            string Duzenleyen = "";
            try
            {
                // DuzenleyenOlustur procedur'ü Kullanıcı ve o anki Ünvanını birleştirir
                // Örnek: 'Fatih YILDIZHAN Öğrenci' olarak getirir
                // 21.satırdaki Duzenleyen'e ';' ile birleştirilerek atanır

                SqlCommand com = new SqlCommand("DuzenleyenOlustur", ConState.con);
                com.CommandType = CommandType.StoredProcedure;
                //combobox'dan seçilen kullanıcının id 'sini alır
                com.Parameters.AddWithValue("@id", ((Kullanici)cmbKullanicilar.SelectedItem).KullaniciId);
                ConState.conOpen();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    Duzenleyen = dr[0].ToString() + ";" + dr[1].ToString();
                }
                dr.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Düzenleyen Oluşturulamadı! "+ ex.Message);
            }

            try
            {
                // ToplantiEkle procedur'ü kullanılarak
                // Gerekli bilgiler alınarak
                // Duzenleyen adlı field dan duzenleyen bilgisi alınarak
                // Toplantı kaydı oluşturulur

                SqlCommand com2 = new SqlCommand("ToplantiEkle", ConState.con);
                com2.CommandType = CommandType.StoredProcedure;
                com2.Parameters.AddWithValue("@ToplantiKonusu", txtToplantiKonusu.Text);
                com2.Parameters.AddWithValue("@Duzenleyen", Duzenleyen);
                com2.Parameters.AddWithValue("@Tarih", dateTimePicker1.Value);
                int sonuc = Convert.ToInt16(com2.ExecuteNonQuery());
                lblSonuc.Visible = true;
                if(sonuc > 0)
                {
                    lblSonuc.Text = "Toplantı Eklendi.";
                }
                else
                {
                    lblSonuc.Text = "Toplantı Eklenmedi!";
                }
                listViewDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Toplantı Eklenemedi! "+ex.Message);
            }
            finally
            {
                ConState.conClose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Kullanıcılar combobox'a doldurulur
                SqlCommand com = new SqlCommand("select * from Kullanici", ConState.con);
                ConState.conOpen();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    Kullanici k = new Kullanici();
                    k.KullaniciAd = dr[2].ToString();
                    k.KullaniciId = Convert.ToInt16(dr[0]);
                    cmbKullanicilar.Items.Add(k);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcılar combobox'a doldurulamadı! " + ex.Message);
            }
            finally
            {
                ConState.conClose();
            }
        }

        private void btnToplantiListele_Click(object sender, EventArgs e)
        {
            listViewDoldur();
        }
        public void listViewDoldur()
        {
            // Listview Temizlenir
            // Tüm toplantılar çekilir
            // Düzenleyen bilgisi ToplantıEkle Bölümünde ';' ile birleştirildiği için
            // Burada split edilir
            // Sonrasında listview da listelenir

            listView1.Items.Clear();
            SqlCommand com = new SqlCommand("select * from Toplanti", ConState.con);
            try
            {
                ConState.conOpen();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = dr[1].ToString();
                    string duzenleyen = dr[2].ToString();
                    string[] bilgiler = duzenleyen.Split(';');
                    li.SubItems.Add(bilgiler[0]);
                    li.SubItems.Add(bilgiler[1]);
                    li.SubItems.Add(dr[3].ToString());

                    listView1.Items.Add(li);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Toplantılar Listelenemedi!: " + ex.Message);
            }
            finally
            {
                ConState.conClose();
            }
        }
    }
}
