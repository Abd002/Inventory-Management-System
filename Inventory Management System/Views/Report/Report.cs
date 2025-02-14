using CrystalDecisions.CrystalReports.Engine;
using Inventory_Management_System.ViewModel;
using System;
using System.Windows.Forms;

namespace Inventory_Management_System.Views.Report
{
    public partial class Report : MetroFramework.Forms.MetroForm
    {
        private ReportViewModel _viewModel;

        public Report()
        {
            InitializeComponent();
            _viewModel = new ReportViewModel();

            _viewModel.PropertyChanged += ViewModel_PropertyChanged;
        }

        private void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ReportViewModel.ReportDocument))
            {
                crystalReportViewer1.ReportSource = _viewModel.ReportDocument;
                crystalReportViewer1.Refresh();
            }
        }

    }
}
