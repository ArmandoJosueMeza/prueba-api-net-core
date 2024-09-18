using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeeAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        // Definimos un modelo simple de empleado
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Position { get; set; }
        }

        // Creamos una lista estática de empleados
        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Juan", Position = "Developer" },
                new Employee { Id = 2, Name = "Ana", Position = "Designer" },
                new Employee { Id = 3, Name = "Carlos", Position = "Manager" }
            };

            // Retornamos la lista de empleados como JSON
            return Ok(employees);
        }
    }
}
