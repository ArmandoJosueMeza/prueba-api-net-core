using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Prueba_API_ArmandoJosueMeza.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        // Definimos un modelo simple de empleado
        public class Employee
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Puesto { get; set; }
        }

        // Creamos una lista estática de empleados
        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Nombre = "Juan",     Apellido = "Sanchez",   Puesto = "Desarollador" },
                new Employee { Id = 2, Nombre = "Ana",      Apellido = "Tabora",    Puesto = "Publicidad" },
                new Employee { Id = 3, Nombre = "Carlos",   Apellido = "Bonilla",   Puesto = "Gerente" }
            };

            // Retornamos la lista de empleados como JSON
            return Ok(employees);
        }
    }
}



