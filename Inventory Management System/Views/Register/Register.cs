using Inventory_Management_System.ViewModel;
using MetroFramework.Forms;
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
    public partial class Register : MetroForm
    {
        private RegisterViewModel _viewModel;
        public Register()
        {
            InitializeComponent();

            _viewModel = new RegisterViewModel();

            txtUsername.DataBindings.Add("Text", _viewModel, "Username");
            txtPassword.DataBindings.Add("Text", _viewModel, "Password");
            txtEmail.DataBindings.Add("Text", _viewModel, "Email");

            btnRegister.Click += (sender, args) => _viewModel.LoginCommand.Execute(null);
        }


        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Utilities.ChangeForm(this, new LogIn());
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {

        }
    }
}
