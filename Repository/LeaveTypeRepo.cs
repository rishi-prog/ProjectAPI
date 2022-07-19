using ProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectAPI.DataAccessLayer;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ProjectAPI.Repository
{
    public class LeaveTypeRepo : ILeaveTypeRepo
    {
        private readonly DataAccessLayerDB dataAccessLayer;
        private readonly IMapper mapper;

        public LeaveTypeRepo(DataAccessLayerDB dataAccessLayer,IMapper mapper)
        {
            this.dataAccessLayer = dataAccessLayer;
            this.mapper = mapper;
        }
        public async Task<LeaveType> LeaveType_showLeaveBalance(int? id)
        {
            var data = await dataAccessLayer.LeaveType.FirstOrDefaultAsync(x => x.EmployeeId == id);
            var map = mapper.Map<LeaveType>(data);
            return map;
        }
    }
}
