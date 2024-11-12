using Models.Entity.Models;
using Newtonsoft.Json;

namespace Logic
{
    public class MembresiasLogic
    {
        public async static Task<Membresia?> GetOne(int cod)
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.GetStringAsync($"https://localhost:7166/api/Membresias/" + cod);
                var membresia = JsonConvert.DeserializeObject<Membresia>(response);
                return membresia;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error inesperado: {e.Message}");
                return null;
            }
        }

        public async static Task<IEnumerable<Membresia>?> GetAll()
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7166/api/Membresias/");
                var membresias = JsonConvert.DeserializeObject<List<Membresia>>(response);
                return membresias;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error inesperado: {e.Message}");
                return new List<Membresia>();
            }
        }

        public async static Task<PrecioMembresia?> GetUltimoPrecioByCod(int codMembresia)
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7166/api/PreciosMembresia/");
                var precios = JsonConvert.DeserializeObject<List<PrecioMembresia>>(response);
                var ultimoPrecio = precios?
                        .Where(p => p.MembresiaId == codMembresia)
                        .OrderByDescending(p => p.FechaVigencia)
                        .FirstOrDefault();
                return ultimoPrecio;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error inesperado: {e.Message}");
                return null;
            }
        }
    }
}
