namespace FyDoxaBackGroundWorker
{
    partial class Form2
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
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.btnArkaPlanDegistir = new System.Windows.Forms.Button();
            this.btnWorkerCalistir = new System.Windows.Forms.Button();
            this.btnMbox = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(181, 90);
            this.txtMesaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(235, 22);
            this.txtMesaj.TabIndex = 7;
            // 
            // btnArkaPlanDegistir
            // 
            this.btnArkaPlanDegistir.Location = new System.Drawing.Point(16, 15);
            this.btnArkaPlanDegistir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnArkaPlanDegistir.Name = "btnArkaPlanDegistir";
            this.btnArkaPlanDegistir.Size = new System.Drawing.Size(157, 28);
            this.btnArkaPlanDegistir.TabIndex = 6;
            this.btnArkaPlanDegistir.Text = "Arkaplanı Değiştir";
            this.btnArkaPlanDegistir.UseVisualStyleBackColor = true;
            this.btnArkaPlanDegistir.Click += new System.EventHandler(this.btnArkaPlanDegistir_Click);
            // 
            // btnWorkerCalistir
            // 
            this.btnWorkerCalistir.Location = new System.Drawing.Point(16, 50);
            this.btnWorkerCalistir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWorkerCalistir.Name = "btnWorkerCalistir";
            this.btnWorkerCalistir.Size = new System.Drawing.Size(157, 28);
            this.btnWorkerCalistir.TabIndex = 5;
            this.btnWorkerCalistir.Text = "Saymaya Başla";
            this.btnWorkerCalistir.UseVisualStyleBackColor = true;
            this.btnWorkerCalistir.Click += new System.EventHandler(this.btnWorkerCalistir_Click);
            // 
            // btnMbox
            // 
            this.btnMbox.Location = new System.Drawing.Point(16, 86);
            this.btnMbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMbox.Name = "btnMbox";
            this.btnMbox.Size = new System.Drawing.Size(157, 28);
            this.btnMbox.TabIndex = 4;
            this.btnMbox.Text = "Mesajı Göster";
            this.btnMbox.UseVisualStyleBackColor = true;
            this.btnMbox.Click += new System.EventHandler(this.btnMbox_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 132);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.btnArkaPlanDegistir);
            this.Controls.Add(this.btnWorkerCalistir);
            this.Controls.Add(this.btnMbox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Button btnArkaPlanDegistir;
        private System.Windows.Forms.Button btnWorkerCalistir;
        private System.Windows.Forms.Button btnMbox;
        private System.Windows.Forms.Timer timer1;
    }
}