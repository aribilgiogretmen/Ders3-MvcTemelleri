using Ders3_MvcTemelleri.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ders3_MvcTemelleri.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {


            var Users = new List<User>
            {

                new User {Id=1,Name="Ali",Email="ali@ali.com"},
                new User {Id=2,Name="Veli",Email="veli@veli.com"}

            };


            //var user = new User
            //{
            //    Id = 1,
            //    Name = "Hasan",
            //    Email = "hasan@mail.com"
            //};

            //return View(user);

            return View(Users);
        }


        //public IActionResult User2()
        //{

        //    var user = new User
        //    {
        //        Id = 2,
        //        Name = "Mehmet",
        //        Email = "Mehmet@mail.com"
        //    };

        //    return View(user);
        //}
    }
}
