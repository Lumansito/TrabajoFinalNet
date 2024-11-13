using System;
using System.Collections.Generic;

namespace Models.Entity.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        public int Dni { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Apellido { get; set; } = string.Empty;

        public string Mail { get; set; } = string.Empty;

        public string Telefono { get; set; } = string.Empty;

        public bool Activo { get; set; }

        public DateTime FechaAlta { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public  virtual ICollection<ClienteMembresia> ClienteMembresia { get; set; } = new List<ClienteMembresia>();

        public virtual ICollection<Mascota> Mascotas { get; set; } = new List<Mascota>();
    }

}

