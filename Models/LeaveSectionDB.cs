using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProjectAPI.Models
{
    public class LeaveSectionDB
    {

      
        [Key]
        public int LeaveID { get; set; }
        public int NumberOfDay { get; set; }
        public DateTime StrartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string LeaveType { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        public DateTime AppliedOn { get; set; }
        public string ManagerComments { get; set; }

        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public virtual EmployeeModelDB Employee { get; set; }

        [ForeignKey("ManagerId")]
        public int ManagerId { get; set; }
        public virtual ManagerModelDB Manager { get; set; }
    }
}
