using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Clases
{
    public class LoginRequestUsuario
    {
        public required int Dni { get; set; }
        public required string Password { get; set; }
    }
}
