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
        public ActionResult<List<Mascota>> GetAll()
        {
            return _context.Mascota.Include(m => m.Raza).Include(m => m.Especie).ToList();
        }

        [HttpGet("cliente/{dni}")]
        public ActionResult<List<Mascota>> GetByDni(int dni)
        {
            Cliente? cliente = _context.Cliente.Where(c => c.Dni ==dni).FirstOrDefault();
            return _context.Mascota.Where(m => m.Cliente == cliente).Include(m => m.Raza).Include(m => m.Especie).ToList();
        }
        
        [HttpGet("{id}")]
        public ActionResult<Mascota> GetById(int id)
        {
            var mascota = _context.Mascota.Include(m => m.Raza).Include(m => m.Especie).FirstOrDefault(m => m.MascotaId == id);
            if (mascota == null)
            {
                return NotFound();
            }
            return mascota;
        }

        [HttpPost]
        public ActionResult Create(Mascota mascota)
        {
           

            _context.Mascota.Add(mascota);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpPut("{mascotaId}")]
        public ActionResult Update(int mascotaId, Mascota mascota)
        {
            if (mascotaId != mascota.MascotaId)
            {
                return BadRequest();
            }
            var mascotaExistente = _context.Mascota.Find(mascotaId);
            if (mascotaExistente == null)
            {
                return NotFound();
            }
            mascotaExistente.MascotaId = mascota.MascotaId;
            mascotaExistente.ClienteId = mascota.ClienteId;
            mascotaExistente.Nombre = mascota.Nombre;
            mascotaExistente.RazaId = mascota.RazaId;
            mascotaExistente.EspecieId = mascota.EspecieId;
            mascotaExistente.FechaNac = mascota.FechaNac;
            mascotaExistente.FechaDefuncion = mascota.FechaDefuncion;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{mascotaId}")]
        public ActionResult Delete(int mascotaId)
        {
            var mascota = _context.Mascota.Find(mascotaId);
            if (mascota == null)
            {
                return NotFound();
            }
            _context.Mascota.Remove(mascota);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
