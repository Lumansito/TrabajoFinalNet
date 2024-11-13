using Models.Entity.Models;
using Newtonsoft.Json;
using System.Net.Http.Json;

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

        public async static Task<Boolean> Delete(int membresiaId)
        {
            try
            {
                await Conexion.Instancia.Cliente.DeleteAsync("https://localhost:7166/api/Membresias/" + membresiaId);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ha ocurrido un error: {e.Message}");
                return false;
            }
        }

        public async static Task<Boolean> Create(Membresia membresia)
        {
            try
            {
                await Conexion.Instancia.Cliente.PostAsJsonAsync("https://localhost:7166/api/Membresias/", membresia);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ha ocurrido un error: {e.Message}");
                return false;
            }
        }

        public async static Task<Boolean> Update(Membresia membresia)
        {
            try
            {
                await Conexion.Instancia.Cliente.PutAsJsonAsync("https://localhost:7166/api/Membresias/" + membresia.MembresiaId, membresia);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ha ocurrido un error: {e.Message}");
                return false;
            }
        }

        public async static Task<bool> AsignarPrecio(int membresiaId, decimal nuevoPrecio)
        {
            try
            {
                string url = $"https://localhost:7166/api/Membresias/{membresiaId}/AsignarPrecio?precio={nuevoPrecio}";
                var response = await Conexion.Instancia.Cliente.PatchAsync(url, null);

                return response.IsSuccessStatusCode;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ha ocurrido un error: {e.Message}");
                return false;
            }
        }
    }
}
