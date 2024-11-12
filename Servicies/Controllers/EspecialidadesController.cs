using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.Entity.Data;
using Models.Entity.Models;

namespace Servicies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspecialidadesController : ControllerBase
    {
        private readonly VeterinariaContext _context;

        public EspecialidadesController(VeterinariaContext context)
        {
            _context = context;
        }

        // GET: api/Especialidades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Especialidad>>> GetEspecialidades()
        {
            return await _context.Especialidad.ToListAsync();
        }

        // GET: api/Especialidades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Especialidad>> GetEspecialidades(int id)
        {
            var especialidades = await _context.Especialidad.FindAsync(id);

            if (especialidades == null)
            {
                return NotFound();
            }

            return especialidades;
        }

        // PUT: api/Especialidades/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEspecialidades(int id, Especialidad especialidades)
        {
            if (id != especialidades.EspecialidadId)
            {
                return BadRequest();
            }

            _context.Entry(especialidades).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EspecialidadesExists(id))
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

        // POST: api/Especialidades
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Especialidad>> PostEspecialidades(Especialidad especialidades)
        {
            _context.Especialidad.Add(especialidades);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEspecialidades", new { id = especialidades.EspecialidadId }, especialidades);
        }

        // DELETE: api/Especialidades/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEspecialidades(int id)
        {
            var especialidades = await _context.Especialidad.FindAsync(id);
            if (especialidades == null)
            {
                return NotFound();
            }

            _context.Especialidad.Remove(especialidades);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EspecialidadesExists(int id)
        {
            return _context.Especialidad.Any(e => e.EspecialidadId == id);
        }
    }
}
