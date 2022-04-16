using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefsDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsDishes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MyContext _context;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.AllChefs = _context.Chefs.Include(a => a.Dishes).ToList();
            return View();
        }

        [HttpGet("chef/new")]
        public IActionResult newChef()
        {
            return View("NewChef");
        }


        [HttpPost("/chef/new/post")]
        public IActionResult postNewChef(Chef newChef)
        {
            if(ModelState.IsValid)
            {
                if(newChef.DateOfBirth > DateTime.Now)
                {
                    ModelState.AddModelError("DateOfBirth","Date has to not be at the future");
                    return View("NewChef");
                }else
                {
                    _context.Add(newChef);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }else
            {
                return View("NewChef");
            }

        }


        [HttpGet("/dishes")]
        public IActionResult Dishes()
        {
            ViewBag.AllDishes = _context.Dishes.Include(a => a.Chef).OrderBy(a => a.Chef.FirstName).ToList();
            return View("Dishes");
        }


        [HttpGet("/dishes/new")]
        public IActionResult NewDishes()
        {
            ViewBag.AllChefs = _context.Chefs.ToList();
            return View("NewDishes");
        }

        [HttpPost("/dishes/new/post")]
        public IActionResult postNewDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                _context.Dishes.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Dishes");
            }else
            {
                ViewBag.AllChefs = _context.Chefs.ToList();
                return View("NewDishes");
            }

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
