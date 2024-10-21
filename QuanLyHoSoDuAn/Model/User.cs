using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyHoSoDuAn.Model
{
    [Table("Users")]
    public class User
    {
        [Key]
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public User(string userName, string defaultPassword, string fullName, string gender, string role, string status)
        {
            UserName = userName;
            Password = defaultPassword;
            FullName = fullName;
            Gender = gender;
            Role = role;
            Status = status;
            CreateDate = DateTime.Now;
        }
    }
}
