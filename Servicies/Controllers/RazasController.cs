using Microsoft.AspNetCore.Mvc;
using Models.Entity.Data;
using Models.Entity.Models;

namespace Servicies.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RazasController : ControllerBase
    {
        private readonly VeterinariaContext _context;

        public RazasController(VeterinariaContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "Razas")]
        public ActionResult<IEnumerable<Raza>> GetAll()
        {
            var razas = _context.Raza
            .Where(r => r.Activo == true) // Filtra solo las razas activas
            .ToList();
            return razas;
        }

        [HttpGet("{codRaza}")]
        public ActionResult<Raza> GetByCodRaza(int codRaza)
        {
            var raza = _context.Raza.Find(codRaza);
            if (raza == null)
            {
                return NotFound();
            }
            return raza;
        }


        [HttpPost]
        public ActionResult<Raza> PostRaza(Raza raza)
        {
            _context.Raza.Add(raza);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{codRaza}")]
        public ActionResult Delete(int codRaza) {
            var raza = _context.Raza.Find(codRaza);
            if (raza == null)
            {
                return NotFound();
            }
            raza.Activo = false;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpPut("{codRaza}")]
        public IActionResult EditarRaza(int codRaza, Raza raza)
        {
            Console.WriteLine( raza);

            if (codRaza != raza.RazaId)
            {
                return BadRequest();
            }
            _context.Entry(raza).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return NoContent();
        }
    }
}
