using Amr_ASP_Project.Data;
using Amr_ASP_Project.Models;
using AutoMapper;

namespace Amr_ASP_Project.Mapping
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
            CreateMap<LeaveHistory, LeaveHistoryVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();
        }
    }
}
