using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyHoSoDuAn.Model
{
    [Table("Projects")]
    public class Project
    {
        [Key]
        public string ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        [ForeignKey("CreatedBy")] public User User { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Project(string projectName, string description, string status, string createdBy)
        {
            ProjectName = projectName;
            Description = description;
            Status = status;
            CreatedBy = createdBy;
            StartDate = DateTime.Now;
            CreateDate = DateTime.Now;
        }
    }
}
