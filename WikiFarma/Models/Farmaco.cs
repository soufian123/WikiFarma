namespace WikiFarma.Models
{
    public class Farmaco
    {
        public long Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string EdadMinima { get; set; } = string.Empty;
        public string Dosis { get; set; } = string.Empty;
        public bool TieneReceta { get; set; }
        public string Imagen { get; set; } = string.Empty;
        public string Via { get; set; } = string.Empty;
        public string Advertencia { get; set; } = string.Empty;
        public string Compuesto { get; set; } = string.Empty;
        public string Prospecto { get; set; } = string.Empty;
    }
}
