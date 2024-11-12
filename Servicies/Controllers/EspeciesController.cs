using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.Entity.Data;
using Models.Entity.Models;

namespace Servicies.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EspeciesController : ControllerBase
    {
        private readonly VeterinariaContext _context;

        public EspeciesController(VeterinariaContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "Especies")]
        public ActionResult<IEnumerable<Especie>> GetAll()
        {
            return _context.Especie
                .Where(r => r.Activo == true) 
                .ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Especie> GetOne(int id)
        {
            var especie = _context.Especie.Find(id);

            if (especie == null)
            {
                return NotFound();
            }
            return especie;
        }

        [HttpPost]
        public ActionResult<Especie> Crear(Especie especie)
        {
            _context.Especie.Add(especie);
            _context.SaveChanges();

            return CreatedAtRoute("Especies", new { id = especie.EspecieId }, especie);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Especie especie)
        {
            if (id != especie.EspecieId)
            {
                return BadRequest();
            }

            _context.Entry(especie).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var especie = _context.Especie.Find(id);

            if (especie == null)
            {
                return NotFound();
            }

            especie.Activo = false;    
            _context.SaveChanges();

            return NoContent();
        }



    }
}
