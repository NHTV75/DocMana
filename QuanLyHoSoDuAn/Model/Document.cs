using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoSoDuAn.Model
{
    public class Document
    {
        public string DocumentID { get; set; }
        public string ProjectID { get; set; }
        public string DocumentName { get; set; }
        public string Version { get; set; }
        public string Status { get; set; }
        public string SubmittedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
