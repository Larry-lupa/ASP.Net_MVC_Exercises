using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ASP.Net_MVC_Exercises.Models;

namespace ASP.Net_MVC_Exercises.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int? customerId)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == customerId);

            if (customerId == null)
            {
                return HttpNotFound();
            }
            
            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer()
                {
                    Id = 1,
                    Name = "John Smith"
                },
                new Customer()
                {
                    Id = 2,
                    Name = "Mary Williams"
                }
            };
        }
    }
}