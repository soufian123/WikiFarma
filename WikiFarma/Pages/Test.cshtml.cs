using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace WikiFarma.Pages
{
    public class TestModel : PageModel
    {

        public List<Persona> Personas { get; set; }
        public List<Persona>? Resultados { get; set; }

        public TestModel()
        {
            Personas = new List<Persona>
            {
                new Persona { Nombre = "Juan", Edad = 30, Telefono = "1234567890" },
                new Persona { Nombre = "Pedro", Edad = 25, Telefono = "0987654321" },
                new Persona { Nombre = "María", Edad = 40, Telefono = "6789012345" },
                new Persona { Nombre = "Ana", Edad = 35, Telefono = "5432167890" },
                new Persona { Nombre = "Luis", Edad = 20, Telefono = "8901234567" },
                new Persona { Nombre = "Carlos", Edad = 25, Telefono = "0987654321" },
                new Persona { Nombre = "Sofía", Edad = 40, Telefono = "6789012345" },
                new Persona { Nombre = "Lucía", Edad = 35, Telefono = "5432167890" },
                new Persona { Nombre = "Miguel", Edad = 20, Telefono = "8901234567" },
                new Persona { Nombre = "Lorena", Edad = 25, Telefono = "0987654321" },
                new Persona { Nombre = "Javier", Edad = 40, Telefono = "6789012345" },
                new Persona { Nombre = "Carmen", Edad = 35, Telefono = "5432167890" },
                new Persona { Nombre = "Ricardo", Edad = 20, Telefono = "8901234567" },
                new Persona { Nombre = "Fernanda", Edad = 25, Telefono = "0987654321" },
                new Persona { Nombre = "Diego", Edad = 40, Telefono = "6789012345" },
                new Persona { Nombre = "Valeria", Edad = 35, Telefono = "5432167890" },
                new Persona { Nombre = "Santiago", Edad = 20, Telefono = "8901234567" }
                // Agrega más personas aquí
            };
        }

        public void OnGet(string? busqueda)
        {
            if (string.IsNullOrEmpty(busqueda))
            {
                // Si la búsqueda es nula o vacía, devuelve todas las personas
                Resultados = Personas;
            }
            else
            {
                // Si la búsqueda no es nula ni vacía, realiza la búsqueda
                Resultados = Personas.Where(p => p.Nombre.Contains(busqueda)).ToList();
            }
        }
    }
}