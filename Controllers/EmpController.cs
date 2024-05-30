using DBFirstEg.Models;
using DBFirstEg.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DBFirstEg.Controllers
{
    public class EmpController : Controller
    {

        private readonly IEmpServ<Employee> _empserv;

        //Dependency Injection - the instance of dbcontext is created only when the action methods of Emp controller is invoked.
        public EmpController(IEmpServ<Employee> empserv)
        {
            _empserv = empserv;
        }


        public IActionResult EmployeesIndex()
        {
            var emplist=_empserv.getAllEmployes();
            return View(emplist);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            var depts = _empserv.getDeparments();
            ViewBag.Deptid = new SelectList(depts, "Did", "Dname");
            return View();
        }

        

        [HttpPost]
        public IActionResult AddEmployee(Employee e)
        {
            _empserv.AddEmployee(e);
            return RedirectToAction("EmployeesIndex");
        }


















    }
}
