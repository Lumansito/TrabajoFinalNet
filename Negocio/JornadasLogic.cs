using Models.Entity.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class JornadasLogic
    {
        public async static Task<Jornada?> GetOne(int JornadaId)
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.GetStringAsync($"https://localhost:7166/api/Jornadas/" + JornadaId);
                var jornada = JsonConvert.DeserializeObject<Jornada>(response);
                return jornada;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ha ocurrido un error: {e.Message}");
                return null;
            }
        }

        public async static Task<List<Jornada>?> GetAll()
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7166/api/Jornadas/");
                var jornadas = JsonConvert.DeserializeObject<List<Jornada>>(response);
                return jornadas;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ha ocurrido un error: {e.Message}");
                return [];
            }
        }

        public async static Task<Boolean> Create(Jornada jornada)
        {
            try
            {
                await Conexion.Instancia.Cliente.PostAsJsonAsync("https://localhost:7166/api/Jornadas/", jornada);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ha ocurrido un error: {e.Message}");
                return false;
            }
        }

        public async static Task<Boolean> Update(Jornada jornada)
        {
            try
            {
                await Conexion.Instancia.Cliente.PutAsJsonAsync("https://localhost:7166/api/Jornadas/" + jornada.JornadaId, jornada);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ha ocurrido un error: {e.Message}");
                return false;
            }
        }

        public async static Task<Boolean> Delete(int jornadaId)
        {
            try
            {
                await Conexion.Instancia.Cliente.DeleteAsync("https://localhost:7166/api/Jornadas/" + jornadaId);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ha ocurrido un error: {e.Message}");
                return false;
            }
        }
    }
}
