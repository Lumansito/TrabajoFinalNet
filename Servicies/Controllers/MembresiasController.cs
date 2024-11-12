using Microsoft.AspNetCore.Mvc;
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
    }
}
