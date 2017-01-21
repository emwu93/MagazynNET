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
            this.klienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazynDataSet = new MagazynNET.magazynDataSet();
            this.klienciTableAdapter = new MagazynNET.magazynDataSetTableAdapters.KlienciTableAdapter();
            this.magazynDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazynDataSet1 = new MagazynNET.magazynDataSet1();
            this.produktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktyTableAdapter = new MagazynNET.magazynDataSet1TableAdapters.ProduktyTableAdapter();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.produktyView = new System.Windows.Forms.DataGridView();
            this.nazwaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.krajpochodzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenazasztDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamowionailoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.produkt_button_zapisz = new System.Windows.Forms.Button();
            this.produkt_button_dodaj = new System.Windows.Forms.Button();
            this.produkt_filtruj = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.produkt_zamowiona = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.produkt_cena = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.produkt_kraj = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.produkt_ilenastanie = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.produkt_producent = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.produkt_nazwa = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.klienciView = new System.Windows.Forms.DataGridView();
            this.nazwafirmyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejscowoscDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.krajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idzamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datazamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwafirmyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejscowoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenazasztDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wyszamowieniaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.magazynDataSet2 = new MagazynNET.magazynDataSet2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Zamowienie_nazwa_produktu = new System.Windows.Forms.ComboBox();
            this.Zamowienie_ilosc = new System.Windows.Forms.NumericUpDown();
            this.Zamowienie_adres = new System.Windows.Forms.ComboBox();
            this.zamowienie_numer = new System.Windows.Forms.NumericUpDown();
            this.Zamowienie_dodaj = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.wyszamowieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wysZamowienia = new MagazynNET.wysZamowienia();
            this.wys_zamowieniaTableAdapter = new MagazynNET.wysZamowieniaTableAdapters.wys_zamowieniaTableAdapter();
            this.wysZamowienia1 = new MagazynNET.wysZamowienia();
            this.wys_zamowieniaTableAdapter1 = new MagazynNET.magazynDataSet2TableAdapters.wys_zamowieniaTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produktyView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klienciView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyszamowieniaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zamowienie_ilosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienie_numer)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wyszamowieniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wysZamowienia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wysZamowienia1)).BeginInit();
            this.SuspendLayout();
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
            // klienciTableAdapter
            // 
            this.klienciTableAdapter.ClearBeforeFill = true;
            // 
            // magazynDataSetBindingSource
            // 
            this.magazynDataSetBindingSource.DataSource = this.magazynDataSet;
            this.magazynDataSetBindingSource.Position = 0;
            // 
            // magazynDataSet1
            // 
            this.magazynDataSet1.DataSetName = "magazynDataSet1";
            this.magazynDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produktyBindingSource
            // 
            this.produktyBindingSource.DataMember = "Produkty";
            this.produktyBindingSource.DataSource = this.magazynDataSet1;
            // 
            // produktyTableAdapter
            // 
            this.produktyTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.produktyView);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1129, 554);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Produkty";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // produktyView
            // 
            this.produktyView.AllowUserToAddRows = false;
            this.produktyView.AllowUserToDeleteRows = false;
            this.produktyView.AutoGenerateColumns = false;
            this.produktyView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produktyView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwaDataGridViewTextBoxColumn1,
            this.producentDataGridViewTextBoxColumn,
            this.iloscDataGridViewTextBoxColumn1,
            this.krajpochodzeniaDataGridViewTextBoxColumn,
            this.cenazasztDataGridViewTextBoxColumn1,
            this.zamowionailoscDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.produktyView.DataSource = this.produktyBindingSource;
            this.produktyView.Location = new System.Drawing.Point(0, 6);
            this.produktyView.Name = "produktyView";
            this.produktyView.ReadOnly = true;
            this.produktyView.Size = new System.Drawing.Size(666, 524);
            this.produktyView.TabIndex = 3;
            this.produktyView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produktyView_CellClick);
            // 
            // nazwaDataGridViewTextBoxColumn1
            // 
            this.nazwaDataGridViewTextBoxColumn1.DataPropertyName = "nazwa";
            this.nazwaDataGridViewTextBoxColumn1.HeaderText = "Nazwa produktu";
            this.nazwaDataGridViewTextBoxColumn1.Name = "nazwaDataGridViewTextBoxColumn1";
            this.nazwaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // producentDataGridViewTextBoxColumn
            // 
            this.producentDataGridViewTextBoxColumn.DataPropertyName = "producent";
            this.producentDataGridViewTextBoxColumn.HeaderText = "Producent";
            this.producentDataGridViewTextBoxColumn.Name = "producentDataGridViewTextBoxColumn";
            this.producentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iloscDataGridViewTextBoxColumn1
            // 
            this.iloscDataGridViewTextBoxColumn1.DataPropertyName = "ilosc";
            this.iloscDataGridViewTextBoxColumn1.HeaderText = "Ilość na stanie";
            this.iloscDataGridViewTextBoxColumn1.Name = "iloscDataGridViewTextBoxColumn1";
            this.iloscDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // krajpochodzeniaDataGridViewTextBoxColumn
            // 
            this.krajpochodzeniaDataGridViewTextBoxColumn.DataPropertyName = "kraj_pochodzenia";
            this.krajpochodzeniaDataGridViewTextBoxColumn.HeaderText = "Kraj pochodzenia";
            this.krajpochodzeniaDataGridViewTextBoxColumn.Name = "krajpochodzeniaDataGridViewTextBoxColumn";
            this.krajpochodzeniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cenazasztDataGridViewTextBoxColumn1
            // 
            this.cenazasztDataGridViewTextBoxColumn1.DataPropertyName = "cena_za_szt";
            this.cenazasztDataGridViewTextBoxColumn1.HeaderText = "Cena za szt/kg";
            this.cenazasztDataGridViewTextBoxColumn1.Name = "cenazasztDataGridViewTextBoxColumn1";
            this.cenazasztDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // zamowionailoscDataGridViewTextBoxColumn
            // 
            this.zamowionailoscDataGridViewTextBoxColumn.DataPropertyName = "zamowiona_ilosc";
            this.zamowionailoscDataGridViewTextBoxColumn.HeaderText = "Zamowiona ilość";
            this.zamowionailoscDataGridViewTextBoxColumn.Name = "zamowionailoscDataGridViewTextBoxColumn";
            this.zamowionailoscDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.produkt_filtruj);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.produkt_zamowiona);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.produkt_cena);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.produkt_kraj);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.produkt_ilenastanie);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.produkt_producent);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.produkt_nazwa);
            this.groupBox3.Location = new System.Drawing.Point(679, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(447, 542);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.produkt_button_zapisz);
            this.groupBox5.Controls.Add(this.produkt_button_dodaj);
            this.groupBox5.Location = new System.Drawing.Point(204, 319);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(181, 206);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Modyfikacja";
            // 
            // produkt_button_zapisz
            // 
            this.produkt_button_zapisz.Location = new System.Drawing.Point(48, 116);
            this.produkt_button_zapisz.Name = "produkt_button_zapisz";
            this.produkt_button_zapisz.Size = new System.Drawing.Size(95, 38);
            this.produkt_button_zapisz.TabIndex = 19;
            this.produkt_button_zapisz.Text = "Zapisz zmiany";
            this.produkt_button_zapisz.UseVisualStyleBackColor = true;
            this.produkt_button_zapisz.Click += new System.EventHandler(this.produkt_button_zapisz_Click);
            // 
            // produkt_button_dodaj
            // 
            this.produkt_button_dodaj.Enabled = false;
            this.produkt_button_dodaj.Location = new System.Drawing.Point(48, 45);
            this.produkt_button_dodaj.Name = "produkt_button_dodaj";
            this.produkt_button_dodaj.Size = new System.Drawing.Size(95, 38);
            this.produkt_button_dodaj.TabIndex = 18;
            this.produkt_button_dodaj.Text = "Dodaj produkt";
            this.produkt_button_dodaj.UseVisualStyleBackColor = true;
            this.produkt_button_dodaj.Click += new System.EventHandler(this.produkt_button_dodaj_Click);
            // 
            // produkt_filtruj
            // 
            this.produkt_filtruj.Location = new System.Drawing.Point(65, 319);
            this.produkt_filtruj.Name = "produkt_filtruj";
            this.produkt_filtruj.Size = new System.Drawing.Size(95, 38);
            this.produkt_filtruj.TabIndex = 32;
            this.produkt_filtruj.Text = "Filtruj";
            this.produkt_filtruj.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Zamówiona ilość";
            // 
            // produkt_zamowiona
            // 
            this.produkt_zamowiona.Location = new System.Drawing.Point(135, 230);
            this.produkt_zamowiona.Name = "produkt_zamowiona";
            this.produkt_zamowiona.Size = new System.Drawing.Size(212, 20);
            this.produkt_zamowiona.TabIndex = 28;
            this.produkt_zamowiona.TextChanged += new System.EventHandler(this.produkt_nazwa_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Cena za szt/kg";
            // 
            // produkt_cena
            // 
            this.produkt_cena.Location = new System.Drawing.Point(135, 187);
            this.produkt_cena.Name = "produkt_cena";
            this.produkt_cena.Size = new System.Drawing.Size(212, 20);
            this.produkt_cena.TabIndex = 26;
            this.produkt_cena.TextChanged += new System.EventHandler(this.produkt_nazwa_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Kraj pochodzenia";
            // 
            // produkt_kraj
            // 
            this.produkt_kraj.Location = new System.Drawing.Point(135, 152);
            this.produkt_kraj.Name = "produkt_kraj";
            this.produkt_kraj.Size = new System.Drawing.Size(212, 20);
            this.produkt_kraj.TabIndex = 24;
            this.produkt_kraj.TextChanged += new System.EventHandler(this.produkt_nazwa_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Ilość na stanie";
            // 
            // produkt_ilenastanie
            // 
            this.produkt_ilenastanie.Location = new System.Drawing.Point(135, 116);
            this.produkt_ilenastanie.Name = "produkt_ilenastanie";
            this.produkt_ilenastanie.Size = new System.Drawing.Size(212, 20);
            this.produkt_ilenastanie.TabIndex = 22;
            this.produkt_ilenastanie.TextChanged += new System.EventHandler(this.produkt_nazwa_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Producent";
            // 
            // produkt_producent
            // 
            this.produkt_producent.Location = new System.Drawing.Point(135, 77);
            this.produkt_producent.Name = "produkt_producent";
            this.produkt_producent.Size = new System.Drawing.Size(212, 20);
            this.produkt_producent.TabIndex = 20;
            this.produkt_producent.TextChanged += new System.EventHandler(this.produkt_nazwa_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Nazwa produktu";
            // 
            // produkt_nazwa
            // 
            this.produkt_nazwa.Location = new System.Drawing.Point(135, 38);
            this.produkt_nazwa.Name = "produkt_nazwa";
            this.produkt_nazwa.Size = new System.Drawing.Size(212, 20);
            this.produkt_nazwa.TabIndex = 18;
            this.produkt_nazwa.TextChanged += new System.EventHandler(this.produkt_nazwa_TextChanged);
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
            this.klienciView.AllowUserToAddRows = false;
            this.klienciView.AllowUserToDeleteRows = false;
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
            this.adresDataGridViewTextBoxColumn1,
            this.id});
            this.klienciView.DataSource = this.klienciBindingSource;
            this.klienciView.Location = new System.Drawing.Point(6, 6);
            this.klienciView.Name = "klienciView";
            this.klienciView.ReadOnly = true;
            this.klienciView.Size = new System.Drawing.Size(752, 542);
            this.klienciView.TabIndex = 2;
            this.klienciView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.klienciView_CellClick);
         
            // 
            // nazwafirmyDataGridViewTextBoxColumn1
            // 
            this.nazwafirmyDataGridViewTextBoxColumn1.DataPropertyName = "nazwa_firmy";
            this.nazwafirmyDataGridViewTextBoxColumn1.HeaderText = "Firma";
            this.nazwafirmyDataGridViewTextBoxColumn1.Name = "nazwafirmyDataGridViewTextBoxColumn1";
            this.nazwafirmyDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imię";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // miejscowoscDataGridViewTextBoxColumn1
            // 
            this.miejscowoscDataGridViewTextBoxColumn1.DataPropertyName = "miejscowosc";
            this.miejscowoscDataGridViewTextBoxColumn1.HeaderText = "Miejscowość";
            this.miejscowoscDataGridViewTextBoxColumn1.Name = "miejscowoscDataGridViewTextBoxColumn1";
            this.miejscowoscDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // krajDataGridViewTextBoxColumn
            // 
            this.krajDataGridViewTextBoxColumn.DataPropertyName = "kraj";
            this.krajDataGridViewTextBoxColumn.HeaderText = "Kraj";
            this.krajDataGridViewTextBoxColumn.Name = "krajDataGridViewTextBoxColumn";
            this.krajDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresDataGridViewTextBoxColumn1
            // 
            this.adresDataGridViewTextBoxColumn1.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn1.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn1.Name = "adresDataGridViewTextBoxColumn1";
            this.adresDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.textBox1);
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
            this.klient_button_zapisz_zmiany.Click += new System.EventHandler(this.klient_button_zapisz_zmiany_Click);
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
            this.klient_button_filtruj.Location = new System.Drawing.Point(40, 413);
            this.klient_button_filtruj.Name = "klient_button_filtruj";
            this.klient_button_filtruj.Size = new System.Drawing.Size(95, 38);
            this.klient_button_filtruj.TabIndex = 16;
            this.klient_button_filtruj.Text = "Filtruj";
            this.klient_button_filtruj.UseVisualStyleBackColor = true;
            this.klient_button_filtruj.Click += new System.EventHandler(this.klient_button_filtruj_Click);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idzamDataGridViewTextBoxColumn,
            this.datazamDataGridViewTextBoxColumn,
            this.nazwafirmyDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn1,
            this.nazwiskoDataGridViewTextBoxColumn1,
            this.miejscowoscDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.cenazasztDataGridViewTextBoxColumn,
            this.iloscDataGridViewTextBoxColumn,
            this.column1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wyszamowieniaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1117, 266);
            this.dataGridView1.TabIndex = 1;
            // 
            // idzamDataGridViewTextBoxColumn
            // 
            this.idzamDataGridViewTextBoxColumn.DataPropertyName = "id_zam";
            this.idzamDataGridViewTextBoxColumn.HeaderText = "ID zamówienia";
            this.idzamDataGridViewTextBoxColumn.Name = "idzamDataGridViewTextBoxColumn";
            this.idzamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datazamDataGridViewTextBoxColumn
            // 
            this.datazamDataGridViewTextBoxColumn.DataPropertyName = "data_zam";
            this.datazamDataGridViewTextBoxColumn.HeaderText = "Data zamówienia";
            this.datazamDataGridViewTextBoxColumn.Name = "datazamDataGridViewTextBoxColumn";
            this.datazamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwafirmyDataGridViewTextBoxColumn
            // 
            this.nazwafirmyDataGridViewTextBoxColumn.DataPropertyName = "nazwa_firmy";
            this.nazwafirmyDataGridViewTextBoxColumn.HeaderText = "Nazwa firmy";
            this.nazwafirmyDataGridViewTextBoxColumn.Name = "nazwafirmyDataGridViewTextBoxColumn";
            this.nazwafirmyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imieDataGridViewTextBoxColumn1
            // 
            this.imieDataGridViewTextBoxColumn1.DataPropertyName = "imie";
            this.imieDataGridViewTextBoxColumn1.HeaderText = "Imie klienta";
            this.imieDataGridViewTextBoxColumn1.Name = "imieDataGridViewTextBoxColumn1";
            this.imieDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nazwiskoDataGridViewTextBoxColumn1
            // 
            this.nazwiskoDataGridViewTextBoxColumn1.DataPropertyName = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn1.HeaderText = "Nazwisko klienta";
            this.nazwiskoDataGridViewTextBoxColumn1.Name = "nazwiskoDataGridViewTextBoxColumn1";
            this.nazwiskoDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Produkt";
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
            this.iloscDataGridViewTextBoxColumn.HeaderText = "Zamówiona ilość";
            this.iloscDataGridViewTextBoxColumn.Name = "iloscDataGridViewTextBoxColumn";
            this.iloscDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // column1DataGridViewTextBoxColumn
            // 
            this.column1DataGridViewTextBoxColumn.DataPropertyName = "Column1";
            this.column1DataGridViewTextBoxColumn.HeaderText = "Do zapłaty";
            this.column1DataGridViewTextBoxColumn.Name = "column1DataGridViewTextBoxColumn";
            this.column1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wyszamowieniaBindingSource1
            // 
            this.wyszamowieniaBindingSource1.DataMember = "wys_zamowienia";
            this.wyszamowieniaBindingSource1.DataSource = this.magazynDataSet2;
            // 
            // magazynDataSet2
            // 
            this.magazynDataSet2.DataSetName = "magazynDataSet2";
            this.magazynDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.Zamowienie_nazwa_produktu);
            this.groupBox1.Controls.Add(this.Zamowienie_ilosc);
            this.groupBox1.Controls.Add(this.Zamowienie_adres);
            this.groupBox1.Controls.Add(this.zamowienie_numer);
            this.groupBox1.Controls.Add(this.Zamowienie_dodaj);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(6, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1117, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Zamowienie_nazwa_produktu
            // 
            this.Zamowienie_nazwa_produktu.FormattingEnabled = true;
            this.Zamowienie_nazwa_produktu.Location = new System.Drawing.Point(158, 61);
            this.Zamowienie_nazwa_produktu.Name = "Zamowienie_nazwa_produktu";
            this.Zamowienie_nazwa_produktu.Size = new System.Drawing.Size(121, 21);
            this.Zamowienie_nazwa_produktu.TabIndex = 9;
            // 
            // Zamowienie_ilosc
            // 
            this.Zamowienie_ilosc.Location = new System.Drawing.Point(158, 93);
            this.Zamowienie_ilosc.Name = "Zamowienie_ilosc";
            this.Zamowienie_ilosc.Size = new System.Drawing.Size(120, 20);
            this.Zamowienie_ilosc.TabIndex = 8;
            // 
            // Zamowienie_adres
            // 
            this.Zamowienie_adres.FormattingEnabled = true;
            this.Zamowienie_adres.Location = new System.Drawing.Point(158, 120);
            this.Zamowienie_adres.Name = "Zamowienie_adres";
            this.Zamowienie_adres.Size = new System.Drawing.Size(121, 21);
            this.Zamowienie_adres.TabIndex = 7;
            // 
            // zamowienie_numer
            // 
            this.zamowienie_numer.Location = new System.Drawing.Point(158, 150);
            this.zamowienie_numer.Name = "zamowienie_numer";
            this.zamowienie_numer.Size = new System.Drawing.Size(120, 20);
            this.zamowienie_numer.TabIndex = 6;
            // 
            // Zamowienie_dodaj
            // 
            this.Zamowienie_dodaj.Location = new System.Drawing.Point(138, 210);
            this.Zamowienie_dodaj.Name = "Zamowienie_dodaj";
            this.Zamowienie_dodaj.Size = new System.Drawing.Size(125, 42);
            this.Zamowienie_dodaj.TabIndex = 5;
            this.Zamowienie_dodaj.Text = "Dodaj zamówienie";
            this.Zamowienie_dodaj.UseVisualStyleBackColor = true;
            this.Zamowienie_dodaj.Click += new System.EventHandler(this.Zamowienie_dodaj_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(31, 157);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Numer zamówienia";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(28, 128);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Adres klienta";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Ilość";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Nazwa produktu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dodaj zamówienie";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1137, 580);
            this.tabControl1.TabIndex = 0;
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
            // wys_zamowieniaTableAdapter
            // 
            this.wys_zamowieniaTableAdapter.ClearBeforeFill = true;
            // 
            // wysZamowienia1
            // 
            this.wysZamowienia1.DataSetName = "wysZamowienia";
            this.wysZamowienia1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wys_zamowieniaTableAdapter1
            // 
            this.wys_zamowieniaTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 375);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 18;
            
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(32, 356);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(119, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "Filtrowanie po nazwisku";
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
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.produktyView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.klienciView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyszamowieniaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zamowienie_ilosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienie_numer)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wyszamowieniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wysZamowienia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wysZamowienia1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private wysZamowienia wysZamowienia;
        private System.Windows.Forms.BindingSource wyszamowieniaBindingSource;
        private wysZamowieniaTableAdapters.wys_zamowieniaTableAdapter wys_zamowieniaTableAdapter;
        private wysZamowienia wysZamowienia1;
        private magazynDataSet magazynDataSet;
        private System.Windows.Forms.BindingSource klienciBindingSource;
        private magazynDataSetTableAdapters.KlienciTableAdapter klienciTableAdapter;
        private System.Windows.Forms.BindingSource magazynDataSetBindingSource;
        private magazynDataSet1 magazynDataSet1;
        private System.Windows.Forms.BindingSource produktyBindingSource;
        private magazynDataSet1TableAdapters.ProduktyTableAdapter produktyTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView produktyView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn producentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn krajpochodzeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenazasztDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zamowionailoscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button produkt_button_zapisz;
        private System.Windows.Forms.Button produkt_button_dodaj;
        private System.Windows.Forms.Button produkt_filtruj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox produkt_zamowiona;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox produkt_cena;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox produkt_kraj;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox produkt_ilenastanie;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox produkt_producent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox produkt_nazwa;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView klienciView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwafirmyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miejscowoscDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn krajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button klient_button_zapisz_zmiany;
        private System.Windows.Forms.Button klient_button_dodaj;
        private System.Windows.Forms.Button klient_button_filtruj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox klient_adres;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox klient_imie;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private magazynDataSet2 magazynDataSet2;
        private System.Windows.Forms.BindingSource wyszamowieniaBindingSource1;
        private magazynDataSet2TableAdapters.wys_zamowieniaTableAdapter wys_zamowieniaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datazamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwafirmyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn miejscowoscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenazasztDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox Zamowienie_nazwa_produktu;
        private System.Windows.Forms.NumericUpDown Zamowienie_ilosc;
        private System.Windows.Forms.ComboBox Zamowienie_adres;
        private System.Windows.Forms.NumericUpDown zamowienie_numer;
        private System.Windows.Forms.Button Zamowienie_dodaj;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox1;
    }
}

