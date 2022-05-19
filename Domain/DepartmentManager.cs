using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DepartmentManager
    {
        public int ManagerId { get; set; }
        public string? ManagerFullName { get; set; }
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
    public class DepartmentDM { 
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public  DateTime FromDate { get; set; }
        public   DateTime  ToDate { get; set; }

    }
}
