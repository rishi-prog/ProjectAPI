using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectAPI.Models;

namespace ProjectAPI.Repository
{
    public interface IEmployeeModelRepo
    {
        Task<EmployeeModel> MyDetailsAsync(int? id);
        Task<List<EmployeeModel>> ShowAllEMPAsync();
        Task<int> Insert_Employee_Async(EmployeeModel employeeModel);
    }
}
