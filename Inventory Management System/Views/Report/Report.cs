using CrystalDecisions.CrystalReports.Engine;
using Inventory_Management_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Views.Report
{
    public partial class Report : MetroFramework.Forms.MetroForm
    {
        public Report()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            DataTable dt = DatabaseService.GetProducts();

            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"C:\Users\abdel\source\repos\SimpleDataApp\SimpleDataApp\CrystalReport1.rpt"); 

            cryRpt.SetDataSource(dt); 

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
