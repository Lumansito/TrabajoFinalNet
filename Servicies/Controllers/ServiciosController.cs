using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.Entity.Data;
using Models.Entity.Models;

namespace Servicies.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServiciosController : ControllerBase
    {
        private readonly VeterinariaContext _context;

        public ServiciosController(VeterinariaContext context)
        {
            _context = context;
        }

        [HttpGet("{ServicioId}")]
        public ActionResult<Servicio> GetOne(int ServicioId)
        {
            var servicio = _context.Servicio
                .Where(s => s.ServicioId == ServicioId)
                .Include(u => u.Especialidades)
                .FirstOrDefault();
            if (servicio == null)
            {
                return NotFound();
            }
            return servicio;
        }

        [HttpGet(Name = "Servicios")]
        public ActionResult<List<Servicio>> GetAll()
        {
            var servicios = _context.Servicio
                .Where(s => s.Activo == true)
                .Include(s => s.Atenciones)
                .Include(s => s.Precios)
                .Include(s => s.Especialidades)
                .ToList();
            return servicios;
        }

        [HttpPost]
        public ActionResult Create(Servicio servicio)
        {
            _context.Servicio.Add(servicio);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpPut("{ServicioId}")]
        public ActionResult Update(int ServicioId, Servicio servicio)
        {
            if (ServicioId != servicio.ServicioId)
            {
                return BadRequest();
            }
            var servicioExistente = _context.Servicio
                .Where(s => s.ServicioId == ServicioId)
                .Include(u => u.Especialidades)
                .FirstOrDefault();
            if (servicio == null)
            {
                return NotFound();
            }
            servicioExistente.ServicioId = servicio.ServicioId;
            servicioExistente.Nombre = servicio.Nombre;
            servicioExistente.Descripcion = servicio.Descripcion;
            servicioExistente.Especialidades.Clear();
            foreach (var especialidad in servicio.Especialidades)
            {
                var especialidadExistente = _context.Especialidad.Find(especialidad.EspecialidadId);
                if (especialidadExistente != null)
                {
                    servicioExistente.Especialidades.Add(especialidadExistente);
                }
            }
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{ServicioId}")]
        public ActionResult Delete(int ServicioId)
        {
            var servicio = _context.Servicio.Find(ServicioId);
            if (servicio == null)
            {
                return NotFound();
            }
            servicio.Activo = false;
            _context.SaveChanges();
            return NoContent();
        }
    }
}
