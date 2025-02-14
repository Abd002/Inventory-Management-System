using Inventory_Management_System.Helpers;
using Inventory_Management_System.Models;
using Inventory_Management_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inventory_Management_System.ViewModel
{
    public class RadGridViewModel : INotifyPropertyChanged
    {
        private DataTable _data;

        private string _searchName;

        private StockStatus _stockChoice;

        private string _categoryChoice;

        public string CategoryChoice
        {
            get { return _categoryChoice; }
            set
            {
                _categoryChoice = value;
                Data = DatabaseService.SearchProducts(_searchName, _categoryChoice, _stockChoice);
                OnPropertyChanged(nameof(CategoryChoice));
                OnRequestRefresh();
            }
        }

        public string SearchName
        {
            get { return _searchName; }
            set
            {
                _searchName = value;
                Data = DatabaseService.SearchProducts(_searchName);


                OnPropertyChanged(nameof(SearchName));
                OnRequestRefresh();

            }
        }
        public string StockChoice
        {
            get { return _stockChoice.ToString(); }
            set
            {
                _stockChoice = (value == "OUT OF STOCK" ? StockStatus.OUT_OF_STOCK : (value == "LOW STOCK" ? StockStatus.LOW_STOCK : StockStatus.HIGH_STOCK)); ;
                Data = DatabaseService.SearchProducts(_searchName, "", _stockChoice);
                OnPropertyChanged(nameof(StockChoice));
                OnRequestRefresh();
            }
        }

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

        public RadGridViewModel()
        {
            StockChoice = "NULL";
            Data = new DataTable();
            Data = DatabaseService.GetProducts();
        }

        public event Action RequestRefresh;
        protected virtual void OnRequestRefresh()
        {
            RequestRefresh?.Invoke();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
