using Models.Entity.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class RazasLogic
    {
        public async static Task<List<Raza>> GetAll()
        {
            var response = await Conexion.Instancia.Cliente.GetAsync("https://localhost:7166/api/Razas/");

            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<List<Raza>>(responseData);

                return data;
            }

            return null;
        }


        public async static Task<bool> Crear(Raza raza)
        {

            try
            {
                raza.Activo=true;
                var razaJson = JsonConvert.SerializeObject(raza);
                var content = new StringContent(razaJson, Encoding.UTF8, "application/json");
                var response = await Conexion.Instancia.Cliente.PostAsync("https://localhost:7166/api/Razas", content);
                
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception($"Error al crear la raza: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear la raza: {ex.Message}");
                return false;
            }

            //return false;
        }


        public async static Task<bool> Editar(Raza raza)
        {
            try
            {
                var razaJson = JsonConvert.SerializeObject(raza);
                var content = new StringContent(razaJson, Encoding.UTF8, "application/json");
                var response = await Conexion.Instancia.Cliente.PutAsync("https://localhost:7166/api/Razas/" + raza.RazaId, content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception($"Error al editar la raza: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al editar la raza: {ex.Message}");
                return false;
            }
        }

        public async static Task<bool> Eliminar(int codRaza)
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.DeleteAsync("https://localhost:7166/api/Razas/" + codRaza);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception($"Error al eliminar la raza: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar la raza: {ex.Message}");
                return false;
            }
        }

        public async static Task<Raza> GetOne(int id)
        {
            var response = await Conexion.Instancia.Cliente.GetAsync("https://localhost:7166/api/Razas/"+id.ToString());

            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<Raza>(responseData);

                return data;
            }

            return null;
        }

    }
}
