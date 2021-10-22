using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppToWebAPI.Controllers
{
    [ApiController]
    [Route("test/[action]")]
    public class TestController : ControllerBase
    {
        public string Get()
        {
            // this string is a 'resource'
            return "Abraka Hello from get";
        }
        // without [action] above this causes the ambiguity - we are accessing two methods via the same url
        // action allows to specify the method name in url
        public string Get1()
        {
            // this string is a 'resource'
            return "Abraka Hello from get1";
        }
    }
}
