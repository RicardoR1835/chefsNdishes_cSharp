using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using chefsNdishes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace chefsNdishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
     
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        public DateTime Now = DateTime.Now;
        private static int CalculateAge(DateTime dateOfBirth)  
        {  
            int age = 0;  
            age = DateTime.Now.Year - dateOfBirth.Year;  
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)  
                age = age - 1;  
        
            return age;  
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            List<Chef> AllChefs = dbContext.Chefs
            .Include(chef => chef.DishesCreated)
            .ToList();
            return View(AllChefs);
        }

        [HttpGet("new")]
        public IActionResult AddChef()
        {
            return View("AddChef");
        }

        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            List<Dish> AllDishes = dbContext.Dishes
            .Include(dish => dish.Creator)
            .ToList();
            List<Chef> AllChefs = dbContext.Chefs
            .ToList();
            ViewBag.AllChefs = AllChefs;
            return View(AllDishes);
        }

        [HttpPost("addchef")]
        public IActionResult AddChef(Chef newChef)
        {
            Console.WriteLine(newChef.FName);
            Console.WriteLine(newChef.LName);
            if(ModelState.IsValid)
            {

                int age = CalculateAge(newChef.Birthday);
                if (newChef.Birthday > Now)
                {
                    ModelState.AddModelError("Birthday", "You cant go to the future!?");
                    return View("AddChef");
                }
                if (age < 18)
                {
                    ModelState.AddModelError("Birthday", "Must be at least 18 years old!");
                    return View("AddChef");
                }
                newChef.Age = age;
                dbContext.Add(newChef);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("AddChef");
        }

        [HttpGet("dishes/new")]
        public IActionResult NewDish()
        {
            List<Chef> AllChefs = dbContext.Chefs
            .ToList();
            foreach(var x in AllChefs)
            {
                Console.WriteLine(x.FName);
            }
            ViewBag.AllChefs = AllChefs;
            return View("NewDish");
        }

        [HttpPost("new/dish")]
        public IActionResult AddDish(Dish newDish)
        {
            Console.WriteLine(newDish.Name);
            if(ModelState.IsValid)
            {
                Chef DishCreator = dbContext.Chefs
                .FirstOrDefault(dishcreator => dishcreator.ChefId == newDish.ChefId);
                newDish.Creator = DishCreator;
                dbContext.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("Dishes");
            }
            List<Chef> AllChefs = dbContext.Chefs
            .ToList();
            ViewBag.AllChefs = AllChefs;
            return View("NewDish");
        }
    }
}


