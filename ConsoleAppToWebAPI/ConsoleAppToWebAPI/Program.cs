using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using System;

namespace ConsoleAppToWebAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webHost =>
                {
                    webHost.UseStartup<Startup>();
                });

        }
    }
}
