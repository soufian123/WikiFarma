using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace WikiFarma.Pages
{
    public class DetailsModel : PageModel
    {
        public Persona Persona { get; set; }

        public void OnGet(string name)
        {
            // Aquí debes buscar la persona por su nombre en tu lista de personas.
            // Como ejemplo, estoy usando una lista estática de personas.
            var personas = new List<Persona>
            {
                new Persona { Nombre = "Juan", Edad = 30, Telefono = "1234567890" },
                new Persona { Nombre = "Pedro", Edad = 25, Telefono = "0987654321" },
                new Persona { Nombre = "María", Edad = 40, Telefono = "6789012345" },
                new Persona { Nombre = "Ana", Edad = 35, Telefono = "5432167890" },
                new Persona { Nombre = "Luis", Edad = 20, Telefono = "8901234567" }
            };

            Persona = personas.FirstOrDefault(p => p.Nombre == name);
        }
    }
}