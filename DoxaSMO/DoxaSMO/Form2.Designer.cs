namespace DoxaSMO
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDatabases = new System.Windows.Forms.Button();
            this.btnColumns = new System.Windows.Forms.Button();
            this.btnTables = new System.Windows.Forms.Button();
            this.lstDatabases = new System.Windows.Forms.ListBox();
            this.lstTables = new System.Windows.Forms.ListBox();
            this.lstColumns = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstColumns);
            this.groupBox1.Controls.Add(this.lstTables);
            this.groupBox1.Controls.Add(this.lstDatabases);
            this.groupBox1.Controls.Add(this.btnTables);
            this.groupBox1.Controls.Add(this.btnColumns);
            this.groupBox1.Controls.Add(this.btnDatabases);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(772, 473);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DBSmo";
            // 
            // btnDatabases
            // 
            this.btnDatabases.Location = new System.Drawing.Point(67, 409);
            this.btnDatabases.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDatabases.Name = "btnDatabases";
            this.btnDatabases.Size = new System.Drawing.Size(88, 26);
            this.btnDatabases.TabIndex = 0;
            this.btnDatabases.Text = "Databases";
            this.btnDatabases.UseVisualStyleBackColor = true;
            this.btnDatabases.Click += new System.EventHandler(this.btnDatabases_Click);
            // 
            // btnColumns
            // 
            this.btnColumns.Location = new System.Drawing.Point(598, 409);
            this.btnColumns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnColumns.Name = "btnColumns";
            this.btnColumns.Size = new System.Drawing.Size(88, 26);
            this.btnColumns.TabIndex = 1;
            this.btnColumns.Text = "Columns";
            this.btnColumns.UseVisualStyleBackColor = true;
            this.btnColumns.Click += new System.EventHandler(this.btnColumns_Click);
            // 
            // btnTables
            // 
            this.btnTables.Location = new System.Drawing.Point(328, 409);
            this.btnTables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTables.Name = "btnTables";
            this.btnTables.Size = new System.Drawing.Size(88, 26);
            this.btnTables.TabIndex = 2;
            this.btnTables.Text = "Tables";
            this.btnTables.UseVisualStyleBackColor = true;
            this.btnTables.Click += new System.EventHandler(this.btnTables_Click);
            // 
            // lstDatabases
            // 
            this.lstDatabases.FormattingEnabled = true;
            this.lstDatabases.ItemHeight = 15;
            this.lstDatabases.Location = new System.Drawing.Point(7, 22);
            this.lstDatabases.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstDatabases.Name = "lstDatabases";
            this.lstDatabases.Size = new System.Drawing.Size(245, 379);
            this.lstDatabases.TabIndex = 3;
            // 
            // lstTables
            // 
            this.lstTables.FormattingEnabled = true;
            this.lstTables.ItemHeight = 15;
            this.lstTables.Location = new System.Drawing.Point(259, 22);
            this.lstTables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstTables.Name = "lstTables";
            this.lstTables.Size = new System.Drawing.Size(245, 379);
            this.lstTables.TabIndex = 4;
            // 
            // lstColumns
            // 
            this.lstColumns.FormattingEnabled = true;
            this.lstColumns.ItemHeight = 15;
            this.lstColumns.Location = new System.Drawing.Point(511, 22);
            this.lstColumns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstColumns.Name = "lstColumns";
            this.lstColumns.Size = new System.Drawing.Size(245, 379);
            this.lstColumns.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 502);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTables;
        private System.Windows.Forms.Button btnColumns;
        private System.Windows.Forms.Button btnDatabases;
        private System.Windows.Forms.ListBox lstColumns;
        private System.Windows.Forms.ListBox lstTables;
        private System.Windows.Forms.ListBox lstDatabases;
    }
}