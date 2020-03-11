using System.Windows.Forms;
namespace parmakYarisi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSentenceCurrent = new System.Windows.Forms.Label();
            this.lblSentenceNext = new System.Windows.Forms.Label();
            this.txtRacer = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlUserDetails = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.lblUserNickname = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblLevelName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblXPtoLevel = new System.Windows.Forms.Label();
            this.lblXPtoPoint = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.lblWPM = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.pnlRace = new System.Windows.Forms.Panel();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.timerRace = new System.Windows.Forms.Timer(this.components);
            this.timerWPM = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlUserDetails.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlRace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSentenceCurrent
            // 
            this.lblSentenceCurrent.AutoSize = true;
            this.lblSentenceCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentenceCurrent.ForeColor = System.Drawing.Color.Blue;
            this.lblSentenceCurrent.Location = new System.Drawing.Point(3, 0);
            this.lblSentenceCurrent.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblSentenceCurrent.Name = "lblSentenceCurrent";
            this.lblSentenceCurrent.Size = new System.Drawing.Size(20, 25);
            this.lblSentenceCurrent.TabIndex = 1;
            this.lblSentenceCurrent.Text = "-";
            this.lblSentenceCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSentenceNext
            // 
            this.lblSentenceNext.AutoSize = true;
            this.lblSentenceNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentenceNext.Location = new System.Drawing.Point(23, 0);
            this.lblSentenceNext.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblSentenceNext.Name = "lblSentenceNext";
            this.lblSentenceNext.Size = new System.Drawing.Size(19, 25);
            this.lblSentenceNext.TabIndex = 2;
            this.lblSentenceNext.Text = "-";
            this.lblSentenceNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRacer
            // 
            this.txtRacer.BackColor = System.Drawing.SystemColors.Window;
            this.txtRacer.Enabled = false;
            this.txtRacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRacer.Location = new System.Drawing.Point(125, 3);
            this.txtRacer.Name = "txtRacer";
            this.txtRacer.Size = new System.Drawing.Size(732, 30);
            this.txtRacer.TabIndex = 2;
            this.txtRacer.TextChanged += new System.EventHandler(this.txtRacer_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.lblSentenceCurrent);
            this.flowLayoutPanel1.Controls.Add(this.lblSentenceNext);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(125, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(732, 30);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Level:";
            // 
            // pnlUserDetails
            // 
            this.pnlUserDetails.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlUserDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserDetails.Controls.Add(this.panel5);
            this.pnlUserDetails.Controls.Add(this.panel4);
            this.pnlUserDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlUserDetails.Name = "pnlUserDetails";
            this.pnlUserDetails.Size = new System.Drawing.Size(1920, 27);
            this.pnlUserDetails.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1415, 25);
            this.panel5.TabIndex = 20;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnBack);
            this.panel10.Controls.Add(this.lblUserNickname);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(217, 25);
            this.panel10.TabIndex = 21;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::parmakYarisi.Properties.Resources._1306239093_go_back;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(25, 25);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 21;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblUserNickname
            // 
            this.lblUserNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNickname.ForeColor = System.Drawing.Color.White;
            this.lblUserNickname.Location = new System.Drawing.Point(31, 0);
            this.lblUserNickname.Name = "lblUserNickname";
            this.lblUserNickname.Size = new System.Drawing.Size(104, 25);
            this.lblUserNickname.TabIndex = 0;
            this.lblUserNickname.Text = "UserNickname";
            this.lblUserNickname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblClock);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1275, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 25);
            this.panel3.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(3, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "Saat:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClock
            // 
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblClock.ForeColor = System.Drawing.Color.Coral;
            this.lblClock.Location = new System.Drawing.Point(43, -1);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(61, 27);
            this.lblClock.TabIndex = 1;
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.lblLevelName);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.lblXPtoPoint);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1415, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(503, 25);
            this.panel4.TabIndex = 20;
            // 
            // lblLevelName
            // 
            this.lblLevelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblLevelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLevelName.Location = new System.Drawing.Point(45, 2);
            this.lblLevelName.Name = "lblLevelName";
            this.lblLevelName.Size = new System.Drawing.Size(152, 21);
            this.lblLevelName.TabIndex = 19;
            this.lblLevelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblXPtoLevel);
            this.panel2.Location = new System.Drawing.Point(330, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 21);
            this.panel2.TabIndex = 20;
            // 
            // lblXPtoLevel
            // 
            this.lblXPtoLevel.BackColor = System.Drawing.Color.LightCyan;
            this.lblXPtoLevel.Location = new System.Drawing.Point(0, 0);
            this.lblXPtoLevel.Name = "lblXPtoLevel";
            this.lblXPtoLevel.Size = new System.Drawing.Size(50, 21);
            this.lblXPtoLevel.TabIndex = 19;
            // 
            // lblXPtoPoint
            // 
            this.lblXPtoPoint.AutoSize = true;
            this.lblXPtoPoint.ForeColor = System.Drawing.Color.White;
            this.lblXPtoPoint.Location = new System.Drawing.Point(436, 6);
            this.lblXPtoPoint.Name = "lblXPtoPoint";
            this.lblXPtoPoint.Size = new System.Drawing.Size(64, 13);
            this.lblXPtoPoint.TabIndex = 21;
            this.lblXPtoPoint.Text = "lblXPtoPoint";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(261, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Experience:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Forte", 20F);
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "WPM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Forte", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kalan Süre:";
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.AutoSize = true;
            this.lblRemainingTime.BackColor = System.Drawing.Color.Transparent;
            this.lblRemainingTime.Font = new System.Drawing.Font("Forte", 20F);
            this.lblRemainingTime.Location = new System.Drawing.Point(166, 8);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(77, 30);
            this.lblRemainingTime.TabIndex = 7;
            this.lblRemainingTime.Text = "00:00";
            // 
            // lblWPM
            // 
            this.lblWPM.AutoSize = true;
            this.lblWPM.BackColor = System.Drawing.Color.Transparent;
            this.lblWPM.Font = new System.Drawing.Font("Forte", 20F);
            this.lblWPM.Location = new System.Drawing.Point(97, 8);
            this.lblWPM.Name = "lblWPM";
            this.lblWPM.Size = new System.Drawing.Size(101, 30);
            this.lblWPM.TabIndex = 9;
            this.lblWPM.Text = "0 WPM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(37, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Yazılacak:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(3, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 36);
            this.panel1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(10, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Buraya Yazın:";
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackgroundImage = global::parmakYarisi.Properties.Resources.start;
            this.btnBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaslat.Location = new System.Drawing.Point(663, 216);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(200, 90);
            this.btnBaslat.TabIndex = 4;
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // pnlRace
            // 
            this.pnlRace.BackgroundImage = global::parmakYarisi.Properties.Resources.race;
            this.pnlRace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRace.Controls.Add(this.car1);
            this.pnlRace.Location = new System.Drawing.Point(68, 70);
            this.pnlRace.Name = "pnlRace";
            this.pnlRace.Size = new System.Drawing.Size(723, 27);
            this.pnlRace.TabIndex = 0;
            // 
            // car1
            // 
            this.car1.Image = global::parmakYarisi.Properties.Resources.car;
            this.car1.Location = new System.Drawing.Point(0, 0);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(58, 24);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car1.TabIndex = 0;
            this.car1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.pnlRace);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.btnBaslat);
            this.panel6.Location = new System.Drawing.Point(695, 361);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(870, 317);
            this.panel6.TabIndex = 20;
            this.panel6.Left = Screen.PrimaryScreen.Bounds.Width / 2 - panel6.Width / 2;
            this.panel6.Top = Screen.PrimaryScreen.Bounds.Height / 2 - panel6.Height / 2;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.SeaShell;
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.lblWPM);
            this.panel9.Location = new System.Drawing.Point(634, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(229, 45);
            this.panel9.TabIndex = 20;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SeaShell;
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.lblRemainingTime);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(251, 45);
            this.panel8.TabIndex = 20;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SeaShell;
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.txtRacer);
            this.panel7.Location = new System.Drawing.Point(3, 174);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(860, 36);
            this.panel7.TabIndex = 19;
            // 
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // timerRace
            // 
            this.timerRace.Interval = 1000;
            this.timerRace.Tick += new System.EventHandler(this.timerRace_Tick);
            // 
            // timerWPM
            // 
            this.timerWPM.Interval = 2000;
            this.timerWPM.Tick += new System.EventHandler(this.timerWPM_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::parmakYarisi.Properties.Resources.raceBack2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pnlUserDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Parmak Yarışı - Race with you fingers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.pnlUserDetails.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlRace.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRace;
        private System.Windows.Forms.Label lblSentenceCurrent;
        private System.Windows.Forms.Label lblSentenceNext;
        private System.Windows.Forms.TextBox txtRacer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWPM;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlUserDetails;
        private System.Windows.Forms.Label lblUserNickname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblXPtoLevel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLevelName;
        private System.Windows.Forms.Label lblXPtoPoint;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Label label6;
        private Label lblClock;
        private Panel panel6;
        private Panel panel7;
        private Panel panel9;
        private Panel panel8;
        private PictureBox btnBack;
        private Panel panel10;
        private Timer timerClock;
        private Timer timerRace;
        private Timer timerWPM;
    }
}

