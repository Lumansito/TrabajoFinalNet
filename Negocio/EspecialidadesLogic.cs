using Models.Entity.Models;
using Newtonsoft.Json;

namespace Logic
{
    public class EspecialidadesLogic
    {
        public async static Task<List<Especialidad>> GetAll()
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7166/api/Especialidades/");
                var especialidades = JsonConvert.DeserializeObject<List<Especialidad>>(response);
                return especialidades;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error inesperado: {e.Message}");
                return [];
            }
        }
    }
}

