using System;
using System.Collections.Generic;

namespace Models.Entity.Models
{
    public class Atencion
    {

        public int AtencionId { get; set; }

        public DateTime FechaHora { get; set; }

        public int MascotaId { get; set; }

        public int UsuarioId { get; set; }

        public string Observaciones { get; set; } = string.Empty;

        public decimal MontoApagar { get; set; } = 0;

        public string Motivo { get; set; } = string.Empty;

        public DateTime FechaHoraPago { get; set; } = DateTime.MinValue;

        public bool Activo { get; set; }

        public virtual ICollection<Servicio> Servicios { get; set; } = new List<Servicio>();

        public virtual Usuario Usuario { get; set; } = new Usuario();

        public virtual Mascota Mascota { get; set; } = new Mascota();
    }
}


