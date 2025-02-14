using Inventory_Management_System.Services;
using Inventory_Management_System.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Views.LoginForm
{
    public partial class LogIn : Form
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

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            AuthServices.Authenticate(_viewModel.Username, _viewModel.Password);
            Utilities.ChangeForm(this, new Home());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Utilities.ChangeForm(this, new Inventory_Management_System.Views.Register.Register());
        }
    }
}
