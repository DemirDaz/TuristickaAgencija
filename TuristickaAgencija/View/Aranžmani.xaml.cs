using System;
using System.Collections;
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
    /// Interaction logic for Aranžmani.xaml
    /// </summary>
    public partial class Aranžmani : UserControl
    {
        private Baza.DbTuristickaAgencija context;
        private UnitOfWork unit;
        private IEnumerable<TurAranzmann> aranz;
        private IEnumerable<RezAranzmana> aranr;
        private IEnumerable<Korisnik> korisnici;
        private TurAranzmann brisi;
        private RezAranzmana obrisi;
        public Aranžmani()
        {
            InitializeComponent();
            context = new Baza.DbTuristickaAgencija();
            unit = new UnitOfWork(context);
            Ocisti();
            napuniAranzmane();
            napuniRez();
            napuniKorisnike();
            if (Globalne.menadzer == false) { sakrij.Visibility = Visibility.Hidden; sakrijdugme.Visibility = Visibility.Hidden; }
            grid1.DataContext = brisi;
            grid1.ItemsSource = aranz;
            NapuniCombo();
            grid2.DataContext = obrisi;
            grid2.ItemsSource = aranr; //izmeni
            

        }

        private void NapuniCombo()
        {
            foreach(TurAranzmann n in aranz)
            {
                idaranz.Items.Add(n.idAranzmana);
            }

            foreach(Korisnik k in korisnici)
            {
                jmbg.Items.Add(k.jmbgKorisnika);
            }


        }
        private void napuniAranzmane()
        {
            this.aranz = this.unit.TurAranzmans.GetAllTurAranzmanns();
        }

        private void napuniRez()
        {
            this.aranr = this.unit.RezAranzmanas.GetAllRezAranzmanas();
        }

        private void napuniKorisnike()
        {
            this.korisnici = this.unit.Korisniks.GetAllKorisniks();
        }

        public void Ocisti()
        {
            one.Text = String.Empty;
            two.SelectedDate = null;
            three.SelectedDate = null;
            five.SelectedIndex = -1;
            four.Text = String.Empty;
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            if (two.SelectedDate.Value < three.SelectedDate.Value)
            {
                TurAranzmann novi = new TurAranzmann();
                novi.destinacija = one.Text;
                novi.datumPocetka = two.SelectedDate.Value;
                novi.datumKraja = three.SelectedDate.Value;
                try { 
                novi.cena = float.Parse(four.Text);
                }
                catch { MessageBox.Show("Cena nije uneta brojevima.");
                    return;
                }
                novi.nacinPlacanja = five.Text;
                this.unit.TurAranzmans.AddTurAranzmann(novi);
                
                MessageBox.Show("Uspešno dodat novi aranžman");
            }
            else { MessageBox.Show("Datumi nisu validni.");
                Ocisti();
                return;
            }
            NapuniCombo();
            napuniAranzmane();
            
            grid1.ItemsSource = aranz;
            grid1.Columns[6].Visibility = Visibility.Hidden;


        }

        private bool proveraBroja(string s)
        {
            return s.All(Char.IsDigit);

        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            DateTime prov = DateTime.Now;
            
            
                RezAranzmana novi = new RezAranzmana();

                novi.idAranzmana = (int)idaranz.SelectedItem;
                novi.jmbgKorisnika = jmbg.Text;
                novi.datumRez = prov;
               
                
                if (proveraBroja(four1.Text) == true) novi.brOsoba = int.Parse(four1.Text);
                else { MessageBox.Show("Niste uneli cenu validno. Samo cifre su dozvoljene."); return; }
                TurAranzmann pom = this.unit.TurAranzmans.GetTurAranzmannById(novi.idAranzmana);

                novi.ukupnaCena = novi.brOsoba * pom.cena;


                this.unit.RezAranzmanas.AddRezAranzmana(novi);

                MessageBox.Show("Uspešno dodata nova rezervacija aranžmana.");
                napuniRez();
                Ocisti2();
                NapuniCombo();
                grid2.ItemsSource = aranr;
            }

        private void Ocisti2()
        {
            idaranz.Items.Clear();

            jmbg.Items.Clear(); 
            four1.Text = String.Empty;
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
                    this.unit.TurAranzmans.DeleteTurAranzmann(this.brisi);
                    MessageBox.Show("Uspešno obrisan aranžman.");
                    napuniAranzmane();
                grid1.ItemsSource = aranz; }
                catch { MessageBox.Show("Niste odabrali aranžman u tabeli."); }

             }
         }
        /*
         private void grid_filijale_SelectionChanged(object sender, SelectionChangedEventArgs e)
         {

             this.brisi = (Filijala)grid_filijale.CurrentItem;
         }

         private void grid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
         {
             this.radnikbrisi = (Radnik)grid1.CurrentItem;
              */
    

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
            { try
                {
                    this.unit.RezAranzmanas.DeleteAranzman(this.obrisi);
                    MessageBox.Show("Uspešno obrisana rezervacija.");
                    napuniRez();
                    grid2.ItemsSource = aranr;
                }
                catch { MessageBox.Show("Niste odabrali rezervaciju u tabeli."); }

            } 

        }

        private void grid2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.obrisi = (RezAranzmana)grid2.CurrentItem;

        }

        private void grid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.brisi = (TurAranzmann)grid1.CurrentItem;

        }
    }
}
