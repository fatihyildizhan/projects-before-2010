using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Windows.Documents;

namespace FatihYildizhanLabirentOyunu
{
    public partial class Labirent : Form
    {
        public Labirent()
        {
            InitializeComponent();
        }
        int xSon;
        int ySon;
        Point gck;
        private void Labirent_Load(object sender, EventArgs e)
        {
            LabirentOlustur();
        }

        private void LabirentOlustur()
        {

            Image img0 = Image.FromFile(@"C:\Users\Fatih YILDIZHAN\Documents\Visual Studio 2008\Projects\FatihYildizhanLabirentOyunu\FatihYildizhanLabirentOyunu\FatihYildizhanLabirentOyunu\images\0.bmp");

            Image img1 = Image.FromFile(@"C:\Users\Fatih YILDIZHAN\Documents\Visual Studio 2008\Projects\FatihYildizhanLabirentOyunu\FatihYildizhanLabirentOyunu\FatihYildizhanLabirentOyunu\images\1.bmp");

            Random r = new Random();
            for (int i = 0; i < 108; i++)
            {
                Button b = new Button();
                int index = r.Next(0, 2);
                if(index==0)
                {
                    b.Image =img0;
                }
                else
                {
                    b.Image =img1;
                    b.Text = index.ToString();
                }                
                b.Height = 20;
                b.Width = 20;
                //b.Enabled = false;
                b.ForeColor = Color.Brown;
                flowLayoutPanel1.Controls.Add(b);
                b.Name = b.Location.X + ";" + b.Location.Y;

                if (i == 107)
                {
                    xSon = b.Location.X; ySon = b.Location.Y;
                    Button bc = ((Button)(flowLayoutPanel1.Controls["29;29"]));
                    bc.Text = "F";
                    bc.Enabled = true;
                    gck = new Point(bc.Location.X, bc.Location.Y);
                }
            }
            for (int i = 0; i < 312; i+=26)
            {
                string isim = (3 + i) + ";" + 3;
                Button btn = (Button)(flowLayoutPanel1.Controls[isim]);
                btn.Text = "1";
                //btn.BackColor = Color.Red;
                btn.Image = img1;
            }
            for (int i = 0; i < 234; i += 26)
            {
                string isim = 3 + ";" + (3+i);
                Button btn = (Button)(flowLayoutPanel1.Controls[isim]);
                btn.Text = "1";
                //btn.BackColor = Color.Red;
                btn.Image = img1;
            }
            for (int i = 0; i < 312; i += 26)
            {
                string isim = (3 + i) + ";" + 211;
                Button btn = (Button)(flowLayoutPanel1.Controls[isim]);
                btn.Text = "1";
                //btn.BackColor = Color.Red;
                btn.Image = img1;
            }
            for (int i = 0; i < 234; i += 26)
            {
                string isim = 289 + ";" + (3 + i);
                Button btn = (Button)(flowLayoutPanel1.Controls[isim]);
                btn.Text = "1";
                //btn.BackColor = Color.Red;
                btn.Image = img1;
            }
            string Cksisim = 289 + ";" + 211;
            Button Cksbtn = (Button)(flowLayoutPanel1.Controls[Cksisim]);
            Cksbtn.Text = "0";
            Cksbtn.BackColor = Color.LimeGreen;
        }

        private void btnLabirentOlustur_Click(object sender, EventArgs e)
        {
            tekrarDenedinMi = false;
            adimVarMi = true;
            cikistaMi = false;
            flowLayoutPanel1.Controls.Clear();
            LabirentOlustur();
        }

