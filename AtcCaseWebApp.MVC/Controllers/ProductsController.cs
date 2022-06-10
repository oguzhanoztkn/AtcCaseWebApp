using AtcCaseWebApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtcCaseWebApp.MVC.Controllers
{
    public class ProductsController : Controller
    {
        NORTHWNDContext _context;

        public ProductsController(NORTHWNDContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Index(int max, int min)
        {

            var list = _context.Products.Where(p => p.UnitPrice > min && p.UnitPrice < max).ToList();
            return View(list);
        }
    }
}
