﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ProjectAPI.Models
{
    public class ManagerModel
    {
            
            public int ManagerId { get; set; }
            [Required]
            public string ManagerName { get; set; }
           [Required]
            public string ManagerEmail { get; set; }
           [Required]
            public long ManagerMobileNumber { get; set; }
       
    }
}
