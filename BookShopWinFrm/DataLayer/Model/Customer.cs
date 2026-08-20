using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopWinFrm.DataLayer.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; }   = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string CustomerType { get; set; }
        public decimal MemberDiscount { get; set; }
        public int IsDeleted { get; set; } = 0;
    }
}
