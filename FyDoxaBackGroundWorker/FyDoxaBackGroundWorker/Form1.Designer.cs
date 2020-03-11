namespace FyDoxaBackGroundWorker
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnMbox = new System.Windows.Forms.Button();
            this.btnWorkerCalistir = new System.Windows.Forms.Button();
            this.btnArkaPlanDegistir = new System.Windows.Forms.Button();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnMbox
            // 
            this.btnMbox.Location = new System.Drawing.Point(12, 70);
            this.btnMbox.Name = "btnMbox";
            this.btnMbox.Size = new System.Drawing.Size(118, 23);
            this.btnMbox.TabIndex = 0;
            this.btnMbox.Text = "Mesajı Göster";
            this.btnMbox.UseVisualStyleBackColor = true;
            this.btnMbox.Click += new System.EventHandler(this.btnMbox_Click);
            // 
            // btnWorkerCalistir
            // 
            this.btnWorkerCalistir.Location = new System.Drawing.Point(12, 12);
            this.btnWorkerCalistir.Name = "btnWorkerCalistir";
            this.btnWorkerCalistir.Size = new System.Drawing.Size(175, 23);
            this.btnWorkerCalistir.TabIndex = 1;
            this.btnWorkerCalistir.Text = "B.G.Worker Başlat";
            this.btnWorkerCalistir.UseVisualStyleBackColor = true;
            this.btnWorkerCalistir.Click += new System.EventHandler(this.btnWorkerCalistir_Click);
            // 
            // btnArkaPlanDegistir
            // 
            this.btnArkaPlanDegistir.Location = new System.Drawing.Point(12, 41);
            this.btnArkaPlanDegistir.Name = "btnArkaPlanDegistir";
            this.btnArkaPlanDegistir.Size = new System.Drawing.Size(118, 23);
            this.btnArkaPlanDegistir.TabIndex = 2;
            this.btnArkaPlanDegistir.Text = "Arkaplanı Değiştir";
            this.btnArkaPlanDegistir.UseVisualStyleBackColor = true;
            this.btnArkaPlanDegistir.Click += new System.EventHandler(this.btnArkaPlanDegistir_Click);
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(136, 73);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(177, 20);
            this.txtMesaj.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 110);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.btnArkaPlanDegistir);
            this.Controls.Add(this.btnWorkerCalistir);
            this.Controls.Add(this.btnMbox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnMbox;
        private System.Windows.Forms.Button btnWorkerCalistir;
        private System.Windows.Forms.Button btnArkaPlanDegistir;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Timer timer1;
    }
}

