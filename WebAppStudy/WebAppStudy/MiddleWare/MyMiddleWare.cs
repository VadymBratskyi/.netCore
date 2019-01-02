using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using WebAppStudy.Services;

namespace WebAppStudy.MiddleWare
{
    public class MyMiddleWare
    {
        private readonly RequestDelegate _next;
        private string _patern;

        public MyMiddleWare(RequestDelegate next, string patern)
        {
            _next = next;
            _patern = patern;
        }

        public async Task InvokeAsync(HttpContext context, IMyServices ser)
        {
            var token = context.Request.Query["token"];

            var ser2 = context.RequestServices.GetService<IMyServices>();

            await context.Response.WriteAsync("Hello Vados"+token+ "<br/>"+"patern: "+_patern+"<br/>"+ ser.Send());

            await _next.Invoke(context);
        }

    }
}
