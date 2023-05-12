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

        public ActionResult Details()
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
