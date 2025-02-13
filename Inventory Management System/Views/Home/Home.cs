using Inventory_Management_System.ViewModel;
using Inventory_Management_System.Views.Products;
using Inventory_Management_System.Views.Report;
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
    public partial class Home : MetroForm
    {
        private HomeViewModel _viewModel;
        public Home()
        {
            InitializeComponent();
            _viewModel = new HomeViewModel();
            btnAdmin.Click += (sender, args) => _viewModel.AdminCommand.Execute(null);
            btnLogOut.Click += (sender, args) => _viewModel.LogoutCommand.Execute(null);
            btnProducts.Click += (sender, args) => _viewModel.ProductsCommand.Execute(null);
            btnReports.Click += (sender, args) => _viewModel.ReportsCommand.Execute(null);

        }

        private void txtAdmin_Click(object sender, EventArgs e)
        {

        }

        private void txtReports_Click(object sender, EventArgs e)
        {
            Utilities.ChangeForm(this, new Report());
        }

        private void txtProducts_Click(object sender, EventArgs e)
        {
        }

        private void txtLogOut_Click(object sender, EventArgs e)
        {

        }
    }
}
