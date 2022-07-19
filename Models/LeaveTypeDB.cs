using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjectAPI.Models
{
    public class LeaveTypeDB
        
    {
        [Key]
        public int LeaveTypeID { get; set; }
        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public virtual EmployeeModelDB Employee { get; set; }
        public string SickLeave { get; set; }
        public string PaternityLeave { get; set; }
        public string EarnedLeave { get; set; }
        
    }
}
