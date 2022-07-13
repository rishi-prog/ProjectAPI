using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjectAPI.Models
{
    public class LeaveSection
    {
        public int LeaveID { get; set; }
        [Required]
        public int EmployeeId { get; set; }      
        [Required]
        public int NumberOfDay { get; set; }
        [Required]
        public DateTime StrartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public string LeaveType { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Reason { get; set; }
        [Required]
        public DateTime AppliedOn { get; set; }
        [Required]
        public string ManagerComments { get; set; }
    }
}
