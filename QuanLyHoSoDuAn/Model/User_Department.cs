using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyHoSoDuAn.Model
{
    [Table("User_Deparments")]
    public class User_Department
    {
        public string UserID { get; set; }
        [ForeignKey("UserID")] public User User { get; set; }
        public string DepartmentID { get; set; }
        [ForeignKey("DepartmentID")] public Department Department { get; set; }
        public string Role { get; set; }
        public DateTime AssignedDate { get; set; }
        public User_Department(string userID, string departmentID, string role)
        {
            UserID = userID;
            DepartmentID = departmentID;
            Role = role;
            AssignedDate = DateTime.Now;
        }
    }
}
