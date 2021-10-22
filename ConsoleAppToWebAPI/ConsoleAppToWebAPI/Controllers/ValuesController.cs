using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppToWebAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    [Route("[controller]/[action]")] // sets this url to all action methods
    public class ValuesController : ControllerBase
    {
        //[Route("api/get-all")]
        //[Route("get-all")]
        //[Route("[controller/[action]")] // things in [] get replaced by name of controller and name of action method - Values and GetAll
        [Route("~/get-all")] // to override the base level route
        public string GetAll()
        {
            return "abraka, hello from GetAll \n";
        }

        //[Route("api/get-all-authors")]
        public string GetAllAuthors()
        {
            return "abraka, hello from GetAllAutohors \n";
        }

        //[Route("books/{id}")] // thing in the {} is dynamic - variable from the url
        [Route("{id}")] // gets appended after Values/GetById due to  [Route("[controller/[action]")] above
        public string GetById(int id)
        {
            return $"abraka, hello from id {id}\n";
        }

        //[Route("books/{id}/author/{authorId}")] // thing in the {} is dynamic - variable from the url
        public string GetAuthorAddressById(int id, int authorId)
        {
            return $"abraka, hello from id {id} and author id {authorId}\n";
        }

        // query strings
        //[Route("search")] 
        public string SearchBooks(int id, int authorId, string name, int rating, int price)
        {
            return $"abraka, hello from search\n";
        }
    }
}
