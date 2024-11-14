using Models.Entity.Models;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Logic
{
    public class MascotasLogic
    {
        public async static Task<List<Mascota>?> GetAllByDni(int dni)
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7166/api/Mascotas/cliente/" + dni);
                var mascotas = JsonConvert.DeserializeObject<List<Mascota>>(response);
                return mascotas;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error inesperado: {e.Message}");
                return [];
            }
        }

        public async static Task<Mascota?> GetOne(int mascotaId)
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7166/api/Mascotas/" + mascotaId);
                var mascota = JsonConvert.DeserializeObject<Mascota>(response);
                return mascota;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error inesperado: {e.Message}");
                return null;
            }
        }

        public async static Task<Boolean> Create(Mascota mascota)
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.PostAsJsonAsync("https://localhost:7166/api/Mascotas", mascota);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                
                return false;
               
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ha ocurrido un error: {e.Message}");
                return false;
            }
        }

        public async static Task<Boolean> Update(Mascota mascota)
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.PutAsJsonAsync("https://localhost:7166/api/Mascotas/" +mascota.MascotaId, mascota);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception($"Error al actualizar la informacion de la mascota: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar la informacion de la mascota: {ex.Message}");
                return false;
            }
        }

        public async static Task<Boolean> Delete(Mascota mascota)
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.DeleteAsync("https://localhost:7166/api/Mascotas/" + mascota.MascotaId);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception($"Error al eliminar la mascota: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar la mascota: {ex.Message}");
                return false;
            }
        }
    }
}
