using Microsoft.AspNetCore.Mvc;
using EmployeeManagementAPI.Models;

namespace EmployeeManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(employees);
        }

        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            employees.Add(employee);
            return Ok(employee);
        }
    }
}