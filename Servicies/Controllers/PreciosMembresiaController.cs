using Microsoft.AspNetCore.Mvc;
using Models.Entity.Data;
using Models.Entity.Models;

namespace Servicies.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PreciosMembresiaController : ControllerBase
    {
        private readonly VeterinariaContext _context;

        public PreciosMembresiaController(VeterinariaContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "PreciosMembresia")]
        public ActionResult<IEnumerable<PrecioMembresia>> GetAll()
        {
            return _context.PrecioMembresia.ToList();
        }
    }
}
