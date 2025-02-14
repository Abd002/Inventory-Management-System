using Inventory_Management_System.Services;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Views.Admin
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

            dataGridView.DataSource = DatabaseService.GetAuditLog();
            dataGridView.Refresh(); // Refresh DataGridView when the event is raised
        }
    }
}
