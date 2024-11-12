using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Clases
{
    public class MembresiasCliente
    {
        public string? Descripcion { get; set; }
        public DateOnly? FechaDesde { get; set; }
        public decimal? Precio { get; set; }
        public decimal? PorcentajeDescuento { get; set; }
    }
}