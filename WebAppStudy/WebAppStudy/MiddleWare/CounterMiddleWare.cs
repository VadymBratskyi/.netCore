using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using WebAppStudy.Services;

namespace WebAppStudy.MiddleWare
{
    public class CounterMiddleWare
    {
        private readonly RequestDelegate _next;
        private int i = 0;

        public CounterMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, ICounter counter, CounterService counterService)
        {
            i++;
            context.Response.ContentType = "text/html;charset=utf-8";
            await context.Response.WriteAsync( $"Запрос {i}; Counter: {counter.Value}; Service: {counterService.Counter.Value} <br/>");
            await _next.Invoke(context);
        }

    }
}
