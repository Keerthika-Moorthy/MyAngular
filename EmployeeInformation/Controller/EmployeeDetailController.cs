using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeInformation.BusinessLogic;
using EmployeeInformation.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeInformation.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDetailController : ControllerBase
    {
        private readonly IEmployeeDetailService employeeDetail;

        public EmployeeDetailController(IEmployeeDetailService employeeDetail)
        {
            this.employeeDetail = employeeDetail;
        }

        [HttpGet("{ID}")]
        public ActionResult<List<EmployeeDto>> GetEmployeeDetail(int ID)
        {
            try
            {
                var result = employeeDetail.GetEmployeeDetails(ID).Result;
                return Ok(result);
            }
            catch (Exception ex)
            {
              
                return StatusCode(500, ex.Message);
            }
        }


        [HttpPost("SaveEmployeeDetails")]
        public ActionResult<bool> SaveEmployeeDetail([FromBody]List<EmployeeDto> employeeDtos)
        {
            try
            {
                var result = employeeDetail.SaveEmployeeDetails(employeeDtos).Result;
                return Ok(result);
            }

            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

    }
}