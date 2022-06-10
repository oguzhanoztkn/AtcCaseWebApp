using AtcCaseWebApp.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtcCaseWebApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        NORTHWNDContext _context;

        public CompaniesController(NORTHWNDContext context)
        {
            _context = context;
        }
        [Route("[action]/{p}")]
        public IActionResult Index(string p)
        {
            var list = _context.Suppliers.Where(s => s.Country == p).ToList();
            return Ok(list);
        }
    }
}
