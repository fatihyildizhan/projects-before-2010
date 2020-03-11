namespace parmakYarisi
{
    partial class menuForm
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
            this.btnBaslat = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTop10 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnBaslat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTop10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaslat
            // 
            this.btnBaslat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaslat.Image = global::parmakYarisi.Properties.Resources.oyunuBaslat;
            this.btnBaslat.Location = new System.Drawing.Point(106, 407);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(300, 40);
            this.btnBaslat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.TabStop = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::parmakYarisi.Properties.Resources.menuBack1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 401);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnTop10
            // 
            this.btnTop10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTop10.Image = global::parmakYarisi.Properties.Resources.top101;
            this.btnTop10.Location = new System.Drawing.Point(106, 453);
            this.btnTop10.Name = "btnTop10";
            this.btnTop10.Size = new System.Drawing.Size(300, 40);
            this.btnTop10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnTop10.TabIndex = 1;
            this.btnTop10.TabStop = false;
            this.btnTop10.Click += new System.EventHandler(this.btnTop10_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::parmakYarisi.Properties.Resources.cikis;
            this.btnExit.Location = new System.Drawing.Point(106, 499);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(300, 40);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(502, 556);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTop10);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuForm";
            ((System.ComponentModel.ISupportInitialize)(this.btnBaslat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTop10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnBaslat;
        private System.Windows.Forms.PictureBox btnTop10;
        private System.Windows.Forms.PictureBox btnExit;
    }
}