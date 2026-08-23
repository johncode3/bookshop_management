using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopWinFrm.DataLayer.Model
{
    public class InventoryAdjustmentDetail
    {
        public int InventoryAdjustmentDetailId { get; set; }
        public int InventoryAdjustmentId { get; set; }
        public int ItemId { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Quantity { get; set; } = 0;
        public decimal UnitPrice { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
