using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppToWebAPI
{
    public class CustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Abraka Hello from Custom 1 \n");
            await next(context); // next has to be called here to execute the code below the Use, code below next is executed after following middlewares finishe 
            await context.Response.WriteAsync("Abraka Hello from Custom 2 \n");
        }
    }
}
