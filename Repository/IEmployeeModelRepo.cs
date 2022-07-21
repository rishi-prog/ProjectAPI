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
        Task<int> Insert_Employee_Async(EmployeeModelDB employeeModelDB);
        Task<int> Login_Async(int  id, string password);
        Task<EmployeeModelDB> Login_Async2(string email, string password);

        Task<int> DeleteEmp_Async(int ?id);

        Task<int> Update_Async(int? id, EmployeeModel employeeModel);
    }
}
