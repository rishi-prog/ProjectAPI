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
    public class ManagerController : ControllerBase
    {
        private readonly IManagerModelRepo managerModelRepo;

        public ManagerController(IManagerModelRepo managerModelRepo)
        {
            this.managerModelRepo = managerModelRepo;
        }

        [HttpPost]
        [Route("MyMangerDetails/{id}")]

        public async Task<IActionResult> getMangaerDetails(int? id)
        {
            var get_details_manager = await managerModelRepo.getManagerAsync(id);
            return Ok(get_details_manager);
        }
    }
}
