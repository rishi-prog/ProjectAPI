using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectAPI.Models;

namespace ProjectAPI.Helper
{
    public class AutoMapper:Profile
    {
        public AutoMapper()
        {
            CreateMap<EmployeeModel, EmployeeModelDB>().ReverseMap();
            CreateMap<LeaveSection, LeaveSectionDB>().ReverseMap();
            CreateMap<ManagerModel, ManagerModelDB>().ReverseMap();
        }

    }
}
