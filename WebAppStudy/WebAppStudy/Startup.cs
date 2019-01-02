using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WebAppStudy.logger;
using WebAppStudy.MiddleWare;
using WebAppStudy.Services;

namespace WebAppStudy
{
    public class Startup
    {
        public IConfiguration AppConfiguration;

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings2.json")
                .AddXmlFile("appset.xml")
                .AddInMemoryCollection(new Dictionary<string, string>()
                {
                    { "color", "blue"},
                    { "text", "Hello asp.net core" }
                });


            AppConfiguration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            //services.AddTransient<IMyServices, MyService>();
            services.AddMyServices();

            services.AddTimeService();
            services.AddRandomService();
            services.AddCounterService();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory logger, IMyServices my)
        {
            env.EnvironmentName = EnvironmentName.Production;

            logger.AddFile(Path.Combine(env.WebRootPath, "logs/logger.txt"));
            var log = logger.CreateLogger("FileLogger");

            app.Map("/index", Index);
            app.Map("/about", About);
            app.Map("/home", home =>
            {
                home.Map("/index", Index);
                home.Map("/about", About);
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/error");
            }

            app.Map("/error", error => error.Run(async context =>
            {
                await context.Response.WriteAsync("Error in your app");
            }));

            app.UseStaticFiles();

            app.UseTimeMiddleWare();

            app.UseCounterMiddleWare();
            
            //app.UseMiddleware<MyMiddleWare>();
            app.UseMyMiddleWare("369");
            
            app.UseMvc(route =>
            {
                route.MapRoute(
                    name: "default", 
                    template: "{controller}/{action=Index}/{id?}");
            });


            app.Use(async (context, next) =>
            {
                var color = AppConfiguration["color"];
                var text = AppConfiguration["text"];
                var color2 = AppConfiguration["color2"];
                var text2 = AppConfiguration["text2"];
                var color3 = AppConfiguration["colo3"];
                var text3 = AppConfiguration["namespace:class:method"];
                var color4 = AppConfiguration["color4"];
                var text4 = AppConfiguration["text4"];

                await context.Response.WriteAsync($"Mammory: color= {color}; text={text}<br/>");
                await context.Response.WriteAsync($"Mammory: color2= {color2}; text2={text2}<br/>");
                await context.Response.WriteAsync($"Mammory: color3= {color3}; text3={text3}<br/>");
                await context.Response.WriteAsync($"Mammory: color4= {color4}; text4={text4}");
            });

            app.Run(async (context) =>
            {
                log.LogInformation("Process request {0}",context.Request.Path);
                
                await context.Response.WriteAsync("Hello World!<br/>"+my.Send());
            });
        }

        private static void Index(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Index");
            });
        }
        private static void About(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                var ser = app.ApplicationServices.GetService<IMyServices>();
                await context.Response.WriteAsync("About \r\n"+ser.Send());
            });
        }
    }
}
