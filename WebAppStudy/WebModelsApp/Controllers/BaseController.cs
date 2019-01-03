using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebModelsApp.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Request.Headers.ContainsKey("User_Agent") &&
                Regex.IsMatch(context.HttpContext.Request.Headers["User-Agent"].FirstOrDefault(), "MSIE 8.0")) {
                context.Result = Content("Internet Explorer 8.0 не поддерживается");                
            }

            base.OnActionExecuting(context);
        }
    }
}