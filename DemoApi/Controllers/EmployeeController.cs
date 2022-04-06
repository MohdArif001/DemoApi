using DemoApi.Repositery.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployee employeeService;

        public EmployeeController(IEmployee emp)
        {
            employeeService = emp;
        }
        public IActionResult Get()
        {
            var results = employeeService.GetEmployees();
            if (results.Count > 0)
            {

                return Ok(results);
            }
            else
            {
                return NotFound("Employee not found");
            }
        }   
    }
}
