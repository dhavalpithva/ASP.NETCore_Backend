using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Models
{
    public class Employee
    {
        public Employee()
        {
            this.Departments = new List<Department>();
        }

        public int EmployeeId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string JobTitle { get; set; }
        public string Address { get; set; }
        public int DepartmentId { get; set; }
        public List<Department> Departments { get; set; }
    }
}
