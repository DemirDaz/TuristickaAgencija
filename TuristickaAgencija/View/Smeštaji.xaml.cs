using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TuristickaAgencija.Baza;

namespace TuristickaAgencija
{
    /// <summary>
    /// Interaction logic for Smeštaji.xaml
    /// </summary>
    public partial class Smeštaji : UserControl
    {
        private Baza.DbTuristickaAgencija context;
        private UnitOfWork unit;
        private IEnumerable<RezSmestaja> aranz;
        private IEnumerable<Hotel> aran2;
        private IEnumerable<Korisnik> klijenti;
        private Hotel brisi;
        private RezSmestaja obrisi;
        public Smeštaji()
        {
            InitializeComponent();
            context = new Baza.DbTuristickaAgencija();
            unit = new UnitOfWork(context);
            napuniRez();
            napuniHotele();
            napuniKlijente();
            napuniCombo();
            grid1.DataContext = brisi;
            grid2.DataContext = obrisi;
            grid1.ItemsSource = aran2;
            grid2.ItemsSource = aranz;


        }
        private void napuniKlijente()
        {
            this.klijenti = this.unit.Korisniks.GetAllKorisniks();
           
        }

        private void napuniCombo()
        {
            foreach (Korisnik k in klijenti)
                jmbgKlijenta.Items.Add(k.jmbgKorisnika);
            foreach (Hotel k in aran2)
                idhotela.Items.Add(k.idHotela);
        }

        bool IsEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private bool proveraBroja(string s)
        {
            return s.All(Char.IsDigit);

        }
        private void napuniRez()
        {
            this.aranz = this.unit.RezSmestajas.GetAllRezSmestaja();
        }
        private void napuniHotele()
        {
            this.aran2 = this.unit.Hotels.GetAllHotels();
        }

        

        private void Obrisi(object sender, RoutedEventArgs e)
        {
            Ocisti();
            var result = MessageBox.Show("Da li ste sigurni?", "Provera",
                                 MessageBoxButton.YesNo
                                );
            if (result == MessageBoxResult.No)
            {

                return;
            }
            else
            {
                try
                {
                    this.unit.Hotels.DeleteHotel(this.brisi);
                    MessageBox.Show("Uspešno obrisana rezervacija.");
                    napuniHotele();
                    grid1.ItemsSource = aranz;
                }
                catch { MessageBox.Show("Niste odabrali rezervaciju u tabeli."); }

            }

        }

        private void Obrisirezervaciju(object sender, RoutedEventArgs e)
        {
            Ocisti2();
            var result = MessageBox.Show("Da li ste sigurni?", "Provera",
                                 MessageBoxButton.YesNo
                                );
            if (result == MessageBoxResult.No)
            {

                return;
            }
            else
            {
                try
                {
                    this.unit.RezSmestajas.DeleteRezSmestaja(this.obrisi);
                    MessageBox.Show("Uspešno obrisana rezervacija.");
                    napuniRez();
                    grid1.ItemsSource = aranz;
                }
                catch { MessageBox.Show("Niste odabrali rezervaciju u tabeli."); }

            }

        }

        private void Ocisti()
        {
            ime.Text = String.Empty;
            lokacija.Text = String.Empty;
            kategorija.SelectedIndex = -1;
            email.Text = String.Empty;
            webadresa.Text = String.Empty;

        }

        private void Ocisti2()
        {
            idhotela.Items.Clear();
            jmbgKlijenta.Items.Clear();
            datumPocetka.SelectedDate = null;
            datumZavrsetka.SelectedDate = null;
            vrstaUsluge.SelectedIndex = -1;
            cenaUsluge.Text = String.Empty;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if((ime.Text.Length != 0) && (lokacija.Text.Length != 0) && (kategorija.Text.Length != 0) && (email.Text.Length != 0) && (webadresa.Text.Length != 0))
            {
                Hotel novi = new Hotel();
                novi.ime = ime.Text;
                novi.lokacija = lokacija.Text;
                novi.kategorija = kategorija.Text;
                if (IsEmail(email.Text) == true) { novi.email = email.Text; } else { MessageBox.Show("Unesite validan email.");return; }
                novi.webadresa = webadresa.Text;

                this.unit.Hotels.AddHotel(novi);
                MessageBox.Show("Uspešno dodat novi hotel!");
                napuniHotele();
                grid1.ItemsSource = aran2;
                Ocisti();
                Ocisti2();
                napuniCombo();
            }
            else { MessageBox.Show("Popunite sva polja!"); return; }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {


            if (datumPocetka.SelectedDate.Value < datumZavrsetka.SelectedDate.Value)
            {
                RezSmestaja novi = new RezSmestaja();
                
                novi.idHotela = int.Parse(idhotela.Text);
                novi.jmbgKlijenta = jmbgKlijenta.Text;
                novi.datumPocetka = datumPocetka.SelectedDate.Value;
                novi.datumZavrsetka = datumZavrsetka.SelectedDate.Value;
                novi.vrstaUsluge = vrstaUsluge.Text;
                try
                {
                    novi.cenaUsluge = float.Parse(cenaUsluge.Text);
                }
                catch
                {
                    MessageBox.Show("Cena nije uneta u ciframa.");
                    return;
                }
                
                this.unit.RezSmestajas.AddRezSmestaja(novi);
                napuniRez();
                grid2.ItemsSource = aranz;
                Ocisti();
                Ocisti2();
                napuniCombo();

                MessageBox.Show("Uspešno dodana rezervacija!");
            }
            else
            {
                MessageBox.Show("Datumi nisu validni.");
               
            }

            

        }

        private void grid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.brisi = (Hotel)grid1.CurrentItem;
        }

        private void grid2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.obrisi = (RezSmestaja)grid2.CurrentItem;
        }
    }
}
