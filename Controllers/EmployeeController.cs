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
        [HttpPost]
        [Route("InsertEmpolyee")]
        public async Task<int> InsertEmployee(EmployeeModelDB employeeModelDB)
        {
            var add = await employeeModelRepo.Insert_Employee_Async(employeeModelDB);
            return 1;
        }

        [HttpGet]
        [Route("Login/{id}/{password}")]
        public async Task<int> Login(int id, string password)
        {
            var add = await employeeModelRepo.Login_Async(id, password);
            if (add == 0) {
                return 0;
            }
            return 1;
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<int> Delete(int? id)
        {
            var get_details = await employeeModelRepo.DeleteEmp_Async(id);
            return 1;
        }

        [HttpPost]
        [Route("Update/{id}")]

        public async Task<int> Update(int? id,EmployeeModel employeeModelDB)
        {
            var add = await employeeModelRepo.Update_Async(id ,employeeModelDB);
            return 1;
        }
        [HttpGet]
        [Route("Login2/{email}/{password}")]
        public async Task<EmployeeModelDB> Login2(string email, string password)
        {
            var add = await employeeModelRepo.Login_Async2(email, password);
            return add;
           
        }
    }
}
