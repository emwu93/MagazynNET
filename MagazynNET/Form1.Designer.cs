namespace MagazynNET
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.wysZamowienia = new MagazynNET.wysZamowienia();
            this.wyszamowieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wys_zamowieniaTableAdapter = new MagazynNET.wysZamowieniaTableAdapters.wys_zamowieniaTableAdapter();
            this.wysZamowienia1 = new MagazynNET.wysZamowienia();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idzamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pracownikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwafirmyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieINazwiskoKilentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejscowoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenazasztDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kwotaDoZaplatyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wysZamowienia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyszamowieniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wysZamowienia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1137, 580);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1129, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Zamówienia";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1129, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Klienci";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(-4, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1137, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(675, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 542);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1129, 554);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pracownicy";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(675, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(447, 542);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1129, 554);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // wysZamowienia
            // 
            this.wysZamowienia.DataSetName = "wysZamowienia";
            this.wysZamowienia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wyszamowieniaBindingSource
            // 
            this.wyszamowieniaBindingSource.DataMember = "wys_zamowienia";
            this.wyszamowieniaBindingSource.DataSource = this.wysZamowienia;
            // 
            // wys_zamowieniaTableAdapter
            // 
            this.wys_zamowieniaTableAdapter.ClearBeforeFill = true;
            // 
            // wysZamowienia1
            // 
            this.wysZamowienia1.DataSetName = "wysZamowienia";
            this.wysZamowienia1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idzamDataGridViewTextBoxColumn,
            this.pracownikDataGridViewTextBoxColumn,
            this.nazwafirmyDataGridViewTextBoxColumn,
            this.imieINazwiskoKilentaDataGridViewTextBoxColumn,
            this.miejscowoscDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.cenazasztDataGridViewTextBoxColumn,
            this.iloscDataGridViewTextBoxColumn,
            this.kwotaDoZaplatyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wyszamowieniaBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(6, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.Size = new System.Drawing.Size(1117, 318);
            this.dataGridView1.TabIndex = 1;
            // 
            // idzamDataGridViewTextBoxColumn
            // 
            this.idzamDataGridViewTextBoxColumn.DataPropertyName = "id_zam";
            this.idzamDataGridViewTextBoxColumn.HeaderText = "Nr zamówienia";
            this.idzamDataGridViewTextBoxColumn.Name = "idzamDataGridViewTextBoxColumn";
            this.idzamDataGridViewTextBoxColumn.ReadOnly = true;
            this.idzamDataGridViewTextBoxColumn.Width = 105;
            // 
            // pracownikDataGridViewTextBoxColumn
            // 
            this.pracownikDataGridViewTextBoxColumn.DataPropertyName = "Pracownik";
            this.pracownikDataGridViewTextBoxColumn.HeaderText = "Pracownik";
            this.pracownikDataGridViewTextBoxColumn.Name = "pracownikDataGridViewTextBoxColumn";
            this.pracownikDataGridViewTextBoxColumn.ReadOnly = true;
            this.pracownikDataGridViewTextBoxColumn.Width = 145;
            // 
            // nazwafirmyDataGridViewTextBoxColumn
            // 
            this.nazwafirmyDataGridViewTextBoxColumn.DataPropertyName = "nazwa_firmy";
            this.nazwafirmyDataGridViewTextBoxColumn.HeaderText = "Nazwa firmy";
            this.nazwafirmyDataGridViewTextBoxColumn.Name = "nazwafirmyDataGridViewTextBoxColumn";
            this.nazwafirmyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imieINazwiskoKilentaDataGridViewTextBoxColumn
            // 
            this.imieINazwiskoKilentaDataGridViewTextBoxColumn.DataPropertyName = "Imie i nazwisko kilenta";
            this.imieINazwiskoKilentaDataGridViewTextBoxColumn.HeaderText = "Imie i nazwisko kilenta";
            this.imieINazwiskoKilentaDataGridViewTextBoxColumn.Name = "imieINazwiskoKilentaDataGridViewTextBoxColumn";
            this.imieINazwiskoKilentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.imieINazwiskoKilentaDataGridViewTextBoxColumn.Width = 150;
            // 
            // miejscowoscDataGridViewTextBoxColumn
            // 
            this.miejscowoscDataGridViewTextBoxColumn.DataPropertyName = "miejscowosc";
            this.miejscowoscDataGridViewTextBoxColumn.HeaderText = "Miejscowość";
            this.miejscowoscDataGridViewTextBoxColumn.Name = "miejscowoscDataGridViewTextBoxColumn";
            this.miejscowoscDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresDataGridViewTextBoxColumn.Width = 120;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa produktu";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cenazasztDataGridViewTextBoxColumn
            // 
            this.cenazasztDataGridViewTextBoxColumn.DataPropertyName = "cena_za_szt";
            this.cenazasztDataGridViewTextBoxColumn.HeaderText = "Cena za szt/kg";
            this.cenazasztDataGridViewTextBoxColumn.Name = "cenazasztDataGridViewTextBoxColumn";
            this.cenazasztDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iloscDataGridViewTextBoxColumn
            // 
            this.iloscDataGridViewTextBoxColumn.DataPropertyName = "ilosc";
            this.iloscDataGridViewTextBoxColumn.HeaderText = "Ilość";
            this.iloscDataGridViewTextBoxColumn.Name = "iloscDataGridViewTextBoxColumn";
            this.iloscDataGridViewTextBoxColumn.ReadOnly = true;
            this.iloscDataGridViewTextBoxColumn.Width = 50;
            // 
            // kwotaDoZaplatyDataGridViewTextBoxColumn
            // 
            this.kwotaDoZaplatyDataGridViewTextBoxColumn.DataPropertyName = "Kwota do zaplaty";
            this.kwotaDoZaplatyDataGridViewTextBoxColumn.HeaderText = "Kwota do zapłaty";
            this.kwotaDoZaplatyDataGridViewTextBoxColumn.Name = "kwotaDoZaplatyDataGridViewTextBoxColumn";
            this.kwotaDoZaplatyDataGridViewTextBoxColumn.ReadOnly = true;
            this.kwotaDoZaplatyDataGridViewTextBoxColumn.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 604);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wysZamowienia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyszamowieniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wysZamowienia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabPage4;
        private wysZamowienia wysZamowienia;
        private System.Windows.Forms.BindingSource wyszamowieniaBindingSource;
        private wysZamowieniaTableAdapters.wys_zamowieniaTableAdapter wys_zamowieniaTableAdapter;
        private wysZamowienia wysZamowienia1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pracownikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwafirmyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieINazwiskoKilentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miejscowoscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenazasztDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kwotaDoZaplatyDataGridViewTextBoxColumn;
    }
}

