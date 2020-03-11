namespace FyDoxaCsharpOgreniyorum_Ders1
{
    partial class FyDoxa_Csharp_Timer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblKalanZaman = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBasla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOyuncu2Skor = new System.Windows.Forms.TextBox();
            this.txtOyuncu1Skor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDefaTiklandi = new System.Windows.Forms.Label();
            this.btnTiklanilan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.lblKalanZaman);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBasla);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ayarlar";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(77, 19);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // lblKalanZaman
            // 
            this.lblKalanZaman.AutoSize = true;
            this.lblKalanZaman.Location = new System.Drawing.Point(90, 52);
            this.lblKalanZaman.Name = "lblKalanZaman";
            this.lblKalanZaman.Size = new System.Drawing.Size(29, 13);
            this.lblKalanZaman.TabIndex = 5;
            this.lblKalanZaman.Text = "Süre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kalan Zaman";
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(8, 71);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(117, 23);
            this.btnBasla.TabIndex = 2;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Süre (sn)";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOyuncu2Skor);
            this.groupBox2.Controls.Add(this.txtOyuncu1Skor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(151, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Oyuncu Bilgileri";
            // 
            // txtOyuncu2Skor
            // 
            this.txtOyuncu2Skor.Location = new System.Drawing.Point(85, 52);
            this.txtOyuncu2Skor.Name = "txtOyuncu2Skor";
            this.txtOyuncu2Skor.ReadOnly = true;
            this.txtOyuncu2Skor.Size = new System.Drawing.Size(63, 20);
            this.txtOyuncu2Skor.TabIndex = 3;
            // 
            // txtOyuncu1Skor
            // 
            this.txtOyuncu1Skor.Location = new System.Drawing.Point(85, 26);
            this.txtOyuncu1Skor.Name = "txtOyuncu1Skor";
            this.txtOyuncu1Skor.ReadOnly = true;
            this.txtOyuncu1Skor.Size = new System.Drawing.Size(63, 20);
            this.txtOyuncu1Skor.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "2. Oyuncu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "1. Oyuncu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDefaTiklandi);
            this.groupBox3.Controls.Add(this.btnTiklanilan);
            this.groupBox3.Location = new System.Drawing.Point(13, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 81);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tıklanmatik";
            // 
            // lblDefaTiklandi
            // 
            this.lblDefaTiklandi.AutoSize = true;
            this.lblDefaTiklandi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDefaTiklandi.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDefaTiklandi.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblDefaTiklandi.Location = new System.Drawing.Point(211, 19);
            this.lblDefaTiklandi.Name = "lblDefaTiklandi";
            this.lblDefaTiklandi.Size = new System.Drawing.Size(51, 55);
            this.lblDefaTiklandi.TabIndex = 1;
            this.lblDefaTiklandi.Text = "0";
            // 
            // btnTiklanilan
            // 
            this.btnTiklanilan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTiklanilan.Enabled = false;
            this.btnTiklanilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTiklanilan.ForeColor = System.Drawing.SystemColors.Info;
            this.btnTiklanilan.Location = new System.Drawing.Point(8, 20);
            this.btnTiklanilan.Name = "btnTiklanilan";
            this.btnTiklanilan.Size = new System.Drawing.Size(198, 55);
            this.btnTiklanilan.TabIndex = 0;
            this.btnTiklanilan.Text = "TIKLA!";
            this.btnTiklanilan.UseVisualStyleBackColor = false;
            this.btnTiklanilan.Click += new System.EventHandler(this.btnTiklanilan_Click);
            // 
            // FyDoxa_Csharp_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 204);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FyDoxa_Csharp_Timer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FyDoxa_Csharp_Timer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKalanZaman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOyuncu2Skor;
        private System.Windows.Forms.TextBox txtOyuncu1Skor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDefaTiklandi;
        private System.Windows.Forms.Button btnTiklanilan;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}