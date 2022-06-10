using AtcCaseWebApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtcCaseWebApp.MVC.Controllers
{
    public class CompaniesController : Controller
    {
        NORTHWNDContext _context;

        public CompaniesController(NORTHWNDContext context)
        {
            _context = context;
        }

        public IActionResult Index(string p)
        {
            var list = _context.Suppliers.Where(s => s.Country == p).ToList();
            return View(list);
        }
      
    }
}
