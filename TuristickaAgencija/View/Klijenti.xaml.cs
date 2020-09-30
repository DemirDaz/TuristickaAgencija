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
    /// Interaction logic for Klijenti.xaml
    /// </summary>
    public partial class Klijenti : UserControl
    {
        private Baza.DbTuristickaAgencija context;
        private UnitOfWork unit;
        private IEnumerable<Korisnik> aranz;
        private Korisnik brisi;
        public Klijenti()
        {
            InitializeComponent();
            context = new Baza.DbTuristickaAgencija();
            unit = new UnitOfWork(context);
            napuniKlijente();
            grid1.DataContext = brisi;
            grid1.ItemsSource = aranz;
            


        }

        private void napuniKlijente()
        {
            this.aranz = this.unit.Korisniks.GetAllKorisniks();
        }

        private bool proveraBroja(string s)
        {
            return s.All(Char.IsDigit);

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

        private void Ocisti()
        {
            jmbg.Text = String.Empty;
            ime.Text = String.Empty;
            
            prezime.Text = String.Empty;
           
            adresa.Text = String.Empty;
            email.Text = String.Empty;
            
            telefon.Text = String.Empty;
           
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (jmbg.Text.Length == 13 && proveraBroja(jmbg.Text) == true)
            {
                Korisnik novi = new Korisnik();
                
                novi.jmbgKorisnika = jmbg.Text;
                novi.ime = ime.Text;
                
                novi.prezime = prezime.Text;
                
               
                novi.adresa = adresa.Text;
               
                if (IsEmail(email.Text) == true) novi.email = email.Text;
                else { MessageBox.Show("Niste uneli validan email"); return; }
                if (proveraBroja(telefon.Text) == true) novi.telefon = telefon.Text;
                else { MessageBox.Show("Niste uneli validan službeni broj mobilnog."); return; }
               

                this.unit.Korisniks.AddKorisnik(novi);

                MessageBox.Show("Uspešno dodat novi radnik");
                napuniKlijente();
                Ocisti();
                grid1.ItemsSource = aranz;
            }
            else
            {
                MessageBox.Show("Matični broj nije validan. Matični broj mora sadržati 13 cifara.");
                return;
            }




        }

        private void grid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.brisi = (Korisnik)grid1.CurrentItem;
        }

        private void Obrisi(object sender, RoutedEventArgs e)
        {
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
                    this.unit.Korisniks.DeleteKorisnik(this.brisi);
                    MessageBox.Show("Uspešno obrisan klijent.");
                    napuniKlijente();
                    grid1.ItemsSource = aranz;
                }
                catch { MessageBox.Show("Niste odabrali klijenta u tabeli."); }

            }
        }
    }
