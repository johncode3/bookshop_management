using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopWinFrm.DataLayer.Model
{
    public class InventoryAdjustment
    {
        public int InventoryAdjustmentId { get; set; }
        public DateTime AdjustmentDate { get; set; }
        public string RefNumber { get; set; }
        public int EmployeeId { get; set; }
        public string Note { get; set; } = string.Empty;
    }
}
