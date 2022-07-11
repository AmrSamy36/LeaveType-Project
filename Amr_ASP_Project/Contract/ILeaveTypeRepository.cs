using Amr_ASP_Project.Data;
using System.Collections.Generic;

namespace Amr_ASP_Project.contract
{
    public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    {
        ICollection<LeaveType> GetEmployeesByLeaveType(int id);
    }
}
