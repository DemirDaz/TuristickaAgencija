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
using MessageBox = System.Windows.MessageBox;

namespace TuristickaAgencija
{
    /// <summary>
    /// Interaction logic for Administracija.xaml
    /// </summary>
    public partial class Administracija : UserControl
    {
        private Baza.DbTuristickaAgencija context;
        private UnitOfWork unit;
        private IEnumerable<Radnik> aranz;
        private IEnumerable<Filijala> filijale;
        private Filijala brisi;
        private Radnik radnikbrisi;
        

        public Administracija()
        {
            InitializeComponent();
            context = new DbTuristickaAgencija();
            unit = new UnitOfWork(context);
            napuniRadnike();
            napuniFilijale();
            grid1.DataContext = radnikbrisi;
            grid1.ItemsSource = aranz;
           
            grid_filijale.DataContext = brisi;
            grid_filijale.ItemsSource = filijale;
           


    }

        private void napuniRadnike()
        {
            this.aranz = this.unit.Radniks.GetAllRadniks();
            foreach (Radnik r in aranz)
                menadzer.Items.Add(r.jmbgRadnika);
        }
        private bool proveraBroja(string s)
        {
         return s.All(Char.IsDigit); 

        }

        private void napuniFilijale()
        {
            this.filijale = this.unit.Filijalas.GetAllFilijalas();
            foreach (Filijala f in filijale)
                filijala.Items.Add(f.PIB);
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
            roditelj.Text = String.Empty;
            prezime.Text = String.Empty;
            sprema.Text = String.Empty;
            pozicija.Text = String.Empty;
            Adresa.Text = String.Empty;
            Email.Text = String.Empty;
            sifra.Text = String.Empty;
            datum.SelectedDate = null;
            brmob.Text = String.Empty;
            filijala.Items.Clear(); 
            brpriv.Text = String.Empty;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            DateTime prov = new DateTime(2003,01,01);
             if (datum.SelectedDate.Value < prov)
            {
                Radnik novi = new Radnik();
                if (jmbg.Text.Length == 13)
                { if (proveraBroja(jmbg.Text) == false) { MessageBox.Show("Uneti JMBG ne sadrži samo cifre."); return; } }
                else { MessageBox.Show("JMBG može imati samo trinaest cifara."); return; }
                novi.jmbgRadnika = jmbg.Text;
                novi.ime = ime.Text;
                novi.imeRoditelja = roditelj.Text;
                novi.prezime = prezime.Text;
                novi.strucnaSprema = sprema.Text;
                novi.pozicija = pozicija.Text;
                novi.sifra = sifra.Text;
                novi.sifraFilijale = (int)filijala.SelectedItem;
                novi.adresa = Adresa.Text;
                novi.datumRodjenja = datum.SelectedDate.Value;
                if (IsEmail(Email.Text) == true) novi.email = Email.Text; 
                else { MessageBox.Show("Niste uneli validan email"); return; }
                if (proveraBroja(brmob.Text) == true) novi.sluzbeniTel = brmob.Text;
                else { MessageBox.Show("Niste uneli validan službeni broj mobilnog."); return; }
                if (proveraBroja(brpriv.Text) == true) novi.privatniTel = brpriv.Text;
                else { MessageBox.Show("Niste uneli validan privatni broj mobilnog."); return; }
               
                this.unit.Radniks.AddRadnik(novi);

                MessageBox.Show("Uspešno dodat novi radnik");
                napuniRadnike();
                Ocisti();
                grid1.ItemsSource = aranz;
            }
            else
            {
                MessageBox.Show("Radnik ima manje od 16 godina. Kriterijum zapošljavanja je 16+ .");
                return;
            }
            
            


        }

        private void Ocisti2()
        {
            maticni.Text = String.Empty;
            naziv.Text = String.Empty;
            adresa2.Text = String.Empty;
            racun.Text = String.Empty;
            mejl.Text = String.Empty;
            telefon.Text = String.Empty;
            webadresa.Text = String.Empty;
            menadzer.Items.Clear(); 
            
          
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Filijala nova = new Filijala();
            if (maticni.Text.Length == 13 && proveraBroja(maticni.Text) == true)
            {
                nova.maticniBroj = maticni.Text;
                nova.naziv = naziv.Text;
                nova.sediste = adresa2.Text;
                nova.racun = racun.Text;
                nova.sifraMenadzera = menadzer.SelectedItem.ToString();
                if (IsEmail(mejl.Text) == true) nova.email = mejl.Text;
                else { MessageBox.Show("Niste uneli validan email"); return; }
                if (proveraBroja(telefon.Text) == true) nova.telefon = telefon.Text;
                else { MessageBox.Show("Niste uneli validan broj mobilnog."); return; }
                nova.webAdresa = webadresa.Text;
                this.unit.Filijalas.AddFilijala(nova);
                MessageBox.Show("Uspešno dodata nova filijala");
                Ocisti2();
                napuniFilijale();
                grid_filijale.ItemsSource = filijale;
            }
            else
            {
                MessageBox.Show("Matični broj nije validan. Matični broj mora sadržati 13 cifara.");
                return;
            }


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
                this.unit.Filijalas.DeleteFilijala(this.brisi);
                MessageBox.Show("Uspešno obrisana filijala.");
                napuniFilijale();
                grid_filijale.ItemsSource = filijale;

            }
        }

        private void grid_filijale_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            this.brisi = (Filijala)grid_filijale.CurrentItem;
        }

        private void grid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.radnikbrisi = (Radnik)grid1.CurrentItem;
        }

        private void Obrisiradnika(object sender, RoutedEventArgs e)
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
                this.unit.Radniks.DeleteRadnik(this.radnikbrisi);
                MessageBox.Show("Uspešno obrisan radnik.");
                napuniRadnike();
                grid1.ItemsSource = aranz;

            }

        }
    }
}
