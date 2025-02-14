using Inventory_Management_System.Services;
using Inventory_Management_System.ViewModel;
using Inventory_Management_System.Views.Admin;
using Inventory_Management_System.Views.LoginForm;
using Inventory_Management_System.Views.Products;
using Inventory_Management_System.Views.RadGrid;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            btnAdmin.Visible = AuthServices.MainUser.IsAdmin;
        }


        private void txtReports_Click(object sender, EventArgs e)
        {
            Form form = new Report();
            form.Show();
        }

        private void txtProducts_Click(object sender, EventArgs e)
        {
            Utilities.ChangeForm(this, new RadGrid());
        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            AuthServices.Logout();
            Utilities.ChangeForm(this, new LogIn());
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Form form = new Admin();
            form.Show();    
        }
    }
}
