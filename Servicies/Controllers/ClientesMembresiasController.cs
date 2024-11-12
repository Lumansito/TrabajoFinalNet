using Microsoft.AspNetCore.Mvc;
using Models.Entity.Data;
using Models.Entity.Models;
using System.Diagnostics;

namespace Servicies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesMembresiasController : ControllerBase
    {
        private readonly VeterinariaContext _context;

        public ClientesMembresiasController(VeterinariaContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "ClientesMembresias")]
        public ActionResult<IEnumerable<ClienteMembresia>> GetAll()
        {
            return _context.ClienteMembresia.ToList();
        }

        [HttpGet("{COD}/{DNI}")]
        public ActionResult<ClienteMembresia> GetByCodAndDni(int COD, int DNI)
        {
            var clienteMembresia = _context.ClienteMembresia.Find(COD, DNI);
            if (clienteMembresia == null)
            {
                return NotFound();
            }
            return clienteMembresia;
        }

        [HttpPost]
        public ActionResult<ClienteMembresia> Create(ClienteMembresia clienteMembresia)
        {
            _context.ClienteMembresia.Add(clienteMembresia);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetByCodAndDni), new { COD = clienteMembresia.MembresiaId, DNI = clienteMembresia.ClienteId }, clienteMembresia);
        }
    }
}
