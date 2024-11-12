using System;
using System.Collections.Generic;

namespace Models.Entity.Models
{
    public class ClienteMembresia
    {
        public int ClienteMembresiaId { get; set; } 

        public int MembresiaId { get; set; }//atributo fk

        public int ClienteId { get; set; }//atributo fk

        public DateTime FechaDesde { get; set; }

        public  virtual Membresia Membresia { get; set; } = new Membresia();

        public virtual Cliente Cliente { get; set; } = new Cliente();
    }

}

