using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Models
{
    public class Logger
    {
        public int Id { get; set; }
        public string ActionType { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public DateTime Timestamp { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }

    }
}
