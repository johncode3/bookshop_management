using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopWinFrm.DataLayer.Model
{
    public class PurchaseDetail
    {
        public int PurchaseDetailId { get; set; }
        public int PurchaseId { get; set; }
        public int ItemId { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Quantity { get; set; } = 0;
        public decimal UnitPrice { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
