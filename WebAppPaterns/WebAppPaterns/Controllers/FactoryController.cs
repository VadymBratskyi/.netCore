using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using car1 = FactoryPatern.Models.Car1.Facilities;
using car2 = FactoryPatern.Models.Car2.Facilities;
using FactoryPatern.Models.Car1.Factory;
using Microsoft.AspNetCore.Mvc;

namespace WebAppPaterns.Controllers
{
    public class FactoryController : Controller
    {
        public IActionResult Index()
        {
            //SimpeFactory factory = new SimpeFactory();

            //VolkswagenFacility facility = new VolkswagenFacility(factory);
            car1.VolkswagenFacility facility = new car1.UkrainVolkswagenFacility();

            return View(facility.GetCar("Passat"));
        }

        public IActionResult Index2()
        {
            //SimpeFactory factory = new SimpeFactory();

            //VolkswagenFacility facility = new VolkswagenFacility(factory);
            car2.VolkswagenFacility facility = new car2.DeutschVolkswagenFacility();

            return View(facility.GetCar("Passat"));
        }
    }
}