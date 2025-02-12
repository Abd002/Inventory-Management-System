using Inventory_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Inventory_Management_System.ViewModel
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        private Product product;

        public ProductViewModel()
        {
            product = new Product();
        }

        public int Id
        {
            get { return product.Id; }
            set
            {
                if (product.Id != value)
                {
                    product.Id = value;
                    OnPropertyChanged(nameof(Id));
                }
            }
        }

        public string Name
        {
            get { return product.Name; }
            set
            {
                if (product.Name != value)
                {
                    product.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
