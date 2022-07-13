﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjectAPI.Models
{
    public class EmployeeModelDB
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public string EmployeeEmail { get; set; }

        public long EmployeeMobieNumber { get; set; }

        public DateTime DateOfJoin { get; set; }
        public string EmployeeDepartment { get; set; }

        public int BalanceLeave { get; set; }
        public string Password { get; set; }
    }
}
