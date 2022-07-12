using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Models
{
    public class LeaveSectionDB
    {
        public int EmployeeId { get; set; }

        public int LeaveID { get; set; }
        public int NumberOfDay { get; set; }
        public DateTime StrartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string LeaveType { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        public DateTime AppliedOn { get; set; }
        public string ManagerComments { get; set; }
    }
}
