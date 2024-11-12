using Models.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;
using System.Globalization;
using System.Net.Http.Json;
using Models.Entity.Clases;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Logic
{
    public class UsuariosLogic
    {
        public async static Task<Usuario> LogInEscritorio(int dni, string password)
        {
            LoginRequestUsuario loginRequest = new LoginRequestUsuario
            { 
                Dni = dni,
                Password = password
            };

            var json = JsonConvert.SerializeObject(loginRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await Conexion.Instancia.Cliente.PostAsync("https://localhost:7166/api/Usuarios/login/escritorio", content);

            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<Usuario>(responseData);
                return data;
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                return null;
                throw new UnauthorizedAccessException("Credenciales incorrectas");
            }

            return null;
        }

        public async static Task<HttpResponseMessage> LogInWeb(UsuarioLoginDTO usuario)
        {

            var json = JsonConvert.SerializeObject(new { Dni = usuario.Dni, Contraseña = usuario.Contraseña });

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Conexion.Instancia.Cliente.PostAsync("https://localhost:7166/api/Usuarios/login", content);

            if (response.IsSuccessStatusCode)
            {
                //var responseData = await response.Content.ReadAsStringAsync();
                //var data = JsonConvert.DeserializeObject<Usuario>(responseData);
                //return data;
                return response;
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                // Muestra un mensaje de error cuando las credenciales son incorrectas
                throw new UnauthorizedAccessException("Credenciales incorrectas. Verifique sus datos e intente de nuevo.");
            }

            return null;
        }


        public async static Task<bool> Crear(Models.Entity.Models.Usuario usuario)
        {
            try
            {
                var usuarioJson = JsonConvert.SerializeObject(usuario);
                var content = new StringContent(usuarioJson, Encoding.UTF8, "application/json");
                var response = await Conexion.Instancia.Cliente.PostAsync("https://localhost:7166/api/Usuarios", content);



                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception($"Error al crear el usuario: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear el usuario: {ex.Message}");
                return false;
            }
        }

        public async static Task<Boolean> Editar(Usuario usuario)
        {
            try
            {

                var options = new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles,
                    WriteIndented = true
                };


                string usuarioJson = System.Text.Json.JsonSerializer.Serialize(usuario, options);
               
                var content = new StringContent(usuarioJson, Encoding.UTF8, "application/json");

                // Enviar la petición
                var response = await Conexion.Instancia.Cliente.PutAsync("https://localhost:7166/api/Usuarios/" + usuario.UsuarioId, content);
                return response.IsSuccessStatusCode;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ha ocurrido un error: {e.Message}");
                return false;
            }
        }

        public async static Task<Boolean> Eliminar(int id)
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.DeleteAsync("https://localhost:7166/api/Usuarios/" + id);
                return response.IsSuccessStatusCode;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ha ocurrido un error: {e.Message}");
                return false;
            }
        }



        public async static Task<List<Usuario>> GetProfesionalesConEspecialidadIdJornada(int especialidadId, DateTime date)
        {
            try
            {
                var usuarios = await GetAll();
                if (usuarios != null)
                {
                    var diasSemana = new Dictionary<DayOfWeek, string>
                    {
                        { DayOfWeek.Monday, "Lunes" },
                        { DayOfWeek.Tuesday, "Martes" },
                        { DayOfWeek.Wednesday, "Miércoles" },
                        { DayOfWeek.Thursday, "Jueves" },
                        { DayOfWeek.Friday, "Viernes" },
                        { DayOfWeek.Saturday, "Sábado" },
                        { DayOfWeek.Sunday, "Domingo" }
                    };

                    var diaEnEspañol = diasSemana[date.DayOfWeek];
                    usuarios = usuarios.Where(u => u.Especialidades.Any(e => e.EspecialidadId == especialidadId)).ToList();
                    usuarios = usuarios.Where(u => u.Jornadas.Any(j => j.NombreDia == diaEnEspañol)).ToList();

                }
                   
                return usuarios;
            }catch
            {
                return null;
            }
           
                
            

            return null; // Si no es exitosa, devolver null 
        }

        public async static Task<List<Usuario>?> GetAll()
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7166/api/Usuarios/");
                var usuarios = JsonConvert.DeserializeObject<List<Usuario>>(response);
                return usuarios;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ha ocurrido un error: {e.Message}");
                return [];
            }
        }

        public async static Task<Usuario> GetById(int id)
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.GetStringAsync($"https://localhost:7166/api/Usuarios/{id}");
                var usuario = JsonConvert.DeserializeObject<Usuario>(response);
                return usuario;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ha ocurrido un error: {e.Message}");
                return null;
            }
        }
        

    }
}
