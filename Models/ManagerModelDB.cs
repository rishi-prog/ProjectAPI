﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProjectAPI.Models
{
    public class ManagerModelDB
    {
        [Key]
        public int ManagerId { get; set; }
       
        public string ManagerName { get; set; }
        public string ManagerEmail { get; set; }
        public long ManagerMobileNumber { get; set; }
        public string Password { get; set; }
    }
}
