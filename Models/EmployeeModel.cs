using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjectAPI.Models
{
    public class EmployeeModel
    {
       
        public int EmployeeId { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string EmployeeEmail { get; set; }
        [Required]
        public long EmployeeMobieNumber { get; set; }
        [Required]
        public DateTime DateOfJoin { get; set; }
        [Required]
        public string EmployeeDepartment { get; set; }
        public string Images { get; set; }
        [Required]
        public int ManagerId { get; set; }

    }
}
