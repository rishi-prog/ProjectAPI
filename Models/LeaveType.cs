using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectAPI.Models
{
    public class LeaveType
    {

        public int LeaveTypeID { get; set; }
        public string SickLeave { get; set; }
        public string PaternityLeave { get; set; }
        public string EarnedLeave { get; set; }
    }
}
