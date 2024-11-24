using Microsoft.AspNetCore.Mvc;
using Models.Entity.Data;
using Models.Entity.Models;

namespace Servicies.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly VeterinariaContext _context;

        public ClientesController(VeterinariaContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "Clientes")]
        public ActionResult<IEnumerable<Cliente>> GetAll()
        {
            return _context.Cliente.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Cliente> GetById(int id)
        {
            var cliente = _context.Cliente.Find(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return cliente;
        }

        [HttpGet("dni/{dni}")]
        public ActionResult<Cliente> GetByDni(int dni)
        {
            var cliente = _context.Cliente.Where(c => c.Dni == dni).FirstOrDefault();
            if (cliente == null)
            {
                return NotFound();
            }
            return cliente;
        }

        [HttpPost]
        public ActionResult<Cliente> PostCliente(Cliente cliente)
        {
            var c = new Cliente();
            c.Nombre = cliente.Nombre;
            c.Telefono = cliente.Telefono;
            c.Mail = cliente.Mail;
            c.FechaNacimiento = cliente.FechaNacimiento;
            c.Dni = cliente.Dni;
            _context.Cliente.Add(c);


            _context.SaveChanges();
            return NoContent();
        }




        [HttpDelete("{id}")]
        public ActionResult Delete(int id) {
            var cliente = _context.Cliente.Where(c => c.ClienteId ==id).FirstOrDefault();
            if (cliente == null)
            {
                return NotFound();
            }
            cliente.Activo = false;
            
            _context.SaveChanges();
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult EditarCliente(int id, Cliente cliente)
        {
            if (id != cliente.ClienteId)
            {
                return BadRequest();
            }

            var clienteExistente = _context.Cliente.Where(c => c.ClienteId == id).FirstOrDefault();
            if (clienteExistente == null)
            {
                return NotFound();
            }

            clienteExistente.Nombre = cliente.Nombre;
            clienteExistente.Apellido = cliente.Apellido;
            clienteExistente.Telefono = cliente.Telefono;
            clienteExistente.Mail = cliente.Mail;
            clienteExistente.FechaNacimiento = cliente.FechaNacimiento;
            clienteExistente.Dni = cliente.Dni;
            _context.SaveChanges();

            return NoContent();
        }

    }
}
