using Inventory_Management_System.Helpers;
using Inventory_Management_System.Services;
using Inventory_Management_System.Views.Admin;
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
    public class HomeViewModel: INotifyPropertyChanged
    {

        public ICommand AdminCommand { get; set; }
        public ICommand ReportsCommand { get; set; }
        public ICommand ProductsCommand { get; set; }
        public ICommand LogoutCommand { get; set; }
        public HomeViewModel()
        {
            // Command to handle the login button click
            AdminCommand = new RelayCommand(Admin);
            ReportsCommand = new RelayCommand(Reports);
            ProductsCommand = new RelayCommand(Products);
            LogoutCommand = new RelayCommand(Logout);
        }

        private void Admin()
        {
            Console.WriteLine("Admin button clicked");
            Utilities.ChangeForm((Form)Application.OpenForms["Home"], new Admin());
        }

        private void Reports()
        {
            Console.WriteLine("Reports button clicked");
            
        }

        private void Products()
        {
            Console.WriteLine("Products button clicked");
            Utilities.ChangeForm((Form)Application.OpenForms["Home"], new Products());
        }

        private void Logout()
        {
            Console.WriteLine("Logout button clicked");
            AuthServices.Logout();
            Utilities.ChangeForm((Form)Application.OpenForms["Home"], new LogIn());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
