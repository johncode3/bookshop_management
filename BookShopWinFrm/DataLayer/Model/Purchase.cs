using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopWinFrm.DataLayer.Model
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string RefNumber { get; set; }
        public int VendorId { get; set; }
        public int EmployeeId { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public string Note { get; set; } = string.Empty;

    }
}
