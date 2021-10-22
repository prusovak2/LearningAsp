using ConsoleAppToWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [Route("")]
        public List<EmployeeModel> GetEmployees()
        {
            return new List<EmployeeModel>
            {
                new EmployeeModel() { Id = 42, Name = "Jenovefa" },
                new EmployeeModel() {Id=73, Name = "Harry"}

            };
        }
        [Route("{id}")]
        public IActionResult GetEmployees(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }
            return Ok( new List<EmployeeModel>
            {
                new EmployeeModel() { Id = 42, Name = "Jenovefa" },
                new EmployeeModel() {Id=73, Name = "Harry"}

            });
        }

        [Route("{id}/basic")]
        public ActionResult<EmployeeModel> GetEmployeesBasicDetails(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            return new EmployeeModel() { Id = 42, Name = "Jenovefa" };  // I can return the type directly without calling ok
        }
    }
}
