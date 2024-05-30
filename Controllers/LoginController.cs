using DBFirstEg.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBFirstEg.Controllers
{
    public class LoginController : Controller
    {
        private readonly FisbankDbContext _db;

        public LoginController(FisbankDbContext db)
        {
            _db = db;
        }
        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult login(Usertbl l)
        {
            var res = (from i in _db.Usertbls
                       where (i.Email == l.Email && i.Password == l.Password)
                       select i).SingleOrDefault();
            if (res != null)
            {
                HttpContext.Session.SetString("uname", res.Username);
                return RedirectToAction("EmployeesIndex", "Emp");
            }
            else
                return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("login");
        }
    }
}
