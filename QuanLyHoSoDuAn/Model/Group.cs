using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoSoDuAn.Model
{
    public class Group
    {
        public string GroupID { get; set; }
        public string GroupName { get; set; }
        public string DeparmentID { get; set; }
        public string LeaderID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
