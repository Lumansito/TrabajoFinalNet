using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Models.Entity.Models
{
    public class Mascota
    {
        
        public int MascotaId { get; set; }

        public int ClienteId { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public int RazaId { get; set; }

        public int EspecieId { get; set; }

        public DateTime FechaNac { get; set; }

        public DateTime FechaDefuncion { get; set; }  //se utiliza como atributo activo

        public virtual ICollection<Atencion> Atenciones { get; set; } = new List<Atencion>();

        public virtual Especie Especie { get; set; }

        public virtual Raza Raza { get; set; } = new Raza();

        public virtual Cliente Cliente { get; set; } = new Cliente();
    }

}

