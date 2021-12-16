using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.DBContext;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Services
{
    public class EmployeeService : IEmployeeService
    {
        List<Department> departments;
        List<Employee> employees;
        public EmployeeService()
        {
            departments = new List<Department>(new Department[] {
            new Department() { DepartmentId = 1, DepartmentName = "Sales" },
            new Department() { DepartmentId = 3, DepartmentName = "Manager" },
            new Department() { DepartmentId = 5, DepartmentName = "Reception" },
            new Department() { DepartmentId = 6, DepartmentName = "Human Resources" },
        });


            employees = new List<Employee>(new Employee[] {
            new Employee() {
                Firstname = "Dwight",
                Lastname = "Schrute",
                JobTitle = "Sales Executive",
                Address ="7403 Marshall St.Midland, MI 48640",
                DepartmentId = 1,
                Department = departments.First(d => d.DepartmentId == 1),
                Departments = new List<Department>(departments.Where(d => d.DepartmentId == 1))},
            new Employee() {
                Firstname = "Jim",
                Lastname = "Halpert",
                JobTitle = "Account Executive",
                Address ="458 Carson Street Hartselle, AL 35640",
                DepartmentId = 1,
                Department = departments.First(d => d.DepartmentId == 5),
                Departments = new List<Department>(departments.Where(d => d.DepartmentId == 5))},
            new Employee() {
                Firstname = "Mimi",
                Lastname = "Bobeck",
                JobTitle = "President of Sales",
                Address ="146 Glen Ridge Drive Campbell, CA 95008",
                DepartmentId = 5,
                Department = departments.First(d => d.DepartmentId == 5),
                Departments = new List<Department>(departments.Where(d => d.DepartmentId == 5))},
            new Employee() {
                Firstname = "Drew",
                Lastname = "Carry",
                JobTitle = "Project Manager",
                Address ="720 Lafayette Court Peabody, MA 01960",
                DepartmentId = 6,
                Department = departments.First(d => d.DepartmentId == 6),
                Departments = new List<Department>(departments.Where(d => d.DepartmentId == 3))}
        });
        }


        public IEnumerable<Employee> GetAll()
        {
            // This will be used to get the data from DB. 
            return employees.ToList();
        }

        public IList<Employee> ListAll()
        {
            // This will be used to get the data from DB. 
            return employees.ToList();
        }
    }
}
