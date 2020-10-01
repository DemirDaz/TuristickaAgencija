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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Baza.DbTuristickaAgencija context;
        private UnitOfWork unit;
        private Filijala trenutna;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new NavigationViewModel();
            context = new Baza.DbTuristickaAgencija();
            unit = new UnitOfWork(context);
            
            Filijala();
            if (Globalne.menadzer == true) administracija.Visibility = Visibility.Visible;
            else administracija.Visibility = Visibility.Hidden;
            podacifilijale.Text = "Filijala: " + Environment.NewLine + trenutna.naziv + Environment.NewLine + Environment.NewLine+
                                  "Adresa: " + Environment.NewLine + trenutna.sediste + Environment.NewLine + Environment.NewLine +
                                  "MaticniBroj: " + Environment.NewLine + trenutna.maticniBroj + Environment.NewLine + Environment.NewLine +
                                  "Račun: " + Environment.NewLine + trenutna.racun + Environment.NewLine + Environment.NewLine +
                                  "Email: " + Environment.NewLine  + trenutna.email + Environment.NewLine + Environment.NewLine +
                                  "Telefon: " + Environment.NewLine + trenutna.telefon;
        }

        private void Filijala()
        {
            this.trenutna = this.unit.Filijalas.GetFilijalaById(Globalne.idFil);
        }

        private void odjaviSe(object sender, RoutedEventArgs e)
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
                Globalne.email = String.Empty;
                Globalne.idFil = -1;
                Globalne.menadzer = false;
                this.Close();
            }
            
        }

           

        
    }
}
