using Ders3_MvcTemelleri.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ders3_MvcTemelleri.Controllers
{
    public class CoffeeController : Controller
    {
        public IActionResult Index()
        {
            var coffee = new List<Coffee>
            { 
                new Coffee {Id=1,Name="Expresso",Description="strong coffee",Price=2.50m},
                new Coffee {Id=2,Name="Latte",Description="Coffee with Milk",Price=1.99m},
                new Coffee {Id=3,Name="Filter Coffee",Description="Only Coffee",Price=1.10m}
            };


            return View(coffee);
        }
    }
}
