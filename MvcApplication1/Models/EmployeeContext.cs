using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    //Establish a link with the database
    public class EmployeeContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}