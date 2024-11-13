using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.Entity.Clases;
using Models.Entity.Data;
using Models.Entity.Models;

namespace Servicies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtencionesController : ControllerBase
    {
        private readonly VeterinariaContext _context;
        

        public AtencionesController(VeterinariaContext context)
        {
            _context = context;
           
        }

        // GET: api/Atenciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Atencion>>> GetAtencion()
        {
            return await _context.Atencion.Include(a => a.Servicios).Include(a => a.Usuario).Include(a => a.Mascota).ThenInclude(m => m.Cliente).ThenInclude(c => c.ClienteMembresia).ToListAsync();
        }

        // GET: api/Atenciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Atencion>> GetAtencion(int id)
        {
            var atencion = await _context.Atencion
           .Include(a => a.Servicios)
           .FirstOrDefaultAsync(a => a.AtencionId == id);

            if (atencion == null)
            {
                return NotFound();
            }

            return atencion;
        }

        // PUT: api/Atenciones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAtencion(int id, Atencion atencion)
        {
            if (id != atencion.AtencionId)
            {
                return BadRequest();
            }

            _context.Entry(atencion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AtencionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Atenciones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Atencion>> PostAtencion(Atencion atencion)
        {

            Atencion a = new Atencion();
            a= atencion;

            
            _context.Atencion.Add(a);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost("dto")]
        public IActionResult CreateAtencionDTO([FromBody] AtencionDTO dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }

            Atencion a = new Atencion();
            a.FechaHora = dto.FechaHora;
            a.Motivo = dto.Motivo;

            var mascota =  _context.Mascota.Find(dto.MascotaId);
            var usuario =  _context.Usuario.Find(dto.UsuarioId);

            if (mascota == null || usuario ==null) {
                return BadRequest();
            }

            a.Mascota = mascota;
            a.Usuario = usuario;


            _context.Atencion.Add(a);
            _context.SaveChanges();

            return Ok(dto); 
        }


        // DELETE: api/Atenciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAtencion(int id)
        {
            var atencion = await _context.Atencion.FindAsync(id);
            if (atencion == null)
            {
                return NotFound();
            }

            _context.Atencion.Remove(atencion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AtencionExists(int id)
        {
            return _context.Atencion.Any(e => e.AtencionId == id);
        }

        [HttpGet("fecha/{date}")]
        public async Task<IEnumerable<Atencion>> GetAtencionesByDate(DateTime date)
        {

            return await _context.Atencion.Where(x => x.FechaHora.Date == date.Date).ToListAsync();
        }
    }
}
