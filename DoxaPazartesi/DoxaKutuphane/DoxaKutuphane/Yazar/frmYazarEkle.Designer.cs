namespace DoxaKutuphane
{
    partial class frmYazarEkle
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
            this.txtYazarAdEkle = new System.Windows.Forms.TextBox();
            this.txtYazarSoyadEkle = new System.Windows.Forms.TextBox();
            this.cmbYazarYynEvEkle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYazarEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYazarAdEkle);
            this.groupBox1.Controls.Add(this.txtYazarSoyadEkle);
            this.groupBox1.Controls.Add(this.cmbYazarYynEvEkle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnYazarEkle);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(293, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Author";
            // 
            // txtYazarAdEkle
            // 
            this.txtYazarAdEkle.Location = new System.Drawing.Point(100, 39);
            this.txtYazarAdEkle.Margin = new System.Windows.Forms.Padding(4);
            this.txtYazarAdEkle.Name = "txtYazarAdEkle";
            this.txtYazarAdEkle.Size = new System.Drawing.Size(160, 22);
            this.txtYazarAdEkle.TabIndex = 6;
            // 
            // txtYazarSoyadEkle
            // 
            this.txtYazarSoyadEkle.Location = new System.Drawing.Point(100, 81);
            this.txtYazarSoyadEkle.Margin = new System.Windows.Forms.Padding(4);
            this.txtYazarSoyadEkle.Name = "txtYazarSoyadEkle";
            this.txtYazarSoyadEkle.Size = new System.Drawing.Size(160, 22);
            this.txtYazarSoyadEkle.TabIndex = 5;
            // 
            // cmbYazarYynEvEkle
            // 
            this.cmbYazarYynEvEkle.FormattingEnabled = true;
            this.cmbYazarYynEvEkle.Location = new System.Drawing.Point(100, 129);
            this.cmbYazarYynEvEkle.Margin = new System.Windows.Forms.Padding(4);
            this.cmbYazarYynEvEkle.Name = "cmbYazarYynEvEkle";
            this.cmbYazarYynEvEkle.Size = new System.Drawing.Size(160, 24);
            this.cmbYazarYynEvEkle.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Press";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // btnYazarEkle
            // 
            this.btnYazarEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarEkle.Location = new System.Drawing.Point(13, 185);
            this.btnYazarEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnYazarEkle.Name = "btnYazarEkle";
            this.btnYazarEkle.Size = new System.Drawing.Size(248, 55);
            this.btnYazarEkle.TabIndex = 0;
            this.btnYazarEkle.Text = "Add Author >>>";
            this.btnYazarEkle.UseVisualStyleBackColor = true;
            this.btnYazarEkle.Click += new System.EventHandler(this.btnYazarEkle_Click);
            // 
            // frmYazarEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(323, 308);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmYazarEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Author";
            this.Load += new System.EventHandler(this.frmYazarEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtYazarAdEkle;
        private System.Windows.Forms.TextBox txtYazarSoyadEkle;
        private System.Windows.Forms.ComboBox cmbYazarYynEvEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYazarEkle;
    }
}