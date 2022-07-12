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
    public class EmployeeModelRepo : IEmployeeModelRepo
    {
        private readonly DataAccessLayerDB dataAccessLayerDB;
        private readonly IMapper mapper;

        public EmployeeModelRepo( DataAccessLayerDB dataAccessLayerDB,IMapper mapper)
        {
            this.dataAccessLayerDB = dataAccessLayerDB;
            this.mapper = mapper;
        }


        public async Task<EmployeeModel> MyDetailsAsync(int? id)
        {
            var details = await dataAccessLayerDB.Employee.FirstOrDefaultAsync(x => x.EmployeeId==id);
            var details_View = mapper.Map<EmployeeModel>(details);

            return details_View;
        }
    }
}
