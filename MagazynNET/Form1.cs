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
            //if (string.IsNullOrWhiteSpace(klient_nazwisko.Text) || (string.IsNullOrWhiteSpace(klient_adres.Text)) || (string.IsNullOrWhiteSpace(klient_imie.Text)) || (string.IsNullOrWhiteSpace(klient_kraj.Text)) || (string.IsNullOrWhiteSpace(klient_telefon.Text)) || (string.IsNullOrWhiteSpace(klient_miejscowosc.Text)))
            //{
            //    klient_button_dodaj.Enabled = false;
            //    klient_button_zapisz_zmiany.Enabled = false;
            //}
            //else
            //{
            //    klient_button_dodaj.Enabled = true;
            //    klient_button_zapisz_zmiany.Enabled = true;
            //}
            //klient_button_dodaj.Enabled = !(string.IsNullOrWhiteSpace(klient_nazwisko.Text) || (string.IsNullOrWhiteSpace(klient_adres.Text)) || (string.IsNullOrWhiteSpace(klient_imie.Text)) || (string.IsNullOrWhiteSpace(klient_kraj.Text)) || (string.IsNullOrWhiteSpace(klient_telefon.Text)) || (string.IsNullOrWhiteSpace(klient_miejscowosc.Text)));

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
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
    }
}
