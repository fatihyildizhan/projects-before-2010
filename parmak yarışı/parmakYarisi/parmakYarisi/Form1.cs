using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ParmakYarisiApiDbLayer;

namespace parmakYarisi
{
    public partial class Form1 : Form
    {
        List<String> sentences = new List<string>();
        String[] words;
        int currentSentence = 5;
        int currentWord = 0;
        int raceTimeInSeconds = 0;
        int passedSeconds = 0;
        int WPM = 0;
        int wordCount = 0;
        float accuracy = 0;
        int gainingXP = 0;
        int totalWrongCharacter = 0;
        int totalCharacter = 0;
        Boolean errorSafe = false;
        User currentUser;
        UserDetail currentUserDetail;
        UserInfo currentUserInfo;

        /// <summary>
        /// Form1 Constructor
        /// </summary>
        /// <param name="_currentUser"></param>
        /// <param name="_currentUserDetail"></param>
        /// <param name="_currentUserInfo"></param>
        public Form1(User _currentUser, UserDetail _currentUserDetail, UserInfo _currentUserInfo)
        {
            currentUser = _currentUser;
            currentUserDetail = _currentUserDetail;
            currentUserInfo = _currentUserInfo;
            InitializeComponent();
        }

        /// <summary>
        /// Form1 Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            timerClock.Enabled = true;
            importUserDetails();
            importSentences();
            updateXPtoWidth();
        }

        /// <summary>
        /// import User Details
        /// </summary>
        private void importUserDetails()
        {
            lblUserNickname.Text = currentUser.UserNickname;
            lblLevelName.Text = currentUserInfo.UserLevelInfo.LevelName.ToString();
            lblXPtoPoint.Text = currentUserDetail.UserXP.ToString();
        }

        private void findTotalCharacter()
        {
            try
            {
                for (int i = 0; i < words.Length; i++)
                {
                    totalCharacter += words[i].ToString().Length;
                }
            }
            catch (Exception ex)
            {
                CatchExLinqToApi.myCatchException(ex, "findTotalCharacter");
            }
        }

        private void importSentences()
        {
            sentences.Add("Sony'nin bir süre önce hack'lenen çevrim içi oyun");
        }

