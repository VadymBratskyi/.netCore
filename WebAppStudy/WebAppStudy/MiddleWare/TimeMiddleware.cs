using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using WebAppStudy.Services;

namespace WebAppStudy.MiddleWare
{
    public class TimeMiddleware
    {
        private readonly RequestDelegate _next;

        public TimeMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, TimeService time)
        {
            context.Response.ContentType = "text/html; charset=utf-8";

            if (context.Request.Path.Value.ToLower() == "/time")
            {               
                await context.Response.WriteAsync($"Текущая дата и время: {time?.Time} <br/>");
            }
            else
            {
                await _next.Invoke(context);
            }
        }
    }
}