using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.Entity.Data;
using Models.Entity.Models;

namespace Servicies.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MembresiasController : ControllerBase
    {
        private readonly VeterinariaContext _context;

        public MembresiasController(VeterinariaContext context)
        {
            _context = context;
        }

        [HttpGet("{cod}")]
        public ActionResult<Membresia> GetOne(int cod)
        {
            var membresia = _context.Membresia.Find(cod);

            if (membresia == null)
            {
                return NotFound();
            }
            return membresia;
        }

        [HttpGet(Name = "Membresias")]
        public ActionResult<IEnumerable<Membresia>> GetAll()
        {
            return _context.Membresia.ToList();
        }

        [HttpPost]
        public ActionResult Create(Membresia membresia)
        {
            _context.Membresia.Add(membresia);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpPut("{MembresiaId}")]
        public ActionResult Update(int MembresiaId, Membresia membresia)
        {
            if (MembresiaId != membresia.MembresiaId)
            {
                return BadRequest();
            }
            var membresiaExistente = _context.Membresia
                .Where(s => s.MembresiaId == MembresiaId)
                .Include(s => s.Precios)
                .FirstOrDefault();
            if (membresia == null)
            {
                return NotFound();
            }
            membresiaExistente.MembresiaId = membresia.MembresiaId;
            membresiaExistente.AntiguedadMinimaCliente = membresia.AntiguedadMinimaCliente;
            membresiaExistente.Descripcion = membresia.Descripcion;
            membresiaExistente.Precios.Clear();
            
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{MembresiaId}")]
        public ActionResult Delete(int MembresiaId)
        {
            var membresia = _context.Membresia.Find(MembresiaId);
            if (membresia == null)
            {
                return NotFound();
            }
            membresia.Activo = false;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpPatch("{id}/AsignarPrecio")]
        public async Task<IActionResult> AsignarPrecio(int id, [FromQuery] decimal precio)
        {
            var membresia = await _context.Membresia.FindAsync(id);
            if (membresia == null)
            {
                return NotFound();
            }

            PrecioMembresia precioMembresiaNuevo = new PrecioMembresia
            {
                MembresiaId = membresia.MembresiaId,
                Precio = precio,
                FechaVigencia = DateTime.Now
            };

            membresia.Precios.Add(precioMembresiaNuevo);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
