using Inventory_Management_System.Helpers;
using Inventory_Management_System.Models;
using Inventory_Management_System.Services;
using Inventory_Management_System.Views.Products;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Inventory_Management_System.ViewModel
{
    public class AddProductViewModel: INotifyPropertyChanged
    {
        private Product _product;

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
        public ICommand AddProductCommand { get; set; }
        public AddProductViewModel()
        {
            _product = new Product();
            Name = "Name";
            Description = "Description";
            Quantity = "0";
            Price = "0";
            Category = "Category";
            Supplier = "Supplier";

            AddProductCommand = new RelayCommand(AddProduct);
        }

        private void AddProduct()
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Description) || string.IsNullOrEmpty(Quantity) || string.IsNullOrEmpty(Price) || string.IsNullOrEmpty(Category) || string.IsNullOrEmpty(Supplier))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            DatabaseService.AddProduct(_product);
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
