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

      

        public async Task<int> Insert_Employee_Async(EmployeeModel employeeModel)
        {
            var add = mapper.Map<EmployeeModelDB>(employeeModel);

            if (add != null) 
            {
               await dataAccessLayerDB.Employee.AddAsync(add);
                await dataAccessLayerDB.SaveChangesAsync();

            }

            return 1;
        }

        public async Task<int> Login_Async(string email, string password)
        {
            var data = await dataAccessLayerDB.Employee.FirstOrDefaultAsync(x => x.EmployeeEmail == email & x.Password == password);
            var map = mapper.Map<EmployeeModel>(data);

            return 1;
        }

        public async Task<EmployeeModel> MyDetailsAsync(int? id)
        {
            var details = await dataAccessLayerDB.Employee.FirstOrDefaultAsync(x => x.EmployeeId==id);
            var details_View = mapper.Map<EmployeeModel>(details);

            return details_View;
        }

        public async Task<List<EmployeeModel>> ShowAllEMPAsync()
        {
            var list_emp = await dataAccessLayerDB.Employee.ToListAsync();
            var map_list = mapper.Map<List<EmployeeModel>>(list_emp);
            return map_list;
        }

    }
}