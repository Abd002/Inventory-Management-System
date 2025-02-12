using Inventory_Management_System.Helpers;
using Inventory_Management_System.Models;
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
        public string Email
        {
            get { return _user.Email; }
            set
            {
                if (_user.Email != value)
                {
                    _user.Email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        private void Register()
        {
            Console.WriteLine("Register button clicked");
            if(_user.Username == null || _user.Password == null || _user.Email == null)
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }
            if(Services.DatabaseService.GetUser(_user.Username) != null)
            {
                MessageBox.Show("Username already exists");
                return;
            }

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
