using Inventory_Management_System.Helpers;
using Inventory_Management_System.Models;
using Inventory_Management_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Inventory_Management_System.ViewModel
{
    public class EditProductModelView
    {
        private Product _product;

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
        public ICommand EditProductCommand { get; set; }
        public EditProductModelView()
        {
            _product = new Product();
            Name = "Name";
            Description = "Description";
            Quantity = "0";
            Price = "0";
            Category = "Category";
            Supplier = "Supplier";

            EditProductCommand = new RelayCommand(EditProduct);
        }

        private void EditProduct()
        {
            if(_product.Id == 0)
            {
                MessageBox.Show("Please enter a valid ID");
                return;
            }
            Product product = DatabaseService.GetProduct(_product.Id);
            Product new_product = _product;
            if (string.IsNullOrEmpty(new_product.Name))
            {
                new_product.Name = product.Name;
            }
            if (string.IsNullOrEmpty(new_product.Description))
            {
                new_product.Description = product.Description;
            }
            if (new_product.Quantity == 0)
            {
                new_product.Quantity = product.Quantity;
            }
            if (new_product.Price == 0)
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

            MessageBox.Show("Product updated successfully");
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
