using Inventory_Management_System.Helpers;
using Inventory_Management_System.Models;
using Inventory_Management_System.Views.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Inventory_Management_System.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _username;
        private string _password;

        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; }
        public LoginViewModel()
        {
            // Command to handle the login button click
            LoginCommand = new RelayCommand(Login);
            RegisterCommand = new RelayCommand(Register);
        }

        public string Username
        {
            get { return _username; }
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged(nameof(Username));
                }
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }


        

        private void Login()
        {
            Console.WriteLine("Login button clicked");
            User user = Services.AuthServices.Authenticate(Username, Password);

            if (user == null)
            {
                MessageBox.Show("Invalid username or password");
                return;
            }

            Utilities.ChangeForm((Form)Application.OpenForms["LogIn"], new Home());

        }
        private void Register()
        {
            Utilities.ChangeForm((Form)Application.OpenForms["LogIn"], new Register());
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
