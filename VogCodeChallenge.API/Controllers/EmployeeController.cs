using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VogCodeChallenge.API.Models;
using VogCodeChallenge.API.Services;

namespace VogCodeChallenge.API.Controllers
{
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employee)
        {
            employeeService = employee;
        }
        [HttpGet]
        [Route("api/employees")]
        public IEnumerable<Employee> GetEmployee()
        {
            return employeeService.GetAll();
        }

        [HttpGet]
        [Route("api/employees/department/{departmentId}")]
        public IEnumerable<Employee> GetEmployeeByDept(int departmentId)
        {
            return employeeService.ListAll().Where(x => x.DepartmentId == departmentId);            
        }
    }
}
