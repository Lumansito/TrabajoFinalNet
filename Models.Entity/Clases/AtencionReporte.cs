using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entity.Clases
{
    public class AtencionReporte
    {
        
        public DateTime FechaHora { get; set; }
        public string Motivo { get; set; } = string.Empty;
        public decimal? MontoAPagar { get; set; }
        public string Dni { get; set; } = string.Empty;
        public decimal Descuento { get; set; }
        public decimal? MontoFinal { get; set; }
    }
}
