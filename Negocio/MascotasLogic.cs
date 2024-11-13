using Models.Entity.Models;
using Models.Clases;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Logic
{
    public class MascotasLogic
    {
       

        public async static Task<List<Mascota>> GetAllByDni(int dni)
        {
            string url = $"https://localhost:7166/api/Mascotas/cliente/{dni}";
            var response = await Conexion.Instancia.Cliente.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<Mascota>>(responseData);

                return data;

            }

            return null;
        }

        public async static Task<Mascota?> GetOne(int MascotaId) //REVISAR se coloca la "a" para mentirle al compilñador y q no haga ruido
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7166/api/Mascotas/"+ MascotaId );
                var mascota = JsonConvert.DeserializeObject<Mascota>(response);
                return mascota;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error inesperado: {e.Message}");
                return null;
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
                var response = await Conexion.Instancia.Cliente.DeleteAsync("https://localhost:7166/api/Mascotas/" +mascota.MascotaId);
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
