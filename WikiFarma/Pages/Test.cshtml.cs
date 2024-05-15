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
                new Persona { Nombre = "Juan", Edad = 30, Telefono = "1234567890", Imagen = "https://th.bing.com/th/id/R.8300ecc8bdde4065016239c5c509a0d8?rik=HhWACnZDwzfIAw&pid=ImgRaw&r=0" },
                new Persona { Nombre = "Pedro", Edad = 25, Telefono = "0987654321", Imagen = "https://tajgenerics.com/wp-content/uploads/Paracetamol-Tablets-500-mg-Taj-Pharma.jpg" },
                new Persona { Nombre = "María", Edad = 40, Telefono = "6789012345", Imagen = "https://th.bing.com/th/id/OIP.CjEDMQk7TEODMKh4MZFfGgD6D6?rs=1&pid=ImgDetMain" },
                new Persona { Nombre = "Ana", Edad = 35, Telefono = "5432167890", Imagen = "https://www.pharmacyonline.co.uk/uploads/images/products/verylarge/pharmacy-online-paracetamol-soluble-paracetamol-500mg-100-effervescent-soluble-tablets-1603455187paracetamol-soluble-500mg-effervescent.jpg" },
                new Persona { Nombre = "Luis", Edad = 20, Telefono = "8901234567", Imagen = "https://brennanspharmacy.com/wp-content/uploads/2020/08/b0b158e8-b6a6-4dd9-b32a-d0f828e88bc1__96375.1473853752.jpg" },
                new Persona { Nombre = "Carlos", Edad = 25, Telefono = "0987654321", Imagen = "https://farmaciajimenez.com/storage/products/paracetamol-level-efg-solucion-oral-60-ml/paracetamol-level-infantil-60-ml-960.jpg" },
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
                Resultados = Personas.Where(p => p.Nombre.ToLower().Contains(busqueda.ToLower())).ToList();
            }
        }
        
    }
}