using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Model;
namespace WebApplication4.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();
        // GET: Employee
        public ActionResult Index()
        {
            var employees = dbContext.Employees.ToList();
            return View(employees);
        }
    }
}