using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopWinFrm.DataLayer.Model
{
    public class AppUser
    {
        public int AppUserId { get; set; }
        public int EmployeeId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public byte[] Avatar { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
