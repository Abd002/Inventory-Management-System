using Inventory_Management_System.Helpers;
using Inventory_Management_System.Models;
using Inventory_Management_System.Services;
using Inventory_Management_System.Views.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static Telerik.WinControls.UI.ValueMapper;


namespace Inventory_Management_System.ViewModel
{
    // not used, because i used radgridview
    public class ProductViewModel : BaseViewModel
    {
        private DataTable _data;

        private Product _product;

        private string _name_search;
        private string _category_search;
        private StockStatus _selectedStock;

        public DataTable Data
        {
            get { return _data; }
            set
            {
                _data = value;
                OnPropertyChanged(nameof(Data));
                OnRequestRefresh();
            }
        }

        public string SelectedStock
        {
            get { return _selectedStock.ToString(); }
            set
            {
                _selectedStock = (value == "OUT OF STOCK" ? StockStatus.OUT_OF_STOCK : (value == "LOW STOCK" ? StockStatus.LOW_STOCK : StockStatus.HIGH_STOCK)); ;
                Data = DatabaseService.SearchProducts(_name_search, "", _selectedStock);
                OnPropertyChanged(nameof(SelectedStock));
                OnRequestRefresh();
            }
        }


        public string Id
        {
            get { return _product.Id.ToString(); } 
            set
            {
                if (int.TryParse(value, out int newValue))
                {
                    if (_product.Id != newValue)
                    {
                        _product.Id = newValue;
                        OnPropertyChanged(nameof(Id));
                    }
                }

            }
        }

        public string Name
        {
            get { return _product.Name; }
            set
            {
                if (_product.Name != value)
                {
                    _product.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public string Description
        {
            get { return _product.Description; }
            set
            {
                if (_product.Description != value)
                {
                    _product.Description = value;
                    OnPropertyChanged(nameof(Description));
                }
            }
        }

        public string Quantity
        {
            get { return _product.Quantity.ToString(); }
            set
            {
                if (int.TryParse(value, out int newValue)) 
                {
                    if (_product.Quantity != newValue)
                    {
                        _product.Quantity = newValue;
                        OnPropertyChanged(nameof(Quantity));
                    }
                }
            }
        }


        public string Price
        {
            get { return _product.Price.ToString("0.##"); }
            set
            {
                if (float.TryParse(value, out float newValue))
                {
                    if (_product.Price != newValue)
                    {
                        _product.Price = newValue;
                        OnPropertyChanged(nameof(Price));
                    }
                }
            }
        }


        public string Category
        {
            get { return _product.Category; }
            set
            {
                if (_product.Category != value)
                {
                    _product.Category = value;
                    OnPropertyChanged(nameof(Category));
                }
            }
        }

        public string Supplier
        {
            get { return _product.Supplier; }
            set
            {
                if (_product.Supplier != value)
                {
                    _product.Supplier = value;
                    OnPropertyChanged(nameof(Supplier));
                }
            }
        }
        public string Name_search
        {
            get { return _name_search; }
            set
            {
                if (_name_search != value)
                {
                    _name_search = value;
                    OnPropertyChanged(nameof(Name_search));
                }
            }
        }

        public string Category_search
        {
            get { return _category_search; }
            set
            {
                if (_category_search != value)
                {
                    _category_search = value;
                    OnPropertyChanged(nameof(Category_search));
                }
            }
        }



        public ICommand SearchCommand { get; set; }
        public ICommand BackCommand { get; set; }
        public ICommand EditOrAddCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public event Action RequestRefresh;
        protected virtual void OnRequestRefresh()
        {
            RequestRefresh?.Invoke();
        }


        public ProductViewModel()
        {
            _product = new Product();
            Data = new DataTable();
            updateData();

            DeleteCommand = new RelayCommand(Delete);
            SearchCommand = new RelayCommand(Search);
            BackCommand = new RelayCommand(Back);
            EditOrAddCommand = new RelayCommand(EditOrAdd);
        }

        private void updateData()
        {
            Data = DatabaseService.GetProducts();
        }

        private void EditOrAdd()
        {
            Console.WriteLine("Edit or Add button clicked");

            if (_product.Id==0)
            {
                if(string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Description) || string.IsNullOrEmpty(Quantity) || string.IsNullOrEmpty(Price) || string.IsNullOrEmpty(Category) || string.IsNullOrEmpty(Supplier))
                {
                    MessageBox.Show("Please fill all fields");
                    return;
                }

                DatabaseService.AddProduct(_product);
            }
            else
            {
                Product product = DatabaseService.GetProduct(_product.Id);
                Product new_product = _product;
                if (string.IsNullOrEmpty(new_product.Name)){
                    new_product.Name = product.Name;
                }
                if(string.IsNullOrEmpty(new_product.Description))
                {
                    new_product.Description = product.Description;
                }
                if (new_product.Quantity == 0)
                {
                    new_product.Quantity = product.Quantity;
                }
                if(new_product.Price == 0)
                {
                    new_product.Price = product.Price;
                }
                if (string.IsNullOrEmpty(new_product.Category))
                {
                    new_product.Category = product.Category;
                }
                if (string.IsNullOrEmpty(new_product.Supplier))
                {
                    new_product.Supplier = product.Supplier;
                }
                
                DatabaseService.UpdateProduct(new_product);
            }
            updateData();

        }
        private void Back()
        {
            Console.WriteLine("Back button clicked");
            Utilities.ChangeForm((Form)Application.OpenForms["Products"], new Home());
        }


        private void Search()
        {
            Console.WriteLine("Search button clicked");

            Data = DatabaseService.SearchProducts(_name_search, _category_search, _selectedStock);
        }
        private void Delete()
        {
            Console.WriteLine("Delete button clicked");
            if (_product.Id == 0)
            {
                MessageBox.Show("Please select a product to delete");
                return;
            }
            DatabaseService.DeleteProduct(_product.Id);

            updateData();
        }


    }
}
