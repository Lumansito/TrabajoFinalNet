using Models.Entity.Models;
using Newtonsoft.Json;
using System.Text;

namespace Logic
{
    public class EspeciesLogic
    {
        public async static Task<Especie> GetOne(int EspecieId)
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7166/api/Especies/" + EspecieId);
                var especie = JsonConvert.DeserializeObject<Especie>(response);
                return especie;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error inesperado: {e.Message}");
                return null;
            }
        }

        public async static Task<List<Especie>?> GetAll()
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7166/api/Especies/");
                var especies = JsonConvert.DeserializeObject<List<Especie>>(response);
                return especies;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error inesperado: {e.Message}");
                return new List<Especie>();
            }
        }

        public async static Task<bool> Crear(Especie especie)
        {

            try
            {
                especie.Activo = true;
                var especieJson = JsonConvert.SerializeObject(especie);
                var content = new StringContent(especieJson, Encoding.UTF8, "application/json");
                var response = await Conexion.Instancia.Cliente.PostAsync("https://localhost:7166/api/Especies", content);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception($"Error al crear la especie: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear la especie: {ex.Message}");
                return false;
            }

            
        }


        public async static Task<bool> Editar(Especie especie)
        {
            try
            {
                var especieJson = JsonConvert.SerializeObject(especie);
                var content = new StringContent(especieJson, Encoding.UTF8, "application/json");
                var response = await Conexion.Instancia.Cliente.PutAsync("https://localhost:7166/api/Especies/" + especie.EspecieId, content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception($"Error al editar la especie: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al editar la especie: {ex.Message}");
                return false;
            }
        }

        public async static Task<bool> Eliminar(int EspecieId)
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.DeleteAsync("https://localhost:7166/api/Especies/" + EspecieId);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception($"Error al eliminar la especie: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar la especie: {ex.Message}");
                return false;
            }
        }


    }
}
