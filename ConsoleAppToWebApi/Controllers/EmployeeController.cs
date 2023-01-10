using ConsoleAppToWebApi.Models;
using ConsoleAppToWebApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleAppToWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //public string Employee()
        //{
        //    return "All Employee";
        //}
        [Route("")]
        public List<EmployeeModel> GetEmployees()
        {
            return new List<EmployeeModel>()
            {
                new EmployeeModel() { Id = 1, Name = "Employee 1"},
                new EmployeeModel() { Id = 2, Name = "Employee2"}
            };
        }
        [Route("{id}")]
        public IActionResult GetEmployees(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }
            return Ok(new List<EmployeeModel>()
            {
                new EmployeeModel() { Id = 1, Name = "Employee 1"},
                new EmployeeModel() { Id = 2, Name = "Employee2"}
            } 
            );
        }
        [Route("{id}/basic")]
        public ActionResult <EmployeeModel> GetEmployeesBasicDetails(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            return new EmployeeModel() { Id = 1, Name = "Employee 1" };
        }
        [HttpGet("")]
        public IActionResult GetName([FromServices] IProductReposiotry _productRepository)
        {
            var product = _productRepository.GetName();
            return Ok(product);
        }
    }
}
