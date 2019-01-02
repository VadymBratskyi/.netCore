using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ObserverPatern.Models.WrongNews.News;
using ObserverPatern.Models.WrongNews.Widgest;

namespace WebAppPaterns.Controllers
{
    public class ObserverController : Controller
    {
        public IActionResult Index()
        {
            var subject = new NewsAggregator();
            
            return View(subject);
        }
    }
}