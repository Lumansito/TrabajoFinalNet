using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entity.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        public int Dni { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Apellido { get; set; } = string.Empty;

        public string Mail { get; set; } = string.Empty;

        public string Telefono { get; set; } = string.Empty;

        public DateTime FechaAlta { get; set; } = DateTime.UtcNow;

        public DateTime FechaNacimiento { get; set; }

        public string Contraseña { get; set; } = string.Empty;

        public bool IsAdmin { get; set; }

        public string Rol { get; set; } = string.Empty;

        public bool Activo { get; set; } = true;

        public virtual ICollection<Atencion> Atenciones { get; set; } = new List<Atencion>();

        public virtual ICollection<Especialidad> Especialidades { get; set; } = new List<Especialidad>();

        public virtual ICollection<Jornada> Jornadas { get; set; } = new List<Jornada>();
    }
    
}
