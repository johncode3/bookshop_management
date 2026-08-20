using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BookShopWinFrm.DataLayer.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Sex { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; } = string.Empty;
        public string MaritalStatus { get; set; }
        public int HaveSpouse { get; set; }
        public int NumberOfChildren { get; set; }
        public DateTime HiredDate { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public int IsActive { get; set; }
    }
}
