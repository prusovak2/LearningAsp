using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [Route("{id:int:min(10):max(42)}")] // int type constraint, min- id must be >=10 to map to this route
        public string GetById(int id)
        {
            return $"hello from int id {id}";
        }
        [Route("{id}")] // default is string
        public string GetByIdString(string id)
        {
            return $"hello from string id {id}";
        }
    }
}
