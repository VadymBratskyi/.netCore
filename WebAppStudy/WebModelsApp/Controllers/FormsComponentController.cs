using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebModelsApp.Controllers
{
    public class FormsComponentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string login, string password, int age, string comment, bool isMarried)
        {
            string authData = $"Login: {login}   Password: {password}   Age: {age}  Comment: {comment} IsMarried: {isMarried}";
            return Content(authData);
        }

        [HttpPost("[action]")]
        public IActionResult Color(string color)
        {
            string authData = $"color: {color}";
            return Content(authData);
        }
        
        [HttpPost("[action]")]
        public IActionResult Model(string phone)
        {
            string authData = $"phone: {phone}";
            return Content(authData);
        }

        [HttpPost("[action]")]
        public IActionResult Models(string[] phones)
        {
            string result = "";
            foreach (string p in phones)
            {
                result += p;
                result += ";";
            }
            result = "Вы выбрали: " + result;
            return Content(result);
        }
    }
}