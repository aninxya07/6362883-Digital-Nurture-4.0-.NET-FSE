using Doc3_WebAPI.Filters;
using Doc3_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace Doc3_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [CustomAuthFilter]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee>? employees;

        public EmployeeController()
        {
            // Initialize only once
            if (employees == null)
            {
                employees = GetStandardEmployeeList();
            }
        }

        // 🔐 Private method to initialize employee list
        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee 
                {
                    Id = 1,
                    Name = "Anindya Dolui",
                    Salary = 35000,
                    Permanent = true,
                    Department = new Department { Id = 1, Name = "Tester" },
                    Skills = new List<Skill> 
                    {
                        new Skill { Id = 1, Name = "C#" },
                        new Skill { Id = 2, Name = "SQL" }
                    },
                    DateOfBirth = new DateTime(2004, 8, 1)
                },
                new Employee
                {
                    Id = 2,
                    Name = "Jane",
                    Salary = 60000,
                    Permanent = false,
                    Department = new Department { Id = 102, Name = "IT" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 3, Name = "C#" },
                        new Skill { Id = 4, Name = "SQL" }
                    },
                    DateOfBirth = new DateTime(1992, 5, 10)
                }
            };
        }

        // ✅ GET: api/Employee
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Employee>> Get()
        {
            //throw new Exception("Something went wrong while processing the GET request.");
            return Ok(employees);
        }

        // ✅ GET: api/Employee/standrad
        [HttpGet("standrad")]
        public ActionResult<Employee> GetStandrad()
        {
            return Ok(GetStandardEmployeeList().FirstOrDefault());
        }

        // ✅ POST: api/Employee
        [HttpPost]
        public ActionResult Post([FromBody] Employee newEmp)
        {
            newEmp.Id = employees.Max(e => e.Id) + 1;
            employees.Add(newEmp);
            return Ok(newEmp);
        }

        // ✅ PUT: api/Employee/1
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Employee updatedEmp)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp == null) return NotFound();

            emp.Name = updatedEmp.Name;
            emp.Salary = updatedEmp.Salary;
            emp.Permanent = updatedEmp.Permanent;
            emp.Department = updatedEmp.Department;
            emp.Skills = updatedEmp.Skills;
            emp.DateOfBirth = updatedEmp.DateOfBirth;

            return Ok(emp);
        }
    }
}