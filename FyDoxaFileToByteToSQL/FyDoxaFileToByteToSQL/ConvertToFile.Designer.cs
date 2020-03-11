namespace FyDoxaFileToByteToSQL
{
    partial class ConvertToFile
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
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.cmbFilesName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveToFile.Location = new System.Drawing.Point(12, 12);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(178, 43);
            this.btnSaveToFile.TabIndex = 1;
            this.btnSaveToFile.Text = "Save To File";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbFilesName
            // 
            this.cmbFilesName.FormattingEnabled = true;
            this.cmbFilesName.Location = new System.Drawing.Point(12, 61);
            this.cmbFilesName.Name = "cmbFilesName";
            this.cmbFilesName.Size = new System.Drawing.Size(178, 21);
            this.cmbFilesName.TabIndex = 2;
            // 
            // ConvertToFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 303);
            this.Controls.Add(this.cmbFilesName);
            this.Controls.Add(this.btnSaveToFile);
            this.Name = "ConvertToFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConvertToFile";
            this.Load += new System.EventHandler(this.ConvertToFile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.ComboBox cmbFilesName;
    }
}