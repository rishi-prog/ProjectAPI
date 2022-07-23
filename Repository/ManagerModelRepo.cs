using ProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProjectAPI.DataAccessLayer;
using Microsoft.EntityFrameworkCore;

namespace ProjectAPI.Repository
{
    public class ManagerModelRepo:IManagerModelRepo
    {
        private readonly DataAccessLayerDB dataAccessLayerDB;
        private readonly IMapper mapper;

        public ManagerModelRepo(DataAccessLayerDB dataAccessLayerDB,IMapper mapper)
        {
            this.dataAccessLayerDB = dataAccessLayerDB;
            this.mapper = mapper;
        }


        public async Task<ManagerModel> getManagerAsync(int? id)
        {
            var details = await dataAccessLayerDB.Manager.FirstOrDefaultAsync(x=>x.EmployeeId==id);
            var details_View = mapper.Map<ManagerModel>(details);

            return details_View;

        }
        public async Task<ManagerModel> MLogin_Async(int id, string password)
        {
            var data = await dataAccessLayerDB.Manager.FirstOrDefaultAsync(x => x.EmployeeId == id & x.Password == password);

            if (data != null)
            {

                var map = mapper.Map<ManagerModel>(data);
                return map;

            }
            throw new Exception("Invalid Credential ");


        }
    }
}
