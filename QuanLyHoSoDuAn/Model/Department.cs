using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoSoDuAn.Model
{
    public class Department
    {
        public string DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string ManagerID { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
