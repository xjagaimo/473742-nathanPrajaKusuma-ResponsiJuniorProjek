namespace Responsi2
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
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblNamaKaryawan = new System.Windows.Forms.Label();
            this.lblDepKaryawan = new System.Windows.Forms.Label();
            this.tbNamaKaryawan = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cbDepKaryawan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(64, 22);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(27, 13);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "logo";
            // 
            // lblNamaKaryawan
            // 
            this.lblNamaKaryawan.AutoSize = true;
            this.lblNamaKaryawan.Location = new System.Drawing.Point(33, 67);
            this.lblNamaKaryawan.Name = "lblNamaKaryawan";
            this.lblNamaKaryawan.Size = new System.Drawing.Size(88, 13);
            this.lblNamaKaryawan.TabIndex = 1;
            this.lblNamaKaryawan.Text = "Nama Karyawan:";
            // 
            // lblDepKaryawan
            // 
            this.lblDepKaryawan.AutoSize = true;
            this.lblDepKaryawan.Location = new System.Drawing.Point(36, 115);
            this.lblDepKaryawan.Name = "lblDepKaryawan";
            this.lblDepKaryawan.Size = new System.Drawing.Size(83, 13);
            this.lblDepKaryawan.TabIndex = 2;
            this.lblDepKaryawan.Text = "Dep. Karyawan:";
            // 
            // tbNamaKaryawan
            // 
            this.tbNamaKaryawan.Location = new System.Drawing.Point(128, 67);
            this.tbNamaKaryawan.Name = "tbNamaKaryawan";
            this.tbNamaKaryawan.Size = new System.Drawing.Size(121, 20);
            this.tbNamaKaryawan.TabIndex = 3;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(36, 174);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(245, 174);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(451, 174);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(21, 216);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(569, 188);
            this.dgv.TabIndex = 7;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(451, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "ID Departemen:\nHR: HR\nENG: Engineer\nDEV: Developer\nPM: Product M\nFIN: Finance";
            // 
            // cbDepKaryawan
            // 
            this.cbDepKaryawan.FormattingEnabled = true;
            this.cbDepKaryawan.Items.AddRange(new object[] {
            "HR",
            "ENG",
            "DEV",
            "PM",
            "FIN"});
            this.cbDepKaryawan.Location = new System.Drawing.Point(128, 112);
            this.cbDepKaryawan.Name = "cbDepKaryawan";
            this.cbDepKaryawan.Size = new System.Drawing.Size(121, 21);
            this.cbDepKaryawan.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.cbDepKaryawan);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tbNamaKaryawan);
            this.Controls.Add(this.lblDepKaryawan);
            this.Controls.Add(this.lblNamaKaryawan);
            this.Controls.Add(this.lblLogo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblNamaKaryawan;
        private System.Windows.Forms.Label lblDepKaryawan;
        private System.Windows.Forms.TextBox tbNamaKaryawan;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox cbDepKaryawan;
    }
}

