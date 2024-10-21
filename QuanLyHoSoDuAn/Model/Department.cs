using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyHoSoDuAn.Model
{
    [Table("Deparments")]
    public class Department
    {
        public string DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string ManagerID { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        [ForeignKey("ManagerID")] public User User { get; set; }

        public Department (string departmentName, string mamagerID, string description)
        {
            DepartmentName = departmentName;
            ManagerID = mamagerID;
            Description = description;
            CreateDate = DateTime.Now;
        }
    }
}
