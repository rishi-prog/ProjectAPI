using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectAPI.Repository;
using ProjectAPI.Models;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveSectionController : ControllerBase
    {
        private readonly ILeaveSectionRepo leaveSectionRepo;

        public LeaveSectionController(ILeaveSectionRepo leaveSectionRepo)
        {
            this.leaveSectionRepo = leaveSectionRepo;

        }
        [HttpGet]
        [Route("ShowAll_Leaves/{id}")]
        public List<LeaveSection> Leave_List(int? id)
        {
            var list = leaveSectionRepo.ShowAllLeaves(id);
            return list;
        }

        [HttpPatch]
        [Route("ChangeStatus/{id}")]

        public int ChangeState(int? id, LeaveSection leaveSection)
        {
            var data = leaveSectionRepo.ManagerState(id, leaveSection);
            return 1;
        }

        [HttpPatch]
        [Route("Approve_Deny/{id}")]

        public int Approve_Deny(int? id, LeaveSection leaveSection)
        {
            var data = leaveSectionRepo.Manager(id, leaveSection);
            return 1;
        }

        [HttpPost]
        [Route("NewLeave")]

        public async Task<int> AddNewLeave(LeaveSection leave)
        {
            var newleave = await leaveSectionRepo.NewLeave(leave);
            return 1;
        }

        [HttpGet]
        [Route("ShowAllPendingLeave")]
        public List<LeaveSection> ShowPending(int? id)
        {
            var data = leaveSectionRepo.ShowAllPending(id);
            return data;
        }

        [HttpGet]
        [Route("ShowLeave/{id}")]
        public IActionResult ShowLeave(int? id) 
        {
            var data = leaveSectionRepo.ShowLeave(id);
            return Ok(data);
        }

    }

   
}
