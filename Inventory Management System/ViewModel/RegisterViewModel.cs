using Inventory_Management_System.Helpers;
using Inventory_Management_System.Models;
using Inventory_Management_System.Views.LoginForm;
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
    public class RegisterViewModel : INotifyPropertyChanged
    {
        private User _user;

        public ICommand LoginCommand { get; set; }
        public RegisterViewModel()
        {
            
            _user = new User();
            Username = "Username";
            Password = "Password";
            LoginCommand = new RelayCommand(Register);
        }
        

        public string Username
        {
            get { return _user.Username; }
            set
            {
                if (_user.Username != value)
                {
                    _user.Username = value;
                    OnPropertyChanged(nameof(Username));
                }
            }
        }

        public string Password
        {
            get { return _user.Password; }
            set
            {
                if (_user.Password != value)
                {
                    _user.Password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        private void Register()
        {
            Console.WriteLine("Register button clicked");
            if(_user.Username == null || _user.Password == null)
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }
            if(_user.Username.Length < 3 || _user.Password.Length < 3)
            {
                MessageBox.Show("Username and password must be at least 3 characters long");
                return;
            }
            if(Services.DatabaseService.GetUser(_user.Username, _user.Password) != null)
            {
                MessageBox.Show("Username already exists");
                return;
            }
            _user.IsAdmin = false;

            Services.DatabaseService.AddUser(_user);
            MessageBox.Show("User added successfully");

            Utilities.ChangeForm((Form)Application.OpenForms["Register"], new LogIn());
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
