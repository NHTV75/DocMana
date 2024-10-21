using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyHoSoDuAn.Model
{
    [Table("User_Groups")]
    public class User_Group
    {
        public string UserID { get; set; }
        [ForeignKey("UserID")] public User User { get; set; }
        public string GroupID { get; set; }
        [ForeignKey("GroupID")] public Group Group { get; set; }
        public string Role { get; set; }
        public DateTime JoinedDate { get; set; }
        public User_Group(string userID, string groupID, string role)
        {
            UserID = userID;
            GroupID = groupID;
            Role = role;
            JoinedDate = DateTime.Now;
        }
    }
}
