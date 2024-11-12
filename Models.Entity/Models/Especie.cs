using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Models.Entity.Models
{
    public class Especie
    {
        public int EspecieId { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public bool Activo { get; set; }

        public virtual ICollection<Mascota> Mascotas { get; set; } = new List<Mascota>();
    }
}