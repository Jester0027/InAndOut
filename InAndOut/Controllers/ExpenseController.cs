using InAndOut.Data;
using InAndOut.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace InAndOut.Controllers
{
    [Route("expenses")]
    public class ExpenseController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ExpenseController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Expense> expenses = _context.Expenses;
            return View(expenses);
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Expense expense)
        {
            if(ModelState.IsValid)
            {
                _context.Expenses.Add(expense);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expense);
        }

        [HttpGet("update/{id}")]
        public IActionResult Update(int id)
        {
            var expense = _context.Expenses.Find(id);
            if(expense == null)
            {
                return NotFound();
            }
            return View(expense);
        }

        [HttpPost("update/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Expense expense)
        {
            if (!ModelState.IsValid)
            {
                return View(expense);
            }
            _context.Expenses.Update(expense);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var expense = _context.Expenses.Find(id);
            if(expense == null)
            {
                return NotFound();
            }
            return View(expense);

        }

        [HttpPost("delete/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult PostDelete(int? id)
        {
            var expense = _context.Expenses.Find(id);
            if (expense == null)
            {
                return NotFound();
            }
            _context.Expenses.Remove(expense);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
