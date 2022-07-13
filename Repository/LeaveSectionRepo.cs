using ProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectAPI.DataAccessLayer;
using AutoMapper;

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
        public   List<LeaveSection> ShowAllLeaves (int? id)
        {
            var all_leaves  =  dataAccessLayerDB.LeaveSection.Where(x=>x.EmployeeId == id);
            var leaves =  mapper.Map<List<LeaveSection>>(all_leaves);
            return leaves;
            
        }
    }
}
