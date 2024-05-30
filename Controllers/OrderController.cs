using DBFirstEg.NWModels;
using Microsoft.AspNetCore.Mvc;

namespace DBFirstEg.Controllers
{
    public class OrderController : Controller
    {
        private readonly NorthwindContext db=new NorthwindContext();

        public IActionResult Index()
        {
            foreach(var item in db.Orders)
            {
                Console.WriteLine(item.Customer.ContactName);
                Console.WriteLine(item.Employee.FirstName);
                Console.WriteLine(item.ShipViaNavigation.Phone);
                foreach(var i in item.OrderDetails)
                {
                    Console.WriteLine(i.UnitPrice);
                }
            }
            return View();
        }
    }
}
