using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoSoDuAn.Model
{
    public class User_Group
    {
        public string UserID { get; set; }
        public string GroupID { get; set; }
        public string Role { get; set; }
        public DateTime JoinedDate { get; set; }
    }
}
