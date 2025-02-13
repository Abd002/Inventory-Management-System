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
            try
            {
                // Define Connection String
                string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True;";

                // Create SQL Query for Inventory Report
                string query = "SELECT ProductID, ProductName, Description, QuantityInStock, Price, Category, SupplierName FROM Inventory.Products"; // Example: Low Stock Items

                // Connect to Database
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataSet ds = new DataSet();
                    Console.WriteLine(ds);
                    da.Fill(ds, "Products");

                    // Load Crystal Report
                    ReportDocument cryRpt = new ReportDocument();
                    cryRpt.Load(@"C:\Users\abdel\source\repos\SimpleDataApp\SimpleDataApp\CrystalReport1.rpt");  // Update the correct path

                    // Set DataSource
                    cryRpt.SetDataSource(ds.Tables["Products"]);

                    // Bind to CrystalReportViewer
                    crystalReportViewer1.ReportSource = cryRpt;
                    crystalReportViewer1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Report: " + ex.Message);
            }

        }
    }
}
