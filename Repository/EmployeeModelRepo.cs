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

        public async Task<int> DeleteEmp_Async(int? id)
        {
            var data = await dataAccessLayerDB.Employee.FirstAsync(x=>x.EmployeeId==id);
            if (data != null) 
            {
                 dataAccessLayerDB.Employee.Remove(data);
                await dataAccessLayerDB.SaveChangesAsync();
            }

            return 1;
        }

        public async Task<int> Insert_Employee_Async(EmployeeModelDB employeeModelDB)
        {
           
           
               await dataAccessLayerDB.Employee.AddAsync(employeeModelDB);
                await dataAccessLayerDB.SaveChangesAsync();

          

            return 1;
        }

        public async Task<EmployeeModel> Login_Async(int id, string password)
        {
            var data = await dataAccessLayerDB.Employee.FirstOrDefaultAsync(x => x.EmployeeId == id & x.Password == password);



            var map = mapper.Map<EmployeeModel>(data);


            return map;


        }

        public async Task<EmployeeModelDB> Login_Async2(string email, string password)
        {
            var data = await dataAccessLayerDB.Employee.FirstOrDefaultAsync(x => x.EmployeeEmail == email & x.Password == password);
            return data;
            
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

        public async Task<int> Update_Async(int? id, EmployeeModel employeeModel)
        {
            var data = await dataAccessLayerDB.Employee.FirstOrDefaultAsync(x => x.EmployeeId == id);
            if (data != null) 
            {         
        data.EmployeeName = employeeModel.EmployeeName;
                data.EmployeeEmail = employeeModel.EmployeeEmail;
                data.EmployeeMobieNumber = employeeModel.EmployeeMobieNumber;
                data.DateOfJoin = employeeModel.DateOfJoin;
                data.EmployeeDepartment = employeeModel.EmployeeDepartment;
                
               await dataAccessLayerDB.SaveChangesAsync();
            }
            return 1;
        }
    }
}