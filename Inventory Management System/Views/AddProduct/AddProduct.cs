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
using System.Xml.Linq;

namespace Inventory_Management_System.Views.AddProduct
{
    public partial class AddProduct : Form
    {
        private AddProductViewModel _viewModel;
        public AddProduct()
        {
            _viewModel = new AddProductViewModel();
            InitializeComponent();

       
            txtName.DataBindings.Add("Text", _viewModel, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDescription.DataBindings.Add("Text", _viewModel, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPrice.DataBindings.Add("Text", _viewModel, "Price", true, DataSourceUpdateMode.OnPropertyChanged);
            txtQuantity.DataBindings.Add("Text", _viewModel, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSupplier.DataBindings.Add("Text", _viewModel, "Supplier", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCategory.DataBindings.Add("Text", _viewModel, "Category", true, DataSourceUpdateMode.OnPropertyChanged);

            btnAddProduct.Click += (sender, args) => _viewModel.AddProductCommand.Execute(null);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Utilities.ChangeForm(this, new Inventory_Management_System.Views.RadGrid.RadGrid());
        }
    }
}
