using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TuristickaAgencija
{
    class NavigationViewModel : INotifyPropertyChanged

    {

        public ICommand ArCommand { get; set; }

        public ICommand SmesCommand { get; set; }

        public ICommand PrevozCommand { get; set; }

        public ICommand AdminCommand { get; set; }

        public ICommand KlijentCommand { get; set; }

        private object selectedViewModel;

        public object SelectedViewModel

        {

            get { return selectedViewModel; }

            set { selectedViewModel = value; OnPropertyChanged("SelectedViewModel"); }

        }



        public NavigationViewModel()

        {

            ArCommand = new BaseCommand(OpenAran);

            SmesCommand = new BaseCommand(OpenSmestaji);

            PrevozCommand = new BaseCommand(OpenPrevozi);

            AdminCommand = new BaseCommand(OpenAdmin);

            KlijentCommand = new BaseCommand(OpenKlijent);

        }

        private void OpenAran(object obj)

        {

            SelectedViewModel = new Aranžmani();

        }

        private void OpenSmestaji(object obj)

        {

            SelectedViewModel = new Smeštaji();

        }
        private void OpenPrevozi(object obj)

        {

            SelectedViewModel = new Prevozi();

        }
        private void OpenKlijent(object obj)

        {

            SelectedViewModel = new Klijenti();

        }
        private void OpenAdmin(object obj)

        {

            SelectedViewModel = new Administracija();

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propName)

        {

            if (PropertyChanged != null)

            {

                PropertyChanged(this, new PropertyChangedEventArgs(propName));

            }

        }

        public class BaseCommand : ICommand
        {
            private Predicate<object> _canExecute;
            private Action<object> _method;
            public event EventHandler CanExecuteChanged;

            public BaseCommand(Action<object> method)
                : this(method, null)
            {
            }

            public BaseCommand(Action<object> method, Predicate<object> canExecute)
            {
                _method = method;
                _canExecute = canExecute;
            }

            public bool CanExecute(object parameter)
            {
                if (_canExecute == null)
                {
                    return true;
                }

                return _canExecute(parameter);
            }

            public void Execute(object parameter)
            {
                _method.Invoke(parameter);
            }
        }

    }
}
