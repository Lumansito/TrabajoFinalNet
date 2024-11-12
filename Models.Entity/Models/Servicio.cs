using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Models.Entity.Models;

namespace Models.Entity.Models
{
    public class Servicio
    {
        public int ServicioId { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public bool Activo { get; set; }

        public virtual ICollection<Atencion> Atenciones { get; set; } = [];
        
        public virtual ICollection<PrecioServicio> Precios { get; set; } = [];
       
        public virtual ICollection<Especialidad> Especialidades { get; set; } = [];
    }
}
