using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Helpers
{
    // enum for stock status to generalize the stock status of the products
    public enum StockStatus
    {
        OUT_OF_STOCK = 0,
        LOW_STOCK = 50,
        HIGH_STOCK = 1000,
        ALL
    }

}
