using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Clases
{
    public class ListadoMascotas
    {
        public string? NombreMascota { get; set; }
        public int? Edad { get; set; }
        public string? NombreRaza { get; set; }
        public string? NombreEspecie { get; set; }
        public DateOnly? FechaDefuncion { get; set; }
    }
}
