using Ders3_MvcTemelleri.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Ders3_MvcTemelleri.Controllers
{
    public class LottoController : Controller
    {
        public IActionResult Index()
        {
            var model = GenerateLottoNumber();

            return View(model);
        }

        [HttpPost]
        public IActionResult Generate()
        {
            var model = GenerateLottoNumber();

            //return View("Index",model);
            return PartialView("_LottoNumbers", model);

        }

        private LottoNumber GenerateLottoNumber()
        {
            var random = new Random();
            var numbers = new List<int>();

            for (int i = 0; i < 6; i++)
            {
                numbers.Add(random.Next(1, 50));

            }

            return new LottoNumber{Numbers = numbers};
        }
    }
}
