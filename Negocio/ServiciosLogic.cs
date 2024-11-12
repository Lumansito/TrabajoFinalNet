using Models.Entity.Models;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Logic
{
    public class ServiciosLogic
    {
        public async static Task<Servicio?> GetOne(int ServicioId)
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.GetStringAsync($"https://localhost:7166/api/Servicios/" + ServicioId);
                var servicio = JsonConvert.DeserializeObject<Servicio>(response);
                return servicio;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ha ocurrido un error: {e.Message}");
                return null;
            }
        }

        public async static Task<List<Servicio>?> GetAll()
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7166/api/Servicios/");
                var servicios = JsonConvert.DeserializeObject<List<Servicio>>(response);
                return servicios;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ha ocurrido un error: {e.Message}");
                return [];
            }
        }

        public async static Task<Boolean> Create(Servicio servicio)
        {
            try
            {
                await Conexion.Instancia.Cliente.PostAsJsonAsync("https://localhost:7166/api/Servicios/", servicio);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ha ocurrido un error: {e.Message}");
                return false;
            }
        }

        public async static Task<Boolean> Update(Servicio servicio)
        {
            try
            {
                await Conexion.Instancia.Cliente.PutAsJsonAsync("https://localhost:7166/api/Servicios/" + servicio.ServicioId, servicio);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ha ocurrido un error: {e.Message}");
                return false;
            }
        }

        public async static Task<Boolean> Delete(int servicioId)
        {
            try
            {
                await Conexion.Instancia.Cliente.DeleteAsync("https://localhost:7166/api/Servicios/" + servicioId);
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
