using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectAPI.Models;

namespace ProjectAPI.DataAccessLayer
{
    public class DataAccessLayerDB:DbContext
    {
        public DataAccessLayerDB(DbContextOptions<DataAccessLayerDB>options):base(options)
        {

        }

        public DbSet<EmployeeModelDB> Employee { get; set; }
        public DbSet<ManagerModelDB> Manager { get; set; }
        public DbSet<LeaveSectionDB> LeaveSection { get; set; }
       
    }
}
