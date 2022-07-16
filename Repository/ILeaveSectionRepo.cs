using ProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Repository
{
   public interface ILeaveSectionRepo
    {
       List<LeaveSection> ShowAllLeaves(int? id);
        int ManagerState(int? id , LeaveSection leaveSection );

        Task<int> NewLeave(LeaveSection leaveSection);

    }
}
