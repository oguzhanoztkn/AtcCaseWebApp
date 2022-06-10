using AtcCaseWebApp.MVC.Models;
using AtcCaseWebApp.MVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AtcCaseWebApp.MVC.Controllers
{
    public class HomeController : Controller
    {
        NORTHWNDContext _context;
        public HomeController(NORTHWNDContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var list = _context.Suppliers.ToList();
            return View(list);
        }

      


    }
}
