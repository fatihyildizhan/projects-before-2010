namespace DoxaKutuphane
{
    partial class frmYayinEviEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYayinEvAdres = new System.Windows.Forms.TextBox();
            this.txtYayinEvAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYayinEvEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYayinEvAdres);
            this.groupBox1.Controls.Add(this.txtYayinEvAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnYayinEvEkle);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Press";
            // 
            // txtYayinEvAdres
            // 
            this.txtYayinEvAdres.Location = new System.Drawing.Point(106, 69);
            this.txtYayinEvAdres.Multiline = true;
            this.txtYayinEvAdres.Name = "txtYayinEvAdres";
            this.txtYayinEvAdres.Size = new System.Drawing.Size(157, 92);
            this.txtYayinEvAdres.TabIndex = 4;
            // 
            // txtYayinEvAd
            // 
            this.txtYayinEvAd.Location = new System.Drawing.Point(106, 31);
            this.txtYayinEvAd.Name = "txtYayinEvAd";
            this.txtYayinEvAd.Size = new System.Drawing.Size(157, 20);
            this.txtYayinEvAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresses";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Press Name";
            // 
            // btnYayinEvEkle
            // 
            this.btnYayinEvEkle.Font = new System.Drawing.Font("MS Mincho", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYayinEvEkle.Location = new System.Drawing.Point(13, 181);
            this.btnYayinEvEkle.Name = "btnYayinEvEkle";
            this.btnYayinEvEkle.Size = new System.Drawing.Size(250, 45);
            this.btnYayinEvEkle.TabIndex = 0;
            this.btnYayinEvEkle.Text = "ADD  >>>";
            this.btnYayinEvEkle.UseVisualStyleBackColor = true;
            this.btnYayinEvEkle.Click += new System.EventHandler(this.btnYayinEvEkle_Click);
            // 
            // frmYayinEviEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(297, 272);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmYayinEviEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Press";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtYayinEvAdres;
        private System.Windows.Forms.TextBox txtYayinEvAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYayinEvEkle;
    }
}