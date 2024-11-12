﻿using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("{dni}")]
        public ActionResult<Cliente> GetByDni(int dni)
        {
            var cliente = _context.Cliente.Find(dni);
            if (cliente == null)
            {
                return NotFound();
            }
            return cliente;
        }

        [HttpPost]
        public ActionResult<Cliente> PostCliente(Cliente cliente)
        {
            _context.Cliente.Add(cliente);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetByDni), new { dni = cliente.Dni }, cliente);
        }


        [HttpDelete("{dni}")]
        public ActionResult Delete(int dni) {
            var cliente = _context.Cliente.Find(dni);
            if (cliente == null)
            {
                return NotFound();
            }
            _context.Cliente.Remove(cliente);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpPut("{dni}")]
        public IActionResult EditarCliente(int dni, Cliente cliente)
        {
            if (dni != cliente.Dni)
            {
                return BadRequest();
            }

            var clienteExistente = _context.Cliente.Find(dni);
            if (clienteExistente == null)
            {
                return NotFound();
            }

            clienteExistente.Nombre = cliente.Nombre;
            clienteExistente.Apellido = cliente.Apellido;
            clienteExistente.Telefono = cliente.Telefono;
            clienteExistente.Mail = cliente.Mail;
            clienteExistente.FechaNacimiento = cliente.FechaNacimiento;
            _context.SaveChanges();

            return NoContent();
        }

    }
}
