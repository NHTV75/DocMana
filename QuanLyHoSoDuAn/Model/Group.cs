using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyHoSoDuAn.Model
{
    [Table("Groups")]
    public class Group
    {
        [Key]
        public string GroupID { get; set; }
        public string GroupName { get; set; }
        public string DeparmentID { get; set; }
        [ForeignKey("DeparmentID")] public Department Department { get; set; }
        public string LeaderID { get; set; }
        [ForeignKey("LeaderID")] public User User { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Group(string groupName, string departmentID, string leaderID)
        {
            GroupName = groupName;
            DeparmentID = departmentID;
            LeaderID = leaderID;
            CreateDate = DateTime.Now;
        }
    }
}
