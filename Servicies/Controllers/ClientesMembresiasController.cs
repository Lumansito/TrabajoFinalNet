using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpGet]
        public ActionResult<IEnumerable<ClienteMembresia>> GetAll()
        {
            return _context.ClienteMembresia.Include(c => c.Cliente).Include(c => c.Membresia).ToList();
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
            var cm = new ClienteMembresia();
            
            var cliente = _context.Cliente.Find(clienteMembresia.ClienteId);
            var membresia = _context.Membresia.Find(clienteMembresia.MembresiaId);

            if (cliente == null || membresia == null)
            {
                return NotFound();
            }

            cm.Membresia = membresia;


            cm.Cliente = cliente;
            cm.FechaDesde = clienteMembresia.FechaDesde;


            _context.ClienteMembresia.Add(cm);
            _context.SaveChanges();
            
            return NoContent();
        }
    }
}
