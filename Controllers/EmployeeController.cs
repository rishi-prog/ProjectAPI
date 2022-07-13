using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectAPI.Repository;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeModelRepo employeeModelRepo;

        public EmployeeController(IEmployeeModelRepo employeeModelRepo)
        {
            this.employeeModelRepo = employeeModelRepo;
        }
        [HttpGet]
        [Route("MyDetails/{id}")]

        public async Task<IActionResult> MyDetails_Id(int? id) 
        {
            var get_details =await employeeModelRepo.MyDetailsAsync(id);
            return Ok(get_details);
        } 
    }
}
