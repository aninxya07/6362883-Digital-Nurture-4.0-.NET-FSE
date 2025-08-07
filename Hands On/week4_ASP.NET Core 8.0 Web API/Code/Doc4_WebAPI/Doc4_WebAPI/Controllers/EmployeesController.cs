using Doc4_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Doc4_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 43000 },
            new Employee { Id = 2, Name = "Bob", Department = "Finance", Salary = 32000 },
            new Employee { Id = 3, Name = "Charlie", Department = "IT", Salary = 75000}
        };

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(Employee), 200)]
        [ProducesResponseType(400)]
        public ActionResult<Employee> UpdateEmployee(int id, [FromBody] Employee updatedEmployee)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            var existingEmployee = employees.FirstOrDefault(e => e.Id == id);
            if (existingEmployee == null)
            {
                return BadRequest("Invalid employee id");
            }

            existingEmployee.Name = updatedEmployee.Name;
            existingEmployee.Department = updatedEmployee.Department;
            existingEmployee.Salary = updatedEmployee.Salary;

            return Ok(existingEmployee);
        }
    }
}