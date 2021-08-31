using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeInformation.DTO;
using EmployeeInformation.Repository;

namespace EmployeeInformation.BusinessLogic
{
    public class EmployeeDetailService : IEmployeeDetailService
    {
        private readonly IEmployeeDetailsRepository employeeDetailsRepository;

        public EmployeeDetailService(IEmployeeDetailsRepository employeeDetailsRepository)
        {
            this.employeeDetailsRepository = employeeDetailsRepository;
        }

        public async Task<List<EmployeeDto>> GetEmployeeDetails(int ID)
        {
            return await employeeDetailsRepository.GetEmployeeDetail(ID);
        }

        public async Task<bool> SaveEmployeeDetails(List<EmployeeDto> employeeDtos)
        {
            return await employeeDetailsRepository.SaveEmployeeDetail(employeeDtos);

        }
    }
}
