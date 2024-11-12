using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Models.Entity.Models
{
    public class Especialidad
    {
        public int EspecialidadId { get; set; }

        public override string ToString()
        {
            return Nombre;
        }

        public string Nombre { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public bool Activo { get; set; }

        public virtual ICollection<Servicio> Servicios { get; set; } = new List<Servicio>();

        public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
    }

}

