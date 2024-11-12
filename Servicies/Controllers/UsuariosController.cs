using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.Entity.Data;
using Models.Entity.Models;
using Models.Entity.Clases;
using System.Globalization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly VeterinariaContext _context;

        public UsuariosController(VeterinariaContext context)
        {
            _context = context;
        }

        // GET: api/Usuarios
        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> GetUsuarios()
        {
            var usuarios = await _context.Usuario
                .Include(u => u.Jornadas)
                .Include(u => u.Especialidades)
                .ToListAsync();

            return usuarios;
        }

        // GET: api/Usuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetUsuario(int id)
        {
            var usuario = await _context.Usuario
                .Where(u => u.UsuarioId == id)
                .Include(u => u.Jornadas)
                .Include(u => u.Especialidades)
                .FirstOrDefaultAsync();

            if (usuario == null)
            {
                return NotFound();
            }

            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.IgnoreCycles,
                WriteIndented = true
            };

            var jsonResponse = JsonSerializer.Serialize(usuario, options);
            return new ContentResult
            {
                Content = jsonResponse,
                ContentType = "application/json",
                StatusCode = 200 
            };
        }

        // PUT: api/Usuarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuarios(int id, Usuario usuario)
        {
            if (id != usuario.UsuarioId)
            {
                return BadRequest();
            }

            var usuarioExistente = await _context.Usuario
            .Include(u => u.Jornadas) 
            .Include(u => u.Especialidades)
            .FirstOrDefaultAsync(u => u.UsuarioId == id);

            if (usuarioExistente == null)
            {
                return NotFound();
            }

            // Actualizar las propiedades simples del usuario
            usuarioExistente.Nombre = usuario.Nombre;
            usuarioExistente.Dni = usuario.Dni;
            usuarioExistente.Mail = usuario.Mail;
            usuarioExistente.Apellido = usuario.Apellido;
            usuarioExistente.Telefono = usuario.Telefono;
            usuarioExistente.FechaNacimiento = usuario.FechaNacimiento;
            usuarioExistente.Rol = usuario.Rol;
            usuarioExistente.IsAdmin = usuario.IsAdmin;
            usuarioExistente.Contraseña = usuario.Contraseña;
            usuarioExistente.Activo = usuario.Activo;
            usuarioExistente.FechaAlta = usuario.FechaAlta;
           
            usuarioExistente.Jornadas.Clear(); 
            foreach (var jornada in usuario.Jornadas)
            {
                var jornadaExistente = await _context.Jornada.FindAsync(jornada.JornadaId);
                if (jornadaExistente != null)
                {
                    usuarioExistente.Jornadas.Add(jornadaExistente); 
                }
            }

            usuarioExistente.Especialidades.Clear();
            foreach (var especialidad in usuario.Especialidades)
            {
                var especialidadExistente = await _context.Especialidad.FindAsync(especialidad.EspecialidadId);
                if (especialidadExistente != null)
                {
                    usuarioExistente.Especialidades.Add(especialidadExistente);
                }
            }


            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuariosExists(id))
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

        // POST: api/Usuarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuarios(Usuario usuarios)
        {
            _context.Usuario.Add(usuarios);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UsuariosExists(usuarios.Dni))
                {
                    return Conflict();
                }
               else
               {
                    throw;
               }
            }

           return CreatedAtAction("GetUsuarios", new { id = usuarios.Dni }, usuarios);
        }

        // DELETE: api/Usuarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuarios(int id)
        {
            var usuarios = await _context.Usuario.FindAsync(id);
            if (usuarios == null)
            {
                return NotFound();
            }

            _context.Usuario.Remove(usuarios);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsuariosExists(int id)
        {
            return _context.Usuario.Any(e => e.Dni == id);
        }


        [HttpPost("register")]
        public async Task<ActionResult<string>> Register(UsuarioRegisterDTO objeto)
        {
            Usuario usuario = new Usuario();


            usuario.Dni = objeto.Dni;
            usuario.Nombre = objeto.Nombre;
            usuario.Contraseña = objeto.Contraseña;
            usuario.Rol = objeto.Rol;
            usuario.Mail = objeto.Mail;
            usuario.Apellido = objeto.Apellido;
            usuario.Telefono = objeto.Telefono;
            usuario.FechaNacimiento = objeto.FechaNacimiento;
            usuario.IsAdmin = objeto.IsAdmin;
            _context.Usuario.Add(usuario);
            await _context.SaveChangesAsync();
            var respuesta = "Registrado Con Exito";

            return respuesta;
        }
        [HttpPost("login")]
        public async Task<ActionResult<string>> LogIn(UsuarioLoginDTO objeto)
        {
            //if (objeto == null)
            //{
            //    return BadRequest("Datos de usuario inválidos");
            //}

            var usuario = await _context.Usuario.FirstOrDefaultAsync(x => x.Dni == objeto.Dni);

            if (usuario == null)
            {
                return Unauthorized("Usuario no encontrado");
            }

            if (objeto.Contraseña != usuario.Contraseña)
            {
                return Unauthorized("Contraseña incorrecta");
            }

            string token = CreateToken(usuario);
            return Ok(token);
        }

        [HttpPost("login/escritorio")]
        public async Task<ActionResult<Usuario>> LogInEscritorio([FromBody] LoginRequestUsuario objeto)
        {
            

            var usuario = _context.Usuario.FirstOrDefault(x => x.Dni == objeto.Dni);
            

            if (usuario == null)
            {
                return Unauthorized("Usuario no encontrado");
            }

            if (objeto.Password != usuario.Contraseña)
            {
                return Unauthorized("Contraseña incorrecta");
            }

            
            return usuario;
        }



        //private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        //{
        //    using (var hmac = new HMACSHA512())
        //    {
        //        passwordSalt = hmac.Key; // Asigna el salt
        //        passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password)); // Asigna el hash
        //    }
        //}

        //private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        //{
        //    //Se utiliza al loguearse
        //    //Si la contra ingresada coincide con las contras encriptadas de la BD --> return TRUE
        //    using (var hmac = new HMACSHA512(passwordSalt))
        //    {
        //        var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        //        return computedHash.SequenceEqual(passwordHash);
        //    }
        //}

        private string CreateToken(Usuario user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, user.Mail) // Guarda el email en el token
            };

            if(user.IsAdmin == true)
            {
                claims.Add(new Claim(ClaimTypes.Role, "Admin"));
            }
            else
            {
                claims.Add(new Claim(ClaimTypes.Role, user.Rol));
            }

            //key del token, independiente a la contraseña del usuario
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                "EstaEsUnaClaveSecretaDeAlMenos32Caracteres!")); // Mínimo 32 caracteres

            // Credenciales de firma con HMAC-SHA256
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }


    }


    /*
    [HttpGet("profesionales/especialidad/{codEspecialidad}")]
    public async Task<ActionResult<IEnumerable<Usuario>>> GetProfesionalesWithEspecialidades(int codEspecialidad)
    {
        // Verificar si la especialidad existe
        var especialidad = await _context.Especialidad.FindAsync(codEspecialidad);
        if (especialidad == null)
        {
            return NotFound();
        }

        // Filtrar los usuarios que tienen la especialidad proporcionada
        var profesionales = await _context.Usuario
            .Include(u => u.Jornada) // Asegúrate de incluir la jornada
            .Where(u => u.CodEspecialidad.Contains(especialidad)) // Filtra por especialidad
            .ToListAsync();

        // Si no hay profesionales con la especialidad, devolver 404
        if (profesionales == null || !profesionales.Any())
        {
            return NotFound("No se encontraron profesionales para la especialidad proporcionada.");
        }

        // Devolver la lista de profesionales con la especialidad
        return Ok(profesionales);
    }
    */



}

