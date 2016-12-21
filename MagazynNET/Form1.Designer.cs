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
            this.wyszamowieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wysZamowienia = new MagazynNET.wysZamowienia();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.klienciView = new System.Windows.Forms.DataGridView();
            this.nazwafirmyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejscowoscDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.krajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazynDataSet = new MagazynNET.magazynDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.klient_button_zapisz_zmiany = new System.Windows.Forms.Button();
            this.klient_button_dodaj = new System.Windows.Forms.Button();
            this.klient_button_filtruj = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.klient_adres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.klient_kraj = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.klient_miejscowosc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.klient_telefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.klient_firma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.klient_nazwisko = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.klient_imie = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.wys_zamowieniaTableAdapter = new MagazynNET.wysZamowieniaTableAdapters.wys_zamowieniaTableAdapter();
            this.wysZamowienia1 = new MagazynNET.wysZamowienia();
            this.klienciTableAdapter = new MagazynNET.magazynDataSetTableAdapters.KlienciTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyszamowieniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wysZamowienia)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klienciView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wysZamowienia1)).BeginInit();
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
            // wyszamowieniaBindingSource
            // 
            this.wyszamowieniaBindingSource.DataMember = "wys_zamowienia";
            this.wyszamowieniaBindingSource.DataSource = this.wysZamowienia;
            // 
            // wysZamowienia
            // 
            this.wysZamowienia.DataSetName = "wysZamowienia";
            this.wysZamowienia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.klienciView);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1129, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Klienci";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // klienciView
            // 
            this.klienciView.AutoGenerateColumns = false;
            this.klienciView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.klienciView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.klienciView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwafirmyDataGridViewTextBoxColumn1,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.miejscowoscDataGridViewTextBoxColumn1,
            this.krajDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn1});
            this.klienciView.DataSource = this.klienciBindingSource;
            this.klienciView.Location = new System.Drawing.Point(6, 6);
            this.klienciView.Name = "klienciView";
            this.klienciView.Size = new System.Drawing.Size(752, 542);
            this.klienciView.TabIndex = 2;
            // 
            // nazwafirmyDataGridViewTextBoxColumn1
            // 
            this.nazwafirmyDataGridViewTextBoxColumn1.DataPropertyName = "nazwa_firmy";
            this.nazwafirmyDataGridViewTextBoxColumn1.HeaderText = "Firma";
            this.nazwafirmyDataGridViewTextBoxColumn1.Name = "nazwafirmyDataGridViewTextBoxColumn1";
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imię";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // miejscowoscDataGridViewTextBoxColumn1
            // 
            this.miejscowoscDataGridViewTextBoxColumn1.DataPropertyName = "miejscowosc";
            this.miejscowoscDataGridViewTextBoxColumn1.HeaderText = "Miejscowość";
            this.miejscowoscDataGridViewTextBoxColumn1.Name = "miejscowoscDataGridViewTextBoxColumn1";
            // 
            // krajDataGridViewTextBoxColumn
            // 
            this.krajDataGridViewTextBoxColumn.DataPropertyName = "kraj";
            this.krajDataGridViewTextBoxColumn.HeaderText = "Kraj";
            this.krajDataGridViewTextBoxColumn.Name = "krajDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn1
            // 
            this.adresDataGridViewTextBoxColumn1.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn1.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn1.Name = "adresDataGridViewTextBoxColumn1";
            // 
            // klienciBindingSource
            // 
            this.klienciBindingSource.DataMember = "Klienci";
            this.klienciBindingSource.DataSource = this.magazynDataSet;
            // 
            // magazynDataSet
            // 
            this.magazynDataSet.DataSetName = "magazynDataSet";
            this.magazynDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.klient_button_filtruj);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.klient_adres);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.klient_kraj);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.klient_miejscowosc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.klient_telefon);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.klient_firma);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.klient_nazwisko);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.klient_imie);
            this.groupBox2.Location = new System.Drawing.Point(764, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 542);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.klient_button_zapisz_zmiany);
            this.groupBox4.Controls.Add(this.klient_button_dodaj);
            this.groupBox4.Location = new System.Drawing.Point(172, 330);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(181, 206);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Modyfikacja";
            // 
            // klient_button_zapisz_zmiany
            // 
            this.klient_button_zapisz_zmiany.Location = new System.Drawing.Point(48, 116);
            this.klient_button_zapisz_zmiany.Name = "klient_button_zapisz_zmiany";
            this.klient_button_zapisz_zmiany.Size = new System.Drawing.Size(95, 38);
            this.klient_button_zapisz_zmiany.TabIndex = 19;
            this.klient_button_zapisz_zmiany.Text = "Zapisz zmiany";
            this.klient_button_zapisz_zmiany.UseVisualStyleBackColor = true;
            // 
            // klient_button_dodaj
            // 
            this.klient_button_dodaj.Location = new System.Drawing.Point(48, 45);
            this.klient_button_dodaj.Name = "klient_button_dodaj";
            this.klient_button_dodaj.Size = new System.Drawing.Size(95, 38);
            this.klient_button_dodaj.TabIndex = 18;
            this.klient_button_dodaj.Text = "Dodaj klienta";
            this.klient_button_dodaj.UseVisualStyleBackColor = true;
            this.klient_button_dodaj.Click += new System.EventHandler(this.klient_button_dodaj_Click);
            // 
            // klient_button_filtruj
            // 
            this.klient_button_filtruj.Location = new System.Drawing.Point(33, 330);
            this.klient_button_filtruj.Name = "klient_button_filtruj";
            this.klient_button_filtruj.Size = new System.Drawing.Size(95, 38);
            this.klient_button_filtruj.TabIndex = 16;
            this.klient_button_filtruj.Text = "Filtruj";
            this.klient_button_filtruj.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Adres";
            // 
            // klient_adres
            // 
            this.klient_adres.Location = new System.Drawing.Point(103, 260);
            this.klient_adres.Name = "klient_adres";
            this.klient_adres.Size = new System.Drawing.Size(212, 20);
            this.klient_adres.TabIndex = 12;
            this.klient_adres.TextChanged += new System.EventHandler(this.klient_imie_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kraj";
            // 
            // klient_kraj
            // 
            this.klient_kraj.Location = new System.Drawing.Point(103, 221);
            this.klient_kraj.Name = "klient_kraj";
            this.klient_kraj.Size = new System.Drawing.Size(212, 20);
            this.klient_kraj.TabIndex = 10;
            this.klient_kraj.TextChanged += new System.EventHandler(this.klient_imie_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Miejscowość";
            // 
            // klient_miejscowosc
            // 
            this.klient_miejscowosc.Location = new System.Drawing.Point(103, 178);
            this.klient_miejscowosc.Name = "klient_miejscowosc";
            this.klient_miejscowosc.Size = new System.Drawing.Size(212, 20);
            this.klient_miejscowosc.TabIndex = 8;
            this.klient_miejscowosc.TextChanged += new System.EventHandler(this.klient_imie_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefon";
            // 
            // klient_telefon
            // 
            this.klient_telefon.Location = new System.Drawing.Point(103, 143);
            this.klient_telefon.Name = "klient_telefon";
            this.klient_telefon.Size = new System.Drawing.Size(212, 20);
            this.klient_telefon.TabIndex = 6;
            this.klient_telefon.TextChanged += new System.EventHandler(this.klient_imie_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Firma";
            // 
            // klient_firma
            // 
            this.klient_firma.Location = new System.Drawing.Point(103, 107);
            this.klient_firma.Name = "klient_firma";
            this.klient_firma.Size = new System.Drawing.Size(212, 20);
            this.klient_firma.TabIndex = 4;
            this.klient_firma.TextChanged += new System.EventHandler(this.klient_imie_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko";
            // 
            // klient_nazwisko
            // 
            this.klient_nazwisko.Location = new System.Drawing.Point(103, 68);
            this.klient_nazwisko.Name = "klient_nazwisko";
            this.klient_nazwisko.Size = new System.Drawing.Size(212, 20);
            this.klient_nazwisko.TabIndex = 2;
            this.klient_nazwisko.TextChanged += new System.EventHandler(this.klient_imie_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imię";
            // 
            // klient_imie
            // 
            this.klient_imie.Location = new System.Drawing.Point(103, 29);
            this.klient_imie.Name = "klient_imie";
            this.klient_imie.Size = new System.Drawing.Size(212, 20);
            this.klient_imie.TabIndex = 0;
            this.klient_imie.TextChanged += new System.EventHandler(this.klient_imie_TextChanged);
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
            // wys_zamowieniaTableAdapter
            // 
            this.wys_zamowieniaTableAdapter.ClearBeforeFill = true;
            // 
            // wysZamowienia1
            // 
            this.wysZamowienia1.DataSetName = "wysZamowienia";
            this.wysZamowienia1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klienciTableAdapter
            // 
            this.klienciTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyszamowieniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wysZamowienia)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.klienciView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wysZamowienia1)).EndInit();
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
        private System.Windows.Forms.DataGridView klienciView;
        private magazynDataSet magazynDataSet;
        private System.Windows.Forms.BindingSource klienciBindingSource;
        private magazynDataSetTableAdapters.KlienciTableAdapter klienciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwafirmyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miejscowoscDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn krajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox klient_imie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox klient_kraj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox klient_miejscowosc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox klient_telefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox klient_firma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox klient_nazwisko;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button klient_button_zapisz_zmiany;
        private System.Windows.Forms.Button klient_button_dodaj;
        private System.Windows.Forms.Button klient_button_filtruj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox klient_adres;
    }
}

