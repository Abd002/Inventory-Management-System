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
    public class RadGridViewModel : BaseViewModel
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
                if (value == "ALL" || value == "NULL")
                {
                    _stockChoice = StockStatus.ALL;
                }
                else if (value == "OUT OF STOCK")
                {
                    _stockChoice = StockStatus.OUT_OF_STOCK;
                }
                else if (value == "LOW STOCK")
                {
                    _stockChoice = StockStatus.LOW_STOCK;
                }
                else if (value == "HIGH STOCK")
                {
                    _stockChoice = StockStatus.HIGH_STOCK;
                }
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
    }
}
