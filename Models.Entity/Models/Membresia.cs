using System;
using System.Collections.Generic;

namespace Models.Entity.Models
{
    public class Membresia
    {
        public int MembresiaId { get; set; }

        public bool Activo { get; set; }

        public string Descripcion { get; set; } = string.Empty;

        public int AntiguedadMinimaCliente { get; set; }

        public decimal PorcentajeDescuento { get; set; }

        public virtual  ICollection<ClienteMembresia> ClienteMembresia { get; set; } = new List<ClienteMembresia>();

        public virtual ICollection<PrecioMembresia> Precios { get; set; } = new List<PrecioMembresia>();
    }

}

