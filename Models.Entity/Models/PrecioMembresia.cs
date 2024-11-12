using System;
using System.Collections.Generic;

namespace Models.Entity.Models
{
    public class PrecioMembresia
    {
        public int PrecioMembresiaId { get; set; }

        public int MembresiaId { get; set; }

        public DateTime FechaVigencia { get; set; }

        public decimal Precio { get; set; }

        public virtual Membresia Membresia { get; set; } = new Membresia();
    }

}

