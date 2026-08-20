using BookShopWinFrm.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopWinFrm.DataLayer.Model
{
    public class SaleDetail
    {
        public int SaleDetailId { get; set; }
        public int SaleId { get; set; }
        public int ItemId { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Quantity { get; set; } = 0;
        public decimal UnitPriceAtSale { get; set; }
        public decimal DiscountAmount { get; set; } = 0;
        public decimal Price { get; set; }
    }
}