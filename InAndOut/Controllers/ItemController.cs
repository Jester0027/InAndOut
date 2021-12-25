using InAndOut.Data;
using InAndOut.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace InAndOut.Controllers
{
    [Route("items")]
    public class ItemController : Controller
    {

        private readonly ApplicationDbContext _dbContext;

        public ItemController(ApplicationDbContext db)
        {
            _dbContext = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Item> items = _dbContext.Items;
            return View(items);
        }
    }
}
