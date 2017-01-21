using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazynNET
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = MateuszPC; Initial Catalog = magazyn; User ID = studia; Password = studia");
        SqlCommand cmd;
        
        Klienci klient = new Klienci();

        public Form1()
        {
            InitializeComponent();
            klient_button_dodaj.Enabled = false;
            klienciView.DataSource = magazynDataSet.Klienci;

            Zamowienie_nazwa_produktu.DataSource = magazynDataSet1.Tables["Produkty"];
            Zamowienie_nazwa_produktu.DisplayMember = "Nazwa";

            Zamowienie_adres.DataSource = magazynDataSet.Tables["Klienci"];
            Zamowienie_adres.DisplayMember = "adres";
           
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'magazynDataSet2.wys_zamowienia' table. You can move, or remove it, as needed.
            this.wys_zamowieniaTableAdapter1.Fill(this.magazynDataSet2.wys_zamowienia);
            // TODO: This line of code loads data into the 'magazynDataSet1.Produkty' table. You can move, or remove it, as needed.
            this.produktyTableAdapter.Fill(this.magazynDataSet1.Produkty);
            // TODO: This line of code loads data into the 'magazynDataSet.Klienci' table. You can move, or remove it, as needed.
            this.klienciTableAdapter.Fill(this.magazynDataSet.Klienci);
            // TODO: This line of code loads data into the 'wysZamowienia.wys_zamowienia' table. You can move, or remove it, as needed.
            this.wys_zamowieniaTableAdapter.Fill(this.wysZamowienia.wys_zamowienia);
            

        }

        private void klient_button_dodaj_Click(object sender, EventArgs e)
        { 
                    
            string query = "insert into Klienci(nazwa_firmy,imie,nazwisko,telefon,miejscowosc,kraj,adres) values (@nazwa_firmy,@imie,@nazwisko,@telefon,@miejscowosc,@kraj,@adres)";
                        
            cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.Parameters.Add("@nazwa_firmy",klient_firma.Text);
            cmd.Parameters.Add("@imie", klient_imie.Text);
            cmd.Parameters.Add("@nazwisko", klient_nazwisko.Text);
            cmd.Parameters.Add("@telefon", klient_telefon.Text);
            cmd.Parameters.Add("@miejscowosc", klient_miejscowosc.Text);
            cmd.Parameters.Add("@kraj", klient_kraj.Text);
            cmd.Parameters.Add("@adres", klient_adres.Text);
            

            cmd.ExecuteNonQuery();            
            conn.Close();

            this.klienciTableAdapter.Fill(this.magazynDataSet.Klienci);        

            
        }

        private void klient_imie_TextChanged(object sender, EventArgs e)
        {
            klient_button_dodaj.Enabled=!(string.IsNullOrWhiteSpace(klient_nazwisko.Text) || (string.IsNullOrWhiteSpace(klient_adres.Text)) || (string.IsNullOrWhiteSpace(klient_imie.Text)) || (string.IsNullOrWhiteSpace(klient_kraj.Text)) || (string.IsNullOrWhiteSpace(klient_telefon.Text)) || (string.IsNullOrWhiteSpace(klient_miejscowosc.Text)));
        }

        private void klienciView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (klienciView.SelectedRows.Count>0)
            {
                klient_firma.Text= klienciView.SelectedRows[0].Cells[0].Value + string.Empty;
                klient_imie.Text = klienciView.SelectedRows[0].Cells[1].Value + string.Empty;
                klient_nazwisko.Text= klienciView.SelectedRows[0].Cells[2].Value + string.Empty;
                klient_telefon.Text= klienciView.SelectedRows[0].Cells[3].Value + string.Empty;
                klient_miejscowosc.Text= klienciView.SelectedRows[0].Cells[4].Value + string.Empty;
                klient_kraj.Text= klienciView.SelectedRows[0].Cells[5].Value + string.Empty;
                klient_adres.Text= klienciView.SelectedRows[0].Cells[6].Value + string.Empty;

            }
        }

        private void klient_button_zapisz_zmiany_Click(object sender, EventArgs e)
        {
            string query = "update Klienci SET nazwa_firmy=@nazwa_firmy, imie= @imie,nazwisko=@nazwisko, telefon=@telefon,miejscowosc=@miejscowosc,kraj=@kraj,adres=@adres where id=@id" ;

            cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.Parameters.Add("@nazwa_firmy", klient_firma.Text);
            cmd.Parameters.Add("@imie", klient_imie.Text);
            cmd.Parameters.Add("@nazwisko", klient_nazwisko.Text);
            cmd.Parameters.Add("@telefon", klient_telefon.Text);
            cmd.Parameters.Add("@miejscowosc", klient_miejscowosc.Text);
            cmd.Parameters.Add("@kraj", klient_kraj.Text);
            cmd.Parameters.Add("@adres", klient_adres.Text);
            cmd.Parameters.AddWithValue("@id", klienciView.SelectedRows[0].Cells[7].Value + string.Empty);


            cmd.ExecuteNonQuery();
            conn.Close();

            this.klienciTableAdapter.Fill(this.magazynDataSet.Klienci);
        }

        private void klient_button_filtruj_Click(object sender, EventArgs e)
        {
            ((DataTable)klienciView.DataSource).DefaultView.RowFilter = string.Format("Nazwisko '%{0}%'", textBox1.Text.Trim().Replace("'", "''"));
        }

        private void produkt_button_dodaj_Click(object sender, EventArgs e)
        {
            string query = "insert into Produkty(nazwa,producent,kraj_pochodzenia,ilosc,zamowiona_ilosc,cena_za_szt) values (@nazwa,@producent,@kraj_pochodzenia,@ilosc,@ilość_zamowiona,@cena_szt)";

            cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.Parameters.Add("@nazwa", produkt_nazwa.Text);
            cmd.Parameters.Add("@producent", produkt_producent.Text);
            cmd.Parameters.Add("@kraj_pochodzenia", produkt_kraj.Text);
            cmd.Parameters.Add("@ilość_zamowiona",int.Parse(produkt_zamowiona.Text));
            cmd.Parameters.Add("@cena_szt", int.Parse(produkt_cena.Text));
            cmd.Parameters.Add("@ilosc", int.Parse(produkt_ilenastanie.Text));
            


            cmd.ExecuteNonQuery();
            conn.Close();
            this.produktyTableAdapter.Fill(this.magazynDataSet1.Produkty);           
        }

        private void produkt_nazwa_TextChanged(object sender, EventArgs e)
        {
            produkt_button_dodaj.Enabled =!(string.IsNullOrWhiteSpace(produkt_nazwa.Text) || (string.IsNullOrWhiteSpace(produkt_kraj.Text)) || (string.IsNullOrWhiteSpace(produkt_zamowiona.Text)) || (string.IsNullOrWhiteSpace(produkt_producent.Text)) || (string.IsNullOrWhiteSpace(produkt_ilenastanie.Text)) || (string.IsNullOrWhiteSpace(produkt_cena.Text)));
        }

        private void produktyView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (produktyView.SelectedRows.Count > 0)
            {
                produkt_nazwa.Text = produktyView.SelectedRows[0].Cells[0].Value + string.Empty;
                produkt_producent.Text= produktyView.SelectedRows[0].Cells[1].Value + string.Empty;
                produkt_ilenastanie.Text= produktyView.SelectedRows[0].Cells[2].Value + string.Empty;
                produkt_kraj.Text= produktyView.SelectedRows[0].Cells[3].Value + string.Empty;
                produkt_cena.Text= produktyView.SelectedRows[0].Cells[4].Value + string.Empty;
                produkt_zamowiona.Text= produktyView.SelectedRows[0].Cells[5].Value + string.Empty;
            }
        }

        private void produkt_button_zapisz_Click(object sender, EventArgs e)
        {
            string query = "update Produkty SET nazwa=@nazwa, producent=@producent,kraj_pochodzenia=@kraj_pochodzenia,ilosc=@ilosc,zamowiona_ilosc=@ilość_zamowiona,cena_za_szt=@cena_szt where id=@id";

            cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.Parameters.Add("@nazwa", produkt_nazwa.Text);
            cmd.Parameters.Add("@producent", produkt_producent.Text);
            cmd.Parameters.Add("@kraj_pochodzenia", produkt_kraj.Text);
            cmd.Parameters.Add("@ilość_zamowiona", int.Parse(produkt_zamowiona.Text));
            cmd.Parameters.Add("@cena_szt", int.Parse(produkt_cena.Text));
            cmd.Parameters.Add("@ilosc", int.Parse(produkt_ilenastanie.Text));
            cmd.Parameters.Add("@id", produktyView.SelectedRows[0].Cells[6].Value + string.Empty);

            cmd.ExecuteNonQuery();
            conn.Close();
            this.produktyTableAdapter.Fill(this.magazynDataSet1.Produkty);
        }

        private void Zamowienie_dodaj_Click(object sender, EventArgs e)
        {           
            cmd = new SqlCommand("dodaj_zamowienie",conn);
            cmd.CommandType = CommandType.StoredProcedure;           
            conn.Open();
            cmd.Parameters.Add("@nr_zamowienia", (int)zamowienie_numer.Value);
            cmd.Parameters.Add("@adres", Zamowienie_adres.Text);
            cmd.Parameters.Add("@nazwa_prod", Zamowienie_nazwa_produktu.Text);
            cmd.Parameters.Add("@ilosc", (int)Zamowienie_ilosc.Value);
            
            cmd.ExecuteNonQuery();
            conn.Close();
            this.wys_zamowieniaTableAdapter1.Fill(this.magazynDataSet2.wys_zamowienia);
        }


      
    }
}