        private void txtRacer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!txtRacer.Text.Equals(""))
                {
                    if (lastChar(txtRacer.Text.ToString()).Equals(' ') && txtRacer.Text.Length - 1 == words[currentWord].Length)
                    {
                        spacePressed();
                    }
                    else if (currentWord == words.Length - 1 && wordControl(txtRacer.Text.Substring(0, txtRacer.Text.Length)) && lastChar(txtRacer.Text.ToString()).Equals(lastChar(words[words.Length - 1])))
                    {
                        endGame(true);
                    }
                    else
                    {
                        accuracyControl();
                    }
                }
            }
            catch (Exception ex)
            {
                CatchExLinqToApi.myCatchException(ex, "txtRacer_TextChanged");
            }
        }

        private void accuracyControl()
        {
            try
            {
                if (txtRacer.Text.Length <= words[currentWord].Length)
                {
                    if (txtRacer.Text.Substring(0, txtRacer.Text.Length).Equals(words[currentWord].Substring(0, txtRacer.Text.Length)))
                    {
                        errorSafe = false;
                        txtRacer.BackColor = Color.Green;
                    }
                    else
                    {
                        wrongChar();
                    }
                }
                else
                {
                    wrongChar();
                }
            }
            catch (Exception ex)
            {
                CatchExLinqToApi.myCatchException(ex, "accuracyControl");
            }
        }

        private void wrongChar()
        {
            txtRacer.BackColor = Color.Red;
            if (!errorSafe)
            {
                errorSafe = true;
                totalWrongCharacter++;
            }
        }

        private void spacePressed() //Space tuşu kontrolü.
        {
            /*
             * Space tuşuna basıldığında bu metod çalışır.
             * Yazılan kelimenin doğru olup olmadığı kontrol edilir.
             * Yazılan kelimenin "txtRacer.Text.Length - 1" e kadar olan kısmı alınır ve wordControl fonksiyonuna gönderilir.
             * wordControl metodu true döndürürse, kelimenin doğru olduğu anlaşılır ve correctWord metodu çalıştırılır.
             */
            try
            {
                if (wordControl(txtRacer.Text.Substring(0, txtRacer.Text.Length - 1)))
                {
                    correctWord();
                }
            }
            catch (Exception ex)
            {
                CatchExLinqToApi.myCatchException(ex, "spacePressed");
            }
        }

        private Boolean wordControl(String writtenWord) //Kelime kontrolü.
        {
            /*
             * Yazılan kelimenin doğru olup olmadığını kontrol eder.
             * Doğru ise "true" yanlış ise "false" döndürür.
             */
            if (writtenWord.Equals(words[currentWord])) return true;
            else return false;
        }

        private void correctWord()  //Kelime doğru yazıldıysa çalışacak kodlar.
        {
            /*
             * İlk olarak aktif kelime bir sonraki kelime haline getirilir.
             * Daha sonra kullanıcının yazı yazdığı alan temizlenir.
             * Yazılan kelime sayısı 1 arttırılır.
             * Grafik ekranda arabanın hareket etmesi için goCar metodu çağırılır.
             * Yeni kelimenin ekranda gösterilmesi için newWord metodu çağırılır.
             */
            currentWord++;
            txtRacer.Text = "";
            wordCount++;
            goCar();
            newWord();
        }

        private void goCar()    //Grafik ekrandaki arabanın hareket etmesini sağlayan metod.
        {
            try
            {
                car1.Left = (pnlRace.Size.Width - car1.Size.Width - 3) * wordCount / words.Length;
            }
            catch (Exception ex)
            {
                CatchExLinqToApi.myCatchException(ex, "goCar");
            }
        }

        private void endGame(Boolean flag)  //Oyun bittiğinde çalışacak kodlar.
        {
            /////////////Oyun bittikten sonra da son kez WPM kontrolü yapılması gerekiyor.
            /* 
             * Yazılan kelime sayısı 1 arttırılır.
             * Grafik ekranda arabanın hareket etmesi için goCar metodu çağırılır.
             * timerlar kapatılır.
             * Kullanıcının yazı yazdığı alan temizlenip disable hale getiriliyor.
             * Accuracy değerinin hesablanabilmesi için calculateAccuracy metodu çağırılır ve ekrana bilgiler getirilir.
             */
            try
            {
                if (!flag)
                {
                    accuracy = 0;
                    gainingXP = 0;
                    WPM = 0;
                }
                else
                {
                    wordCount++;
                    goCar();
                    calculateAccuracy();
                    calculateXP();
                }
                timerRace.Enabled = false;
                timerWPM.Enabled = false;
                txtRacer.Text = "";
                lblSentenceCurrent.Text = "";
                lblSentenceNext.Text = "";
                txtRacer.Enabled = false;
                txtRacer.BackColor = System.Drawing.SystemColors.Window;
                lastGameForm lastGame = new lastGameForm(WPM, accuracy, gainingXP, flag);
                lastGame.ShowDialog();
                updateXP();
                btnBaslat.Visible = true;
            }
            catch (Exception ex)
            {
                CatchExLinqToApi.myCatchException(ex, "endGame");
            }
        }

        private void restart()
        {
            try
            {
                currentSentence = new Random().Next(sentences.Count());
                currentWord = 0;
                raceTimeInSeconds = 0;
                passedSeconds = 0;
                WPM = 0;
                wordCount = 0;
                accuracy = 0;
                gainingXP = 0;
                totalWrongCharacter = 0;
                totalCharacter = 0;
                lblWPM.Text = "0WPM";
                lblRemainingTime.Text = "3 : 00";
                car1.Left = 0;
                txtRacer.Text = String.Empty;
                startForm frmStart = new startForm();
                frmStart.ShowDialog();
                txtRacer.Enabled = true;
                txtRacer.Focus();
                timerRace.Enabled = true;
                timerWPM.Enabled = true;
                errorSafe = false;
                words = sentences[currentSentence].Split(' ');
                findTotalCharacter();
                newWord();
                btnBaslat.Visible = false;
            }
            catch (Exception ex)
            {
                CatchExLinqToApi.myCatchException(ex, "restart");
            }
        }

        private void newWord()
        {
            try
            {
                String sentenceNext = "";
                for (int i = 0; i < words.Length; i++)
                {
                    if (i == words.Length - 1 && i == currentWord) lblSentenceCurrent.Text = words[i];
                    else if (i == words.Length - 1) sentenceNext += words[i];
                    else if (i == currentWord) lblSentenceCurrent.Text = words[i];
                    else if (i > currentWord) sentenceNext += words[i] + " ";
                }
                lblSentenceNext.Text = sentenceNext;
            }
            catch (Exception ex)
            {
                CatchExLinqToApi.myCatchException(ex, "newWord");
            }
        }

        private char lastChar(String str)
        {
            char[] c = str.ToCharArray();
            return c[c.Length - 1];
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            restart();
        }

        private String calculateRemainingTime(int passedTime)
        {
            int remainingTimeInSeconds = 180 - passedTime;
            String remainingTime = ((int)remainingTimeInSeconds / 60) + " : ";
            if ((remainingTimeInSeconds % 60).ToString().Length < 2) remainingTime += "0" + (int)remainingTimeInSeconds % 60;
            else remainingTime += ((int)remainingTimeInSeconds % 60).ToString();
            return remainingTime;
        }

        private void calculateWPM()
        {
            WPM = 60 * wordCount / passedSeconds;
            lblWPM.Text = WPM.ToString() + "WPM";
        }

        private void calculateAccuracy()
        {
            accuracy = (float)(totalCharacter - totalWrongCharacter) / (float)totalCharacter;
            accuracy = accuracy * 100;
        }

        private void calculateXP()
        {
            gainingXP = (int)(((float)(accuracy / 10) + (float)(WPM / 10)) * wordCount);
        }

        private void updateXP()
        {
            currentUserDetail = pyApiUpdateXP.pyUpdateXP(currentUser.UserID, gainingXP);
            pyApiGenerateUserInfo pa = new pyApiGenerateUserInfo();
            calculateXPtoLevel();
            currentUserInfo = pa.ApiGenerateUserInfo(currentUser);
            lblXPtoPoint.Text = currentUserDetail.UserXP.ToString();
            lblLevelName.Text = currentUserInfo.UserLevelInfo.LevelName;
            updateXPtoWidth();
        }

        private void calculateXPtoLevel()
        {
            currentUserDetail = pyApiCalculateXPtoLevel.ApiCalculateXPtoLevel(currentUserDetail, currentUserInfo);
        }

        private void updateXPtoWidth()
        {
            pyApiCalculateXPtoWidth ApiCalculateXPtoWidth = new pyApiCalculateXPtoWidth();
            lblXPtoLevel.Width = ApiCalculateXPtoWidth.ApiCalculateXPtoWidth(currentUserDetail, currentUserInfo);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            top10Form top10 = new top10Form();
            top10.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            menuForm menu = new menuForm(currentUser,currentUserDetail,currentUserInfo);
            menu.Show();
            this.Dispose();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblClock.Text = String.Format("{0:HH:mm:ss}", dt);
        }

        private void timerWPM_Tick(object sender, EventArgs e)
        {
            passedSeconds += 2;
            calculateWPM();
        }

        private void timerRace_Tick(object sender, EventArgs e)
        {
            try
            {
                raceTimeInSeconds++;
                lblRemainingTime.Text = calculateRemainingTime(raceTimeInSeconds);
                if (raceTimeInSeconds == 180)
                    endGame(false);
            }
            catch (Exception ex)
            {
                CatchExLinqToApi.myCatchException(ex, "timerRace_Tick");
            }
        }
    }
}