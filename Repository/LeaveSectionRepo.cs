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
    public class LeaveSectionRepo : ILeaveSectionRepo
    {
        private readonly DataAccessLayerDB dataAccessLayerDB;
        private readonly IMapper mapper;

        public LeaveSectionRepo(DataAccessLayerDB dataAccessLayerDB, IMapper mapper  )
        {
            this.dataAccessLayerDB = dataAccessLayerDB;
            this.mapper = mapper;
        }

        public int ManagerState(int? id, LeaveSection leaveSection)
        {
            var data = dataAccessLayerDB.LeaveSection.Where(x => x.EmployeeId == id).FirstOrDefault();
            if (data != null) 
            {
                data.ManagerComments = leaveSection.ManagerComments;
                data.Status = leaveSection.Status;
                dataAccessLayerDB.SaveChanges();
            }

            return 1;
        }

        public async Task<int> NewLeave(LeaveSection leaveSection)
        {
            var data = mapper.Map<LeaveSectionDB>(leaveSection);
           await dataAccessLayerDB.LeaveSection.AddAsync(data);
            await  dataAccessLayerDB.SaveChangesAsync();

            return 1;
            
        }

        public  List<LeaveSection> ShowAllLeaves (int? id)
        {
            var all_leaves = dataAccessLayerDB.LeaveSection.Where(x => x.EmployeeId == id);
            var leaves =  mapper.Map<List<LeaveSection>>(all_leaves);
            return leaves;
            
        }
    }
}
