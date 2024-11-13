using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entity.Clases
{
    public class AtencionPatchDTO
    {
        public DateTime? FechaHoraPago { get; set; }
        public string? Observaciones { get; set; }
        public int? ServicioId { get; set; }
        public decimal? MontoApagar { get; set; }
    }
}
