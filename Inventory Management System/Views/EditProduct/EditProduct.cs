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

namespace Inventory_Management_System.Views.EditProduct
{
    public partial class EditProduct : Form
    {
        private Inventory_Management_System.ViewModel.EditProductViewModel _viewModel;
        public EditProduct()
        {
            _viewModel = new EditProductViewModel();
            InitializeComponent();

            txtID.DataBindings.Add("Text", _viewModel, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtName.DataBindings.Add("Text", _viewModel, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDescription.DataBindings.Add("Text", _viewModel, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPrice.DataBindings.Add("Text", _viewModel, "Price", true, DataSourceUpdateMode.OnPropertyChanged);
            txtQuantity.DataBindings.Add("Text", _viewModel, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSupplier.DataBindings.Add("Text", _viewModel, "Supplier", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCategory.DataBindings.Add("Text", _viewModel, "Category", true, DataSourceUpdateMode.OnPropertyChanged);

            btnEditProduct.Click += (sender, args) => _viewModel.EditProductCommand.Execute(null);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Utilities.ChangeForm(this, new Inventory_Management_System.Views.RadGrid.RadGrid());
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
