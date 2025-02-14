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
using Telerik.WinControls.UI;

namespace Inventory_Management_System.Views.RadGrid
{
    public partial class RadGrid :Form
    {
        private RadGridViewModel _viewModel;
        public RadGrid()
        {
            _viewModel = new RadGridViewModel();
            InitializeComponent();

            // Subscribe to the CellClick event of the RadGridView
            this.radGridView1.CellClick += RadGridView1_CellClick;

            // The rest of your code remains the same
            if (AuthServices.MainUser.IsAdmin)
            {
                Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
                gridViewCommandColumn1.DefaultText = "Delete";
                gridViewCommandColumn1.HeaderText = "Delete";
                gridViewCommandColumn1.Name = "DeleteColumn";
                gridViewCommandColumn1.UseDefaultText = true;
                gridViewCommandColumn1.Width = 15;
                this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCommandColumn1 });
            }

            comboStock.SelectedIndex = 1;
            radGridView1.DataSource = _viewModel.Data;

            this.Load += new System.EventHandler(this.Terlik_Load);

            _viewModel.RequestRefresh += () =>
            {
                radGridView1.DataSource = _viewModel.Data;
                radGridView1.Refresh();
            };

            textSearchName.DataBindings.Add("Text", _viewModel, "SearchName", true, DataSourceUpdateMode.OnPropertyChanged);
            comboStock.DataBindings.Add("Text", _viewModel, "StockChoice", true, DataSourceUpdateMode.OnPropertyChanged);

            btnAddProduct.Visible = AuthServices.MainUser.IsAdmin;
            btnEdit.Visible = AuthServices.MainUser.IsAdmin;

            DataTable dt = DatabaseService.GetProducts();
            comboCategory.DataSource = dt;
            comboCategory.SelectedIndex = -1;
            comboCategory.DisplayMember = "Category";
            comboCategory.DataBindings.Add("Text", _viewModel, "CategoryChoice", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void Terlik_Load(object sender, EventArgs e)
        {
            //radGridView1.DataSource = DatabaseService.GetProducts();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Utilities.ChangeForm(this, new AddProduct.AddProduct());
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Utilities.ChangeForm(this, new Home());
        }

        private void RadGridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.Row != null && e.Row is GridViewDataRowInfo)
            {
                if (e.Column.Name == "DeleteColumn")
                {
                    DeleteRow(e.Row);
                }
            }
        }



        private void DeleteRow(GridViewRowInfo row)
        {
            var selectedRowData = row.DataBoundItem as DataRowView;
            if (selectedRowData != null)
            {

                DatabaseService.DeleteProduct(int.Parse(selectedRowData.Row["ProductID"].ToString()));

                _viewModel.Data = DatabaseService.GetProducts();
                radGridView1.DataSource = _viewModel.Data;
                radGridView1.Refresh();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Utilities.ChangeForm(this, new EditProduct.EditProduct());
        }
    }
}
