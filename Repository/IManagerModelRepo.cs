using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectAPI.Models;
namespace ProjectAPI.Repository
{
   public interface IManagerModelRepo
    {
        Task<ManagerModel> getManagerAsync(int? id);
    }
}
