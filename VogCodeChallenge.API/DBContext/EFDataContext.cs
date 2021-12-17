using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.DBContext
{
    public class EFDataContext: DbContext
    {
        public EFDataContext(DbContextOptions<EFDataContext> options) : base(options)
        {
        }
        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}
