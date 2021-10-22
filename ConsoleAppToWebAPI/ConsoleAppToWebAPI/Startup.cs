using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppToWebAPI
{
    /// <summary>
    /// Confugure services, configure
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Configure all the services I wanna use in the application
        /// </summary>
        public void ConfigureServices(IServiceCollection  services)
        {
            services.AddControllers();
            services.AddTransient<CustomMiddleware>(); // inject custom midleware service to the application
        }

        /// <summary>
        /// Configure HTTP request pipeline
        /// </summary>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
           
            // order of the middlewares is crucial 

            /*app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Abraka Hello from Use 1 \n");
                await next(); // next has to be called here to execute the code below the Use, code below next is executed after following middlewares finishe 
                await context.Response.WriteAsync("Abraka Hello from Use 2 \n");

            });

            app.Map("/abraka", CustomCode);

            app.UseMiddleware<CustomMiddleware>(); // use custom middleware -  insert it in the HTTP pipeline
            // completes middleware execution - no code in Configure after a Run won't be executed
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Abraka Hello from run\n");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); //middleware
            }*/
            app.UseRouting(); //middleware
            //specify url mapping
            //middleware
            app.UseEndpoints(endpoints => 
            {
                endpoints.MapControllers(); // bridge between http request and controllers 

            }); 


            // shows text on the webpage
            /*app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Abraka Hello from my web app");
                });

            });*/
        }

        private void CustomCode(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {await context.Response.WriteAsync("Abraka Hello from mapped \n"); 
            });
        }
    }
}