        Point eskiGCK;
        public void yonBul()
        {
            if (adimVarMi)
            {
                eskiGCK = gck;
                string isim = (gck.X + 26) + ";" + gck.Y;
                Button btn = (Button)(flowLayoutPanel1.Controls[isim]);
                if (btn.Text == "")
                {
                    CikisaGit(btn, 1,1);
                }
                else
                {
                    isim = (gck.X + 26) + ";" + (gck.Y + 26);
                    btn = (Button)(flowLayoutPanel1.Controls[isim]);

                    if (btn.Text == "")
                    {
                        CikisaGit(btn, 2, 1);
                    }
                    else
                    {
                        isim = gck.X + ";" + (gck.Y + 26);
                        btn = (Button)(flowLayoutPanel1.Controls[isim]);

                        if (btn.Text == "")
                        {
                            CikisaGit(btn, 3, 1);
                        }
                        else
                        {
                            isim = (gck.X - 26) + ";" + (gck.Y + 26);
                            btn = (Button)(flowLayoutPanel1.Controls[isim]);

                            if (btn.Text == "")
                            {
                                CikisaGit(btn, 4, 1);
                            }
                            else
                            {
                                isim = (gck.X - 26) + ";" + gck.Y;
                                btn = (Button)(flowLayoutPanel1.Controls[isim]);

                                if (btn.Text == "")
                                {
                                    CikisaGit(btn, 5, 1);
                                }
                                else
                                {
                                    isim = (gck.X - 26) + ";" + (gck.Y - 26);
                                    btn = (Button)(flowLayoutPanel1.Controls[isim]);

                                    if (btn.Text == "")
                                    {
                                        CikisaGit(btn, 6, 1);
                                    }
                                    else
                                    {
                                        isim = gck.X + ";" + (gck.Y - 26);
                                        btn = (Button)(flowLayoutPanel1.Controls[isim]);

                                        if (btn.Text == "")
                                        {
                                            CikisaGit(btn, 7, 1);
                                        }
                                        else
                                        {
                                            isim = (gck.X + 26) + ";" + (gck.Y - 26);
                                            btn = (Button)(flowLayoutPanel1.Controls[isim]);

                                            if (btn.Text == "")
                                            {
                                                CikisaGit(btn, 8, 1);
                                            }
                                            else
                                            {
                                                adimVarMi = false;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                tekrarDene();
            }
            //yerDegistirildi();
        }
        bool cikistaMi = false;
        bool adimVarMi = true;
        bool tekrarDenedinMi = false;
        public void CikisaGit(Button b,int yon, int deneme)
        {

           // Image i = Image.FromFile(@"C:\Users\Fatih YILDIZHAN\Documents\Visual Studio 2008\Projects\FatihYildizhanLabirentOyunu\FatihYildizhanLabirentOyunu\FatihYildizhanLabirentOyunu\images\down.bmp");
           
            if(deneme==1)
            {
                b.Tag = 1;
                if (yon == 1)
                {
                    b.Text = "9";                  
                }
                else if (yon == 2)
                {
                    b.Text = "2";
                }
                else if (yon == 3)
                {
                    b.Text = "3";
                }
                else if (yon == 4)
                {
                    b.Text = "4";
                }
                else if (yon == 5)
                {
                    b.Text = "5";
                }
                else if (yon == 6)
                {
                    b.Text = "6";
                }
                //b.Enabled = true;

                gck = b.Location;

                if (b.Location.X == 289 && b.Location.Y == 211)
                {
                    cikistaMi = true;
                }
                //yerDegistirildi();
            }
            else
            {
                b.Tag = 2;
                if (yon == 1)
                {
                    b.Text = "9";

                }
                else if (yon == 2)
                {
                    b.Text = "d";
                }
                else if (yon == 3)
                {
                    b.Text = "d";
                }
                else if (yon == 4)
                {
                    b.Text = "d";
                }
                else if (yon == 5)
                {
                    b.Text = "d";
                }
                else if (yon == 6)
                {
                    b.Text = "d";
                }
                //b.Enabled = true;

                //if (Convert.ToInt16(b.Tag) == 0)
                //{
                //    b.Tag = 1;
                //}
                //else 
                //{
                //    b.Tag = 2;
                //}

                gck = b.Location;

                if (b.Location.X == 289 && b.Location.Y == 211)
                {
                    cikistaMi = true;
                }
                //yerDegistirildi();
            }

        }

        public void tekrarDene()
        {
            eskiGCK = gck;
            string isim = (gck.X + 26) + ";" + (gck.Y - 26);
            Button btn = (Button)(flowLayoutPanel1.Controls[isim]);
            if (Convert.ToInt16(btn.Tag) == 1)
            {
                CikisaGit(btn, 1, 2);
            }
            else
            {
                isim = gck.X + ";" + (gck.Y - 26);
                btn = (Button)(flowLayoutPanel1.Controls[isim]);

                if (Convert.ToInt16(btn.Tag) == 1)
                {
                    CikisaGit(btn, 2, 2);
                }
                else
                {
                    isim = (gck.X - 26) + ";" + (gck.Y - 26);
                    btn = (Button)(flowLayoutPanel1.Controls[isim]);

                    if (Convert.ToInt16(btn.Tag) == 1)
                    {
                        CikisaGit(btn, 3, 2);
                    }
                    else
                    {
                        isim = (gck.X - 26) + ";" + gck.Y;
                        btn = (Button)(flowLayoutPanel1.Controls[isim]);

                        if (Convert.ToInt16(btn.Tag) == 1)
                        {
                            CikisaGit(btn, 4, 2);
                        }
                        else
                        {
                            isim = (gck.X - 26) + ";" + (gck.Y + 26);
                            btn = (Button)(flowLayoutPanel1.Controls[isim]);

                            if (Convert.ToInt16(btn.Tag) == 1)
                            {
                                CikisaGit(btn, 5, 2);
                            }
                            else
                            {
                                isim = gck.X + ";" + (gck.Y + 26);
                                btn = (Button)(flowLayoutPanel1.Controls[isim]);

                                if (Convert.ToInt16(btn.Tag) == 1)
                                {
                                    CikisaGit(btn, 6, 2);
                                }
                                else
                                {
                                    isim = (gck.X + 26) + ";" + (gck.Y + 26);
                                    btn = (Button)(flowLayoutPanel1.Controls[isim]);

                                    if (Convert.ToInt16(btn.Tag) == 1)
                                    {
                                        CikisaGit(btn, 7, 2);
                                    }
                                    else
                                    {
                                        isim = (gck.X + 26) + ";" + gck.Y;
                                        btn = (Button)(flowLayoutPanel1.Controls[isim]);

                                        if (Convert.ToInt16(btn.Tag) == 1)
                                        {
                                            CikisaGit(btn, 8, 2);
                                        }
                                        else
                                        {
                                            tekrarDenedinMi = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void yerDegistirildi()
        {
            string isim = eskiGCK.X.ToString() +";" + eskiGCK.Y.ToString();
            Button b = (Button)(flowLayoutPanel1.Controls[isim]);

                b.Text = "+";
                b.BackColor = Color.LightBlue;

                //if (Convert.ToInt16(b.Tag) == 0)
                //{
                //    b.Text = "+";
                //    b.BackColor = Color.LightBlue;
                //}
                //else if (Convert.ToInt16(b.Tag) == 1)
                //{
                //    b.Text = "-";
                //    b.BackColor = Color.Pink;
                //}
        } 

        private void btnOtomatikAra_Click(object sender, EventArgs e)
        {
            Basla();
        }

        private void Basla()
        {
            while (1 == 1)
            {
                if (cikistaMi)
                {
                    MessageBox.Show("Tebrikler Çıkışa Ulaştınız!");
                    break;
                }
                else if (tekrarDenedinMi)
                {
                    MessageBox.Show("Fare Kapana Kısıldı!");
                    break;
                }

                yonBul();
                System.Threading.Thread.Sleep(500);
            }
        }
        
        
    }
}
