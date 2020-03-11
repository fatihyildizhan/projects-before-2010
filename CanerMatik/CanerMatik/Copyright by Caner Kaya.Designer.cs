namespace CanerMatik
{
    partial class Copyright_by_Caner_Kaya
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSayacSaniye = new System.Windows.Forms.TextBox();
            this.txtSayacDakika = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSayacSaat = new System.Windows.Forms.TextBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.btnGeriSay = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGenelSaat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCikar = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTopla = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtSayacSaniye);
            this.groupBox1.Controls.Add(this.txtSayacDakika);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtSayacSaat);
            this.groupBox1.Controls.Add(this.dateTimePicker3);
            this.groupBox1.Controls.Add(this.btnGeriSay);
            this.groupBox1.Location = new System.Drawing.Point(193, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 179);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SAYAC";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(127, 154);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 17);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.Text = "Her Zaman Üstte";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(162, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Saniye";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(85, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Dakika";
            // 
            // txtSayacSaniye
            // 
            this.txtSayacSaniye.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSayacSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayacSaniye.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtSayacSaniye.Location = new System.Drawing.Point(162, 28);
            this.txtSayacSaniye.Multiline = true;
            this.txtSayacSaniye.Name = "txtSayacSaniye";
            this.txtSayacSaniye.ReadOnly = true;
            this.txtSayacSaniye.Size = new System.Drawing.Size(72, 51);
            this.txtSayacSaniye.TabIndex = 31;
            // 
            // txtSayacDakika
            // 
            this.txtSayacDakika.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSayacDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayacDakika.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtSayacDakika.Location = new System.Drawing.Point(84, 28);
            this.txtSayacDakika.Multiline = true;
            this.txtSayacDakika.Name = "txtSayacDakika";
            this.txtSayacDakika.ReadOnly = true;
            this.txtSayacDakika.Size = new System.Drawing.Size(72, 51);
            this.txtSayacDakika.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Saat";
            // 
            // txtSayacSaat
            // 
            this.txtSayacSaat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSayacSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayacSaat.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtSayacSaat.Location = new System.Drawing.Point(6, 28);
            this.txtSayacSaat.Multiline = true;
            this.txtSayacSaat.Name = "txtSayacSaat";
            this.txtSayacSaat.ReadOnly = true;
            this.txtSayacSaat.Size = new System.Drawing.Size(72, 51);
            this.txtSayacSaat.TabIndex = 28;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(6, 151);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(115, 20);
            this.dateTimePicker3.TabIndex = 27;
            // 
            // btnGeriSay
            // 
            this.btnGeriSay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGeriSay.Location = new System.Drawing.Point(6, 121);
            this.btnGeriSay.Name = "btnGeriSay";
            this.btnGeriSay.Size = new System.Drawing.Size(115, 23);
            this.btnGeriSay.TabIndex = 26;
            this.btnGeriSay.Text = "Geri Say";
            this.btnGeriSay.UseVisualStyleBackColor = false;
            this.btnGeriSay.Click += new System.EventHandler(this.btnGeriSay_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGenelSaat);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnCikar);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnTopla);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 179);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HESAP";
            // 
            // txtGenelSaat
            // 
            this.txtGenelSaat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtGenelSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGenelSaat.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.txtGenelSaat.Location = new System.Drawing.Point(10, 66);
            this.txtGenelSaat.Multiline = true;
            this.txtGenelSaat.Name = "txtGenelSaat";
            this.txtGenelSaat.ReadOnly = true;
            this.txtGenelSaat.Size = new System.Drawing.Size(155, 41);
            this.txtGenelSaat.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Genel Saat";
            // 
            // btnCikar
            // 
            this.btnCikar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCikar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCikar.Location = new System.Drawing.Point(71, 142);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(94, 23);
            this.btnCikar.TabIndex = 21;
            this.btnCikar.Text = "Çıkar";
            this.btnCikar.UseVisualStyleBackColor = false;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(65, 40);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(65, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Saat 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Saat 1";
            // 
            // btnTopla
            // 
            this.btnTopla.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTopla.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnTopla.Location = new System.Drawing.Point(71, 113);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(94, 23);
            this.btnTopla.TabIndex = 16;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = false;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Copyright_by_Caner_Kaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(440, 201);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Copyright_by_Caner_Kaya";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copyright_by_Caner_Kaya";
            this.Load += new System.EventHandler(this.Copyright_by_Caner_Kaya_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSayacSaniye;
        private System.Windows.Forms.TextBox txtSayacDakika;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSayacSaat;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button btnGeriSay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGenelSaat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Timer timer2;
    }
}