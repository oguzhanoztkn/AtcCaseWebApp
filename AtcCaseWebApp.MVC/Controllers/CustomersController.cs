using AtcCaseWebApp.MVC.Models;
using AtcCaseWebApp.MVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtcCaseWebApp.MVC.Controllers
{
    public class CustomersController : Controller
    {
        NORTHWNDContext _context;

        public CustomersController(NORTHWNDContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index(string id)
        {

            List<Customer> customers = _context.Customers.ToList();
            List<Order> orders = _context.Orders.ToList();
            List<OrderDetail> orderDetails = _context.OrderDetails.ToList();

            var result = from cst in customers
                         join ord in orders on cst.CustomerId equals ord.CustomerId
                         join odt in orderDetails on ord.OrderId equals odt.OrderId
                         where cst.CustomerId == id
                         select new CustomerVM
                         {
                             Customer = cst,
                             Order = ord,
                             OrderDetail = odt
                         };

            result.ToList();
            return View(result);


        }
    }
}
