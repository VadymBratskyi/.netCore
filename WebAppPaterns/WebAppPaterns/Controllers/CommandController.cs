using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandPatern.Models;
using CommandPatern.Models.Commands;
using CommandPatern.Models.ControlledSystem;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;

namespace WebAppPaterns.Controllers
{
    public class CommandController : Controller
    {
        public IActionResult Index()
        {
            RemoteControl remote = new RemoteControl();
            
            remote.SetComand(1, new LightCommand(new Light()));
            remote.SetComand(2, new MusicCommand(new Music()));
            remote.SetComand(3, new TvCommand(new Tv()));
            remote.SetComand(4, new TeapotCommand(new Teapot()));

            ViewBag.Menu = new HtmlString(remote.ToString());

            return View(remote);
        }

    }
}