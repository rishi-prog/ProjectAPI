using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Models;
using ProjectAPI.Repository;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveTypeController : ControllerBase
    {
        private readonly ILeaveTypeRepo leaveTypeRepo;

        public LeaveTypeController(ILeaveTypeRepo leaveTypeRepo)
        {
            this.leaveTypeRepo = leaveTypeRepo;
        }

        [HttpGet]
        public async Task<LeaveType> ShowBalanceLeave(int? id)
        {
            var data = await leaveTypeRepo.LeaveType_showLeaveBalance(id);
            return data;
        }
    }
}
