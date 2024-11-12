using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Models.Entity.Models
{
    public class Jornada
    {
        public int JornadaId { get; set; }

        public string NombreDia { get; set; } = string.Empty;

        public TimeSpan HoraInicio{ get; set; }

        public TimeSpan HoraFin { get; set; }

        public bool Activo { get; set; }

        public override string ToString()
        {
            return $"{NombreDia} ({HoraInicio:hh\\:mm} - {HoraFin:hh\\:mm})";
        }

        public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
    }

}

