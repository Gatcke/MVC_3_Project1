using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    [Table ("Employees")]

    public class Employee
    {
        public int employeeId { get; set; }

        public string name { get; set; }

        public string gender { get; set; }

        public string city { get; set; }

    }
}