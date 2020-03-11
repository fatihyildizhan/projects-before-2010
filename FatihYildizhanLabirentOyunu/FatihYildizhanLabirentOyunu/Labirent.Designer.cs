namespace FatihYildizhanLabirentOyunu
{
    partial class Labirent
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLabirentOlustur = new System.Windows.Forms.Button();
            this.btnOtomatikAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(315, 250);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnLabirentOlustur
            // 
            this.btnLabirentOlustur.Location = new System.Drawing.Point(285, 268);
            this.btnLabirentOlustur.Name = "btnLabirentOlustur";
            this.btnLabirentOlustur.Size = new System.Drawing.Size(42, 23);
            this.btnLabirentOlustur.TabIndex = 2;
            this.btnLabirentOlustur.Text = "KUR";
            this.btnLabirentOlustur.UseVisualStyleBackColor = true;
            this.btnLabirentOlustur.Click += new System.EventHandler(this.btnLabirentOlustur_Click);
            // 
            // btnOtomatikAra
            // 
            this.btnOtomatikAra.Location = new System.Drawing.Point(196, 268);
            this.btnOtomatikAra.Name = "btnOtomatikAra";
            this.btnOtomatikAra.Size = new System.Drawing.Size(83, 23);
            this.btnOtomatikAra.TabIndex = 4;
            this.btnOtomatikAra.Text = "OTO ARA";
            this.btnOtomatikAra.UseVisualStyleBackColor = true;
            this.btnOtomatikAra.Click += new System.EventHandler(this.btnOtomatikAra_Click);
            // 
            // Labirent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 298);
            this.Controls.Add(this.btnOtomatikAra);
            this.Controls.Add(this.btnLabirentOlustur);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Labirent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Labirent";
            this.Load += new System.EventHandler(this.Labirent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnLabirentOlustur;
        private System.Windows.Forms.Button btnOtomatikAra;
    }
}