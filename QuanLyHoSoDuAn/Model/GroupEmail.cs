using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoSoDuAn.Model
{
    public class GroupEmail
    {
        public string EmailID { get; set; }
        public string SenderID { get; set; }
        public string ProfileID { get; set; }
        public string[] Recipients { get; set; }
        public string[] CCList { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime SendDate { get; set; }
    }
}
