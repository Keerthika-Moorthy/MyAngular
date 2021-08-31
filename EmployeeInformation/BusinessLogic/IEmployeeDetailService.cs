using EmployeeInformation.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInformation.BusinessLogic
{
    public interface IEmployeeDetailService
    {
        Task<List<EmployeeDto>> GetEmployeeDetails(int ID);
        Task<bool> SaveEmployeeDetails(List<EmployeeDto> employeeDtos);
    }
    
}
