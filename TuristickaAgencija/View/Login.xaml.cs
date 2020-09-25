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
using System.Windows.Shapes;
using TuristickaAgencija.Baza;
using TuristickaAgencija.InterfaceRepository;
using TuristickaAgencija.Repository;

namespace TuristickaAgencija
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        
        
        private Baza.DbTuristickaAgencija context;
        private UnitOfWork unit;
        public Login()
        {
            InitializeComponent();
            context = new Baza.DbTuristickaAgencija();
            unit = new UnitOfWork(context);
        }
        private bool PraznoPolje()
        {
            return (string.IsNullOrEmpty(user.Text) || string.IsNullOrEmpty(sifra.Password));
        }

        private void Ocisti()
        {
            user.Text = string.Empty;
            sifra.Password = string.Empty;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(PraznoPolje()) { Ocisti();
                MessageBox.Show("Popunite polja!");
            }
            else if (this.unit.Radniks.CombinationExists(user.Text,sifra.Password)==false ) {
                
                    Ocisti();
                    MessageBox.Show("Ne postoji taj radnik!");
                }
            else
            {

                Globalne.email = user.Text;
                Radnik rad = this.unit.Radniks.GetRadnikByEmail(user.Text);
                Globalne.idFil = rad.sifraFilijale;
                if(unit.Radniks.IsManager(user.Text) == true) {
                    Globalne.menadzer = true;
                        } else Globalne.menadzer = false;
                MainWindow Glavniprozor = new MainWindow();
                Glavniprozor.Owner = this;
                Glavniprozor.ShowDialog();

            }
                        
                        
        }
    }
}
