namespace HRLex
{
    partial class Main
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
            this.tcSwitch = new System.Windows.Forms.TabControl();
            this.t1 = new System.Windows.Forms.TabPage();
            this.pFilterCombo = new System.Windows.Forms.ComboBox();
            this.rbPfilter2 = new System.Windows.Forms.RadioButton();
            this.rbPfilter1 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIdentityNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDealNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t2 = new System.Windows.Forms.TabPage();
            this.pButton1 = new System.Windows.Forms.Button();
            this.pButton2 = new System.Windows.Forms.Button();
            this.pButton3 = new System.Windows.Forms.Button();
            this.tcSwitch.SuspendLayout();
            this.t1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcSwitch
            // 
            this.tcSwitch.Controls.Add(this.t1);
            this.tcSwitch.Controls.Add(this.t2);
            this.tcSwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSwitch.Location = new System.Drawing.Point(0, 0);
            this.tcSwitch.Name = "tcSwitch";
            this.tcSwitch.SelectedIndex = 0;
            this.tcSwitch.Size = new System.Drawing.Size(1038, 456);
            this.tcSwitch.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcSwitch.TabIndex = 0;
            // 
            // t1
            // 
            this.t1.BackColor = System.Drawing.SystemColors.Control;
            this.t1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.t1.Controls.Add(this.pButton3);
            this.t1.Controls.Add(this.pButton2);
            this.t1.Controls.Add(this.pButton1);
            this.t1.Controls.Add(this.pFilterCombo);
            this.t1.Controls.Add(this.rbPfilter2);
            this.t1.Controls.Add(this.rbPfilter1);
            this.t1.Controls.Add(this.dataGridView1);
            this.t1.Location = new System.Drawing.Point(4, 22);
            this.t1.Name = "t1";
            this.t1.Padding = new System.Windows.Forms.Padding(3);
            this.t1.Size = new System.Drawing.Size(1030, 430);
            this.t1.TabIndex = 0;
            this.t1.Text = "Pracownicy";
            // 
            // pFilterCombo
            // 
            this.pFilterCombo.FormattingEnabled = true;
            this.pFilterCombo.Location = new System.Drawing.Point(110, 22);
            this.pFilterCombo.Name = "pFilterCombo";
            this.pFilterCombo.Size = new System.Drawing.Size(189, 21);
            this.pFilterCombo.TabIndex = 3;
            // 
            // rbPfilter2
            // 
            this.rbPfilter2.AutoSize = true;
            this.rbPfilter2.Location = new System.Drawing.Point(0, 33);
            this.rbPfilter2.Name = "rbPfilter2";
            this.rbPfilter2.Size = new System.Drawing.Size(85, 17);
            this.rbPfilter2.TabIndex = 2;
            this.rbPfilter2.TabStop = true;
            this.rbPfilter2.Text = "Narodowość";
            this.rbPfilter2.UseVisualStyleBackColor = true;
            // 
            // rbPfilter1
            // 
            this.rbPfilter1.AutoSize = true;
            this.rbPfilter1.Location = new System.Drawing.Point(0, 10);
            this.rbPfilter1.Name = "rbPfilter1";
            this.rbPfilter1.Size = new System.Drawing.Size(104, 17);
            this.rbPfilter1.TabIndex = 1;
            this.rbPfilter1.TabStop = true;
            this.rbPfilter1.Text = "Przedsiębiorstwo";
            this.rbPfilter1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pName,
            this.pSurname,
            this.pBirthDate,
            this.pNationality,
            this.pIdentityNumber,
            this.pCompany,
            this.pDealNumber});
            this.dataGridView1.Location = new System.Drawing.Point(0, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1030, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // pName
            // 
            this.pName.HeaderText = "Imie";
            this.pName.Name = "pName";
            // 
            // pSurname
            // 
            this.pSurname.HeaderText = "Nazwisko";
            this.pSurname.Name = "pSurname";
            this.pSurname.ReadOnly = true;
            // 
            // pBirthDate
            // 
            this.pBirthDate.HeaderText = "Data Urodzenia";
            this.pBirthDate.Name = "pBirthDate";
            this.pBirthDate.ReadOnly = true;
            // 
            // pNationality
            // 
            this.pNationality.HeaderText = "Narodowość";
            this.pNationality.Name = "pNationality";
            this.pNationality.ReadOnly = true;
            // 
            // pIdentityNumber
            // 
            this.pIdentityNumber.HeaderText = "Identfikator";
            this.pIdentityNumber.Name = "pIdentityNumber";
            this.pIdentityNumber.ReadOnly = true;
            // 
            // pCompany
            // 
            this.pCompany.HeaderText = "Przedsiębiorstwo";
            this.pCompany.Name = "pCompany";
            this.pCompany.ReadOnly = true;
            // 
            // pDealNumber
            // 
            this.pDealNumber.HeaderText = "Numer Umowy";
            this.pDealNumber.Name = "pDealNumber";
            this.pDealNumber.ReadOnly = true;
            // 
            // t2
            // 
            this.t2.BackColor = System.Drawing.SystemColors.Control;
            this.t2.Location = new System.Drawing.Point(4, 22);
            this.t2.Name = "t2";
            this.t2.Padding = new System.Windows.Forms.Padding(3);
            this.t2.Size = new System.Drawing.Size(1030, 430);
            this.t2.TabIndex = 1;
            this.t2.Text = "Przedsiębiorstwa";
            // 
            // pButton1
            // 
            this.pButton1.Location = new System.Drawing.Point(860, 7);
            this.pButton1.Name = "pButton1";
            this.pButton1.Size = new System.Drawing.Size(164, 23);
            this.pButton1.TabIndex = 4;
            this.pButton1.Text = "Dodaj";
            this.pButton1.UseVisualStyleBackColor = true;
            // 
            // pButton2
            // 
            this.pButton2.Location = new System.Drawing.Point(860, 33);
            this.pButton2.Name = "pButton2";
            this.pButton2.Size = new System.Drawing.Size(164, 23);
            this.pButton2.TabIndex = 5;
            this.pButton2.Text = "Edytuj";
            this.pButton2.UseVisualStyleBackColor = true;
            // 
            // pButton3
            // 
            this.pButton3.Location = new System.Drawing.Point(690, 33);
            this.pButton3.Name = "pButton3";
            this.pButton3.Size = new System.Drawing.Size(164, 23);
            this.pButton3.TabIndex = 6;
            this.pButton3.Text = "Usuń";
            this.pButton3.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1038, 456);
            this.Controls.Add(this.tcSwitch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HRLex";
            this.tcSwitch.ResumeLayout(false);
            this.t1.ResumeLayout(false);
            this.t1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcSwitch;
        private System.Windows.Forms.TabPage t1;
        private System.Windows.Forms.TabPage t2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbPfilter2;
        private System.Windows.Forms.RadioButton rbPfilter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIdentityNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDealNumber;
        private System.Windows.Forms.ComboBox pFilterCombo;
        private System.Windows.Forms.Button pButton3;
        private System.Windows.Forms.Button pButton2;
        private System.Windows.Forms.Button pButton1;
    }
}

