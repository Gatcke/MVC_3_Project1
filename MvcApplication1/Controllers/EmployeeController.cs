using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

        public ActionResult Details(int id)
        {
            //Employee employee = new Employee()
            //{
            //    employeeId = 12,
            //    name = "Tom",
            //    gender = "male",
            //    city = "Pretoria"
            //};

            //First connect to the database table or the database
            EmployeeContext employeeContext = new EmployeeContext();

            //Then you need to retrieve the information of the database entity you wish to use
            
           Employee employee = employeeContext.Employees.Single(emp => emp.employeeId == id);
            return View(employee);
        }

        public ActionResult DetailsTwo()
        {
            Employee employee = new Employee()
            {
                employeeId = 12,
                name = "Tom",
                gender = "male",
                city = "Pretoria"
            };
            return View(employee);
        }
    }
}
