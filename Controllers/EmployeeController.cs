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
            var get_details = await employeeModelRepo.MyDetailsAsync(id);
            return Ok(get_details);
        }
        [HttpGet]
        [Route("ShowAll")]

        public async Task<IActionResult> ShowAll()
        {
            var get_allemp = await employeeModelRepo.ShowAllEMPAsync();
            return Ok(get_allemp);
        }
        [HttpPut]
        [Route("InsertEmpolyee")]
        public async Task<int> InsertEmployee(EmployeeModel employeeModel)
        {
            var add = await employeeModelRepo.Insert_Employee_Async(employeeModel);
            return 1;
        }

        [HttpPut]
        [Route("Login/{email}/{password}")]
        public async Task<int> Login(string email, string password)
        {
            var add = await employeeModelRepo.Login_Async(email, password);
            return 1;
        }

    }
}
