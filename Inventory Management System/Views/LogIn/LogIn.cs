using Inventory_Management_System.Models;
using Inventory_Management_System.ViewModel;
using Inventory_Management_System.Views.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class LogIn : MetroFramework.Forms.MetroForm
    {
        private LoginViewModel _viewModel;

        public LogIn()
        {

            InitializeComponent();
            _viewModel = new LoginViewModel();

            // Bind ViewModel to controls
            txtUsername.DataBindings.Add("Text", _viewModel, "Username", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPassword.DataBindings.Add("Text", _viewModel, "Password", true, DataSourceUpdateMode.OnPropertyChanged);


            // Bind the LoginCommand to the button
            btnLogIn.Click += (sender, args) => _viewModel.LoginCommand.Execute(null);
            btnRegister.Click += (sender, args) => _viewModel.RegisterCommand.Execute(null);
        }



        private void btnLogIn_Click(object sender, EventArgs e)
        {


        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
