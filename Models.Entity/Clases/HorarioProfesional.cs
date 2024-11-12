using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entity.Clases
{
    public class HorarioProfesional
    {
        public required string NombreProf { get; set; }
        public required string ApellidoProf { get; set; }
        public int DniProf { get; set; }
        public required string Intervalo { get; set; }
        public DateTime DiaHoraInicio { get; set; }
    }
}
