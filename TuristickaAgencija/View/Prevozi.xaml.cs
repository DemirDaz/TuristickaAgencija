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
    /// Interaction logic for Prevozi.xaml
    /// </summary>
    public partial class Prevozi : UserControl
    {
        private Baza.DbTuristickaAgencija context;
        private UnitOfWork unit;
        private IEnumerable<KartePrevoza> aranz;
        private IEnumerable<Korisnik> klijenti;
        private KartePrevoza brisi;
        public Prevozi()
        {
            InitializeComponent();
            context = new Baza.DbTuristickaAgencija();
            unit = new UnitOfWork(context);
            napuniKarte();
            napuniKlijente();
            grid1.DataContext = brisi;
            grid1.ItemsSource = aranz;


        }

        private void napuniKarte()
        {
            this.aranz = this.unit.KartePrevozs.GetAllKartePrevoza();
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

        private void napuniKlijente()
        {
            this.klijenti = this.unit.Korisniks.GetAllKorisniks();
            foreach (Korisnik k in klijenti)
                klijent.Items.Add(k.jmbgKorisnika);
        }

        private void Ocisti()
        {
            destinacija.Text = String.Empty;
            datum.SelectedDate = null;
            vreme.SelectedTime = null;
            cena.Text = String.Empty;
            tip.SelectedItem = null;
            klijent.SelectedIndex = -1;
           
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            DateTime prov = DateTime.Now;
            if (datum.SelectedDate.Value > prov)
            {
                KartePrevoza novi = new KartePrevoza();

                DateTime pun = new DateTime(datum.SelectedDate.Value.Year,
                                            datum.SelectedDate.Value.Month,
                                            datum.SelectedDate.Value.Day,
                                            vreme.SelectedTime.Value.Hour,
                                            vreme.SelectedTime.Value.Minute,
                                            vreme.SelectedTime.Value.Second);
                novi.destinacija = destinacija.Text;
                novi.jmbgKorisnika = klijent.SelectedItem.ToString();
                novi.tipPrevoza = tip.Text;
                if (proveraBroja(cena.Text) == true) novi.cena = float.Parse(cena.Text);
                else { MessageBox.Show("Niste uneli cenu validno. Samo cifre su dozvoljene."); return; }
                novi.datum = pun;
            

                this.unit.KartePrevozs.AddKartaPrevoza(novi);

                MessageBox.Show("Uspešno dodata nova rezervacija prevoza");
                napuniKarte();
                Ocisti();
                grid1.ItemsSource = aranz;
            }
            else
            {
                MessageBox.Show("Datum koji ste odabrali nije validan, već je prošao.");
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
                try
                {
                    this.unit.KartePrevozs.DeleteKartaPrevoza(this.brisi);
                    MessageBox.Show("Uspešno obrisana rezervacija.");
                    napuniKarte();
                    grid1.ItemsSource = aranz;
                }
                catch { MessageBox.Show("Niste odabrali rezervaciju u tabeli."); }

            }
        }

        private void grid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.brisi = (KartePrevoza)grid1.CurrentItem;
        }
    }
}

