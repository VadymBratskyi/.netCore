using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebModelsApp.Models;

namespace WebModelsApp.Controllers
{
    public class MobileController : Controller
    {
        MobileContext db;

        public MobileController(MobileContext context) {
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.Phones.ToList());
        }

        [HttpGet]
        public IActionResult Buy(int id) {

            ViewBag.PhoneId = id;
            return View();
        }

        [HttpPost]
        public string Buy(Order order)
        {
            db.Orders.Add(order);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Спасибо, " + order.User + ", за покупку!";
        }
    }
}