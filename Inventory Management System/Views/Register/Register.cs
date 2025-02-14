using Inventory_Management_System.ViewModel;
using Inventory_Management_System.Views.LoginForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Views.Register
{
    public partial class Register : Form
    {
        private RegisterViewModel _viewModel;
        public Register()
        {
            InitializeComponent();

            _viewModel = new RegisterViewModel();

            txtUsername.DataBindings.Add("Text", _viewModel, "Username", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPassword.DataBindings.Add("Text", _viewModel, "Password", true, DataSourceUpdateMode.OnPropertyChanged);

            btnRegister.Click += (sender, args) => _viewModel.LoginCommand.Execute(null);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Utilities.ChangeForm(this, new Inventory_Management_System.Views.LoginForm.LogIn());
        }
    }
}
