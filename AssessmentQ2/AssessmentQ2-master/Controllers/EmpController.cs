using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentQ2.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentQ2.Controllers
{
    public class EmpController : Controller
    {
        List<Employee> obj = new List<Employee>()
            {
                new Employee{Eid=1,Ename="Ketan",Designation="Developer" },
                new Employee{Eid=2,Ename="Jagpreet",Designation="Developer"},
                new Employee{Eid=3,Ename="Swati",Designation="Developer"},
                new Employee{Eid=4,Ename="Somnath",Designation="Developer"},
            };
        public IActionResult Index()
        {
            ViewBag.Employee = obj;
            return View();
        }
    }
}