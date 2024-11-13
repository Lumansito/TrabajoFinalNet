using Models.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entity.Clases
{
    public class InfoAtencionesRealizadas
    {
        public int AtencionId { get; set; }

        public DateTime FechaHora { get; set; }

        public int DniCliente { get; set; }

        public int MascotaId { get; set; }

        public string NombreMascota { get; set; } = string.Empty;

        public int? UsuarioId { get; set; }

        public string NombreProfesional { get; set; } = string.Empty;

        public string? Observaciones { get; set; } = string.Empty;

        public decimal? MontoApagar { get; set; }

        public string? Motivo { get; set; } = string.Empty;

        public DateTime? FechaHoraPago { get; set; }

        public bool? Activo { get; set; }

        public virtual ICollection<Servicio> Servicios { get; set; } = new List<Servicio>();


    }
}
