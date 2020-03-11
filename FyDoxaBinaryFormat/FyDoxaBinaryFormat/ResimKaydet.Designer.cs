namespace FyDoxaBinaryFormat
{
    partial class ResimKaydet
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGozat = new System.Windows.Forms.Button();
            this.txtResimYolu = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(12, 12);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(260, 46);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGozat
            // 
            this.btnGozat.Location = new System.Drawing.Point(12, 65);
            this.btnGozat.Name = "btnGozat";
            this.btnGozat.Size = new System.Drawing.Size(75, 23);
            this.btnGozat.TabIndex = 1;
            this.btnGozat.Text = "Gözat";
            this.btnGozat.UseVisualStyleBackColor = true;
            this.btnGozat.Click += new System.EventHandler(this.btnGozat_Click);
            // 
            // txtResimYolu
            // 
            this.txtResimYolu.Location = new System.Drawing.Point(93, 67);
            this.txtResimYolu.Name = "txtResimYolu";
            this.txtResimYolu.ReadOnly = true;
            this.txtResimYolu.Size = new System.Drawing.Size(179, 20);
            this.txtResimYolu.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ResimKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.txtResimYolu);
            this.Controls.Add(this.btnGozat);
            this.Controls.Add(this.btnKaydet);
            this.Name = "ResimKaydet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResimKaydet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGozat;
        private System.Windows.Forms.TextBox txtResimYolu;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}