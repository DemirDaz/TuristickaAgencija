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
            EventManager.RegisterClassHandler(typeof(TextBox), TextBox.KeyDownEvent, new KeyEventHandler(TextBox_KeyDown));
            EventManager.RegisterClassHandler(typeof(CheckBox), CheckBox.KeyDownEvent, new KeyEventHandler(CheckBox_KeyDown));
            InitializeComponent();
            context = new Baza.DbTuristickaAgencija();
            unit = new UnitOfWork(context);
        }
        void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter & (sender as TextBox).AcceptsReturn == false) MoveToNextUIElement(e);
        }

        void CheckBox_KeyDown(object sender, KeyEventArgs e)
        {
            MoveToNextUIElement(e);
            //Sucessfully moved on and marked key as handled.
            //Toggle check box since the key was handled and
            //the checkbox will never receive it.
            if (e.Handled == true)
            {
                CheckBox cb = (CheckBox)sender;
                cb.IsChecked = !cb.IsChecked;
            }

        }

        void MoveToNextUIElement(KeyEventArgs e)
        {
            // Creating a FocusNavigationDirection object and setting it to a
            // local field that contains the direction selected.
            FocusNavigationDirection focusDirection = FocusNavigationDirection.Next;

            // MoveFocus takes a TraveralReqest as its argument.
            TraversalRequest request = new TraversalRequest(focusDirection);

            // Gets the element with keyboard focus.
            UIElement elementWithFocus = Keyboard.FocusedElement as UIElement;

            // Change keyboard focus.
            if (elementWithFocus != null)
            {
                if (elementWithFocus.MoveFocus(request)) e.Handled = true;
            }
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
                Ocisti();
                Glavniprozor.Owner = this;
                Glavniprozor.ShowDialog();

            }
                        
                        
        }

       
    }
}
