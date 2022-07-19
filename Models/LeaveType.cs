using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Models
{
    public class LeaveType
    {
        public int Id { get; set; }
        public string TypeOfLeave { get; set; }
        public int Balance { get; set; }
    }
}
