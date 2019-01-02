using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StrategyPatern.Models.Ducks;
using StrategyPatern.Models.Ducks.Fly;
using StrategyPatern.Models.Ducks.Quack;

namespace WebAppPaterns.Controllers
{
    public class StrategyController : Controller
    {
        public IActionResult Index()
        {
            List<DuckBase> ducks = new List<DuckBase>();

            ducks.Add(new ExoticDuck());
            ducks.Add(new SimpleDuck());
            ducks.Add(new WoodenDuck());
            ducks.Add(new RubberDuck());

            var upgDuck = new UpgradableDuck();
            upgDuck.SetQuackable(new ExoticQuack());
            upgDuck.SetFlyable(new ExoticFly());

            ducks.Add(upgDuck);

            return View(ducks);
        }
       
    }
}