﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAppAuthentication.Models;

namespace WebAppAuthentication.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        //[AllowAnonymous]
        //public IActionResult Index()
        //{
        //    if (User.Identity.IsAuthenticated)
        //    {
        //        return Content(User.Identity.Name);
        //    }
        //    return RedirectToAction("Login","Account");
        //}

        //[Authorize(Roles = "admin, user")]
        //public IActionResult Index()
        //{
        //    if (User.Identity.IsAuthenticated)
        //    {
        //        return View();
        //    }
        //    return RedirectToAction("Login", "Account");
        //}

        //[Authorize(Roles = "admin")]
        //public IActionResult About()
        //{
        //    ViewData["Message"] = "Your application description page.";

        //    return View();
        //}

        [Authorize(Policy = "OnlyForLondon")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Policy = "OnlyForMicrosoft")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
