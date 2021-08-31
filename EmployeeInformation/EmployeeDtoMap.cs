using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.FluentMap.Mapping;
using EmployeeInformation.DTO;

namespace EmployeeInformation
{
    public class EmployeeDtoMap : EntityMap<EmployeeDto>
    {
        public EmployeeDtoMap()
        {
            this.Map(c => c.ID).ToColumn("ID");
            this.Map(c => c.Name).ToColumn("Emp_Name");
            this.Map(c => c.Email).ToColumn("Emp_Email");
            this.Map(c => c.PhoneNo).ToColumn("Emp_Contact");
            this.Map(c => c.Designation).ToColumn("Emp_Designation");
            this.Map(c => c.CreatedDate).ToColumn("Crt_Dt");


        }
    }
}
