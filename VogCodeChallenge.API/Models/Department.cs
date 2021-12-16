using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Models
{
    public class Department
    {
        public Department()
        {
            this.Employees = new List<Employee>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
