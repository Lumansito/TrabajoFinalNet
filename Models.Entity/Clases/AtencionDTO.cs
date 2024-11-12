using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entity.Clases
{
    public class AtencionDTO
    {
        public DateTime FechaHora { get; set; }
        public string Motivo { get; set; }
        public int MascotaId { get; set; }
        public int UsuarioId { get; set; }
    }
}
