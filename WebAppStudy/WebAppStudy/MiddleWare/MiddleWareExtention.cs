using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace WebAppStudy.MiddleWare
{
    public static class MiddleWareExtention
    {
        public static IApplicationBuilder UseMyMiddleWare(this IApplicationBuilder builder, string patern)
        {
            return builder.UseMiddleware<MyMiddleWare>(patern);
        }

        public static IApplicationBuilder UseCounterMiddleWare(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CounterMiddleWare>();
        }

        public static IApplicationBuilder UseTimeMiddleWare(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TimeMiddleware>();
        }
        
    }
}
