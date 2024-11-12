using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.Entity.Data;
using Models.Entity.Models;
using System.Diagnostics;
using System.Net;

namespace Servicies.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MascotasController : ControllerBase
    {
        private readonly VeterinariaContext _context;

        public MascotasController(VeterinariaContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "Mascotas")]
        public ActionResult<IEnumerable<Mascota>> GetAll()
        {
            return _context.Mascota.ToList();
        }

        [HttpGet("cliente/{dni}")]
        public ActionResult<IEnumerable<Mascota>> GetByDni(int dni)
        {
            Cliente? cliente = _context.Cliente.Where(c => c.Dni ==dni).FirstOrDefault();
            return _context.Mascota.Where(m => m.Cliente == cliente).ToList();
        }
        
        [HttpGet("{id}")]
        public ActionResult<Mascota> GetById(int id)
        {
            var mascota = _context.Mascota.FirstOrDefault(m => m.MascotaId == id);
            if (mascota == null)
            {
                return NotFound();
            }
            return mascota;
        }
        

        [HttpPut("{DNI}/{NRO}")]
        public ActionResult Update(int DNI, int NRO, Mascota mascota)
        {
            /*
            if (DNI != mascota.DniCliente || NRO != mascota.NroMascota)
            {
                return BadRequest();
            }
            _context.Entry(mascota).State = EntityState.Modified; 
            _context.SaveChanges();
            return NoContent();
            */

            if (DNI != mascota.ClienteId || NRO != mascota.MascotaId)
            {
                return BadRequest();
            }
            var mascotaExistente = _context.Mascota.FirstOrDefault(m => m.ClienteId == DNI && m.MascotaId == NRO);
            if (mascotaExistente == null)
            {
                return NotFound();
            }
            mascotaExistente.ClienteId = mascota.ClienteId;
            mascotaExistente.MascotaId = mascota.MascotaId;
            mascotaExistente.Nombre = mascota.Nombre;
            mascotaExistente.RazaId = mascota.RazaId;
            mascotaExistente.EspecieId = mascota.EspecieId;
            mascotaExistente.FechaNac = mascota.FechaNac;
            mascotaExistente.FechaDefuncion = mascota.FechaDefuncion;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{DNI}/{NRO}")]
        public ActionResult<Mascota> Delete(int DNI, int NRO)
        {
            var mascota = _context.Mascota.FirstOrDefault(m => m.ClienteId == DNI && m.MascotaId == NRO);
            if (mascota == null)
            {
                return NotFound();
            }
            _context.Mascota.Remove(mascota);
            _context.SaveChanges();
            return mascota;
        }
    }
}
