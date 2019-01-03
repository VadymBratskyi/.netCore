using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var vmodphone = new ViewModelPhone
            {
                Phones =  db.Phones.ToList(),
                Phones2 =  db.Phones2.Include(o=>o.Company).ToList()
            };

            return View(vmodphone);
        }

        [HttpGet]
        public IActionResult Buy(int id)
        {

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

        public JsonResult GetJsonMobile() {

            var phone = db.Phones.FirstOrDefault();
            if (phone==null) {
                return Json("Not found");
            }
            return Json(phone);
        }

        public IActionResult GetContent()
        {           
            return Content("Hello world");
        }

        public IActionResult RedirectResult() {

            return RedirectToAction("Buy", new { id = 1});
            //return RedirectToAction("Index", "Home");
            //return RedirectToAction("GetJsonMobile");
            //return Redirect("GetJsonMobile");
        }
    }

    public class ViewModelPhone
    {
        public IEnumerable<Phone> Phones { get; set; }
        public IEnumerable<Phone2> Phones2 { get; set; }
    }
}