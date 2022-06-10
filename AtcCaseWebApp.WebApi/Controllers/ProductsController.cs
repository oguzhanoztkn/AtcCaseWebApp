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
    public class ProductsController : ControllerBase
    {
        NORTHWNDContext _context;

        public ProductsController(NORTHWNDContext context)
        {
            _context = context;
        }
        [Route("[action]/{max}/{min}")]
        [HttpGet("{max}/{min}")]
        public IActionResult Index(int max, int min)
        {

            var list = _context.Products.Where(p => p.UnitPrice > min && p.UnitPrice < max).ToList();
            return Ok(list);
        }
    }
}
