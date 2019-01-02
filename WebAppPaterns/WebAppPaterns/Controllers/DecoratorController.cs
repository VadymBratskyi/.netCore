using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bevareg = DecoratorPatern.Models.Beverage;
using bevareg2 = DecoratorPatern.Models.Beverage2;
using Microsoft.AspNetCore.Mvc;

namespace WebAppPaterns.Controllers
{
    public class DecoratorController : Controller
    {
        public IActionResult Index()
        {
            var capuccino = new bevareg.Capuccino();
            var hotChockolate = new bevareg.HotChocolate();
            var espresso = new bevareg.Esspresso();

            var listBeverage = new List<bevareg.BeverageBase>()
            {
                capuccino,espresso,hotChockolate
            };

            return View(listBeverage);
        }

        public IActionResult Index2()
        {

            bevareg2.BeverageBase espresso = new bevareg2.Esspresso();
            bevareg2.BeverageBase blackTea = new bevareg2.BlackTea();
            bevareg2.BeverageBase greenTea = new bevareg2.GreenTea();

            var listBeverage2 = new List<bevareg2.BeverageBase>()
            {
                espresso,blackTea,greenTea
            };

            return View(listBeverage2);
        }
    }
}