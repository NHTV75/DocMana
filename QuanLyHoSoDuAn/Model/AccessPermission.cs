using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoSoDuAn.Model
{
    public class AccessPermission
    {
        public string PermissionID { get; set; }
        public string UserID { get; set; }
        public string ProfileID { get; set; }
        public string AccessLevel { get; set; }
    }
}
