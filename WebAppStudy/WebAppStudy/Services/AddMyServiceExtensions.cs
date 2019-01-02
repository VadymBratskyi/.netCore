using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace WebAppStudy.Services
{
    public static class AddMyServiceExtensions
    {
        public static void AddMyServices(this IServiceCollection services)
        {
            services.AddTransient<IMyServices, MyService>();
        }

        public static void AddRandomService(this IServiceCollection service)
        {
            //service.AddTransient<ICounter, RandomCounter>();
            //service.AddScoped<ICounter, RandomCounter>();
            service.AddSingleton<ICounter, RandomCounter>();
        }

        public static void AddCounterService(this IServiceCollection service)
        {
            //service.AddTransient<CounterService>();
            //service.AddScoped<CounterService>();
            service.AddSingleton<CounterService>();
        }

        public static void AddTimeService(this IServiceCollection service)
        {
            service.AddTransient<TimeService>();
        }
    }
}
