using Inventory_Management_System.Models;
using Inventory_Management_System.Services;
using Inventory_Management_System.ViewModel;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Views.Products
{
    public partial class Products : MetroForm
    {
        private ProductViewModel _viewModel;
        public Products()
        {
            InitializeComponent();

            _viewModel= new ProductViewModel();
            dataGridView.DataSource = _viewModel.Data;

            tblAdmin.Visible = AuthServices.MainUser.IsAdmin;

            // Bind ViewModel to controls
            txtNameSearch.DataBindings.Add("Text", _viewModel, "Name_search", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCategorySearch.DataBindings.Add("Text", _viewModel, "Category_search", true, DataSourceUpdateMode.OnPropertyChanged);
            //txtStock.DataBindings.Add("Text", _viewModel, "Stock_search", true, DataSourceUpdateMode.OnPropertyChanged);
            //comboBoxStock.DataBindings.Add("Text", _viewModel, "Stock_search", true, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxStock.DataBindings.Add("Text", _viewModel, "SelectedStock", true, DataSourceUpdateMode.OnPropertyChanged);

            txtID.DataBindings.Add("Text", _viewModel, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtName.DataBindings.Add("Text", _viewModel, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDescription.DataBindings.Add("Text", _viewModel, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPrice.DataBindings.Add("Text", _viewModel, "Price", true, DataSourceUpdateMode.OnPropertyChanged);
            txtQuantity.DataBindings.Add("Text", _viewModel, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged); 
            txtSupplier.DataBindings.Add("Text", _viewModel, "Supplier", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCategory.DataBindings.Add("Text", _viewModel, "Category", true, DataSourceUpdateMode.OnPropertyChanged); 


            // Bind the LoginCommand to the button
            btnSearch.Click += (sender, args) => _viewModel.SearchCommand.Execute(null);
            btnBack.Click += (sender, args) => _viewModel.BackCommand.Execute(null);
            btnEditOrAdd.Click += (sender, args) => _viewModel.EditOrAddCommand.Execute(null);
            btnDelete.Click += (sender, args) => _viewModel.DeleteCommand.Execute(null);

            _viewModel.RequestRefresh += () =>
            {
                dataGridView.DataSource = _viewModel.Data;
                dataGridView.Refresh(); // Refresh DataGridView when the event is raised
                _viewModel.SelectedStock = comboBoxStock.Text;
            };
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dataGridView.Refresh();
        }

        private void btnEditOrAdd_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _viewModel.Data;
            dataGridView.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _viewModel.Data;
            dataGridView.Refresh();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
