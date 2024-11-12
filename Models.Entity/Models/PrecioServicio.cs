using System;
using System.Collections.Generic;


namespace Models.Entity.Models
{
    public class PrecioServicio
    {
        public int PrecioServicioId { get; set; }

        public int ServicioId { get; set; }

        public DateTime FechaDesde { get; set; }

        public decimal Precio { get; set; }

        public virtual Servicio Servicio { get; set; } = new Servicio();
    }
}


