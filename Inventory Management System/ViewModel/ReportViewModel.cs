using CrystalDecisions.CrystalReports.Engine;
using Inventory_Management_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.ViewModel
{
    public class ReportViewModel : BaseViewModel
    {

        private ReportDocument _reportDocument;

        public ReportDocument ReportDocument
        {
            get { return _reportDocument; }
            private set
            {
                _reportDocument = value;
                OnPropertyChanged(nameof(ReportDocument));
            }
        }

        public ReportViewModel()
        {
            LoadReport();
        }

        public void LoadReport()
        {
            DataTable dt = DatabaseService.GetProducts();

            ReportDocument report = new ReportDocument();
            report.Load(@"C:\Users\abdel\source\repos\Inventory Management System\Inventory Management System\CrystalReport.rpt");
            report.SetDataSource(dt);

            ReportDocument = report;
        }

    }
}
