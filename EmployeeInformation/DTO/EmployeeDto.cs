using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInformation.DTO
{
    public class EmployeeDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
        public string ActionType { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
