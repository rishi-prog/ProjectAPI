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
        public  List<LeaveSection> Leave_List(int? id)
        {
            var list =  leaveSectionRepo.ShowAllLeaves(id);
            return list ;
        }

    }

   
}
