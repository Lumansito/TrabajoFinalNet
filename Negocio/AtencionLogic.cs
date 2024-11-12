using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Logic;
using Models.Clases;
using Models.Entity.Models;
using Newtonsoft.Json;
using Models.Entity.Clases;

namespace Logic
{
    public class AtencionLogic 
    {
        public async static Task<List<Atencion>> GetAtencionesByDate(DateTime date )
        {
            string url = $"https://localhost:7166/api/Atenciones/fecha/{date.ToString("yyyy-MM-dd")}";
            var response = await Conexion.Instancia.Cliente.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<Atencion>>(responseData);
                return data;
            }
            return null;
        }

        public async static Task<bool> PostAtencion(Atencion atencion)
        {
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.IgnoreCycles,
                WriteIndented = true
            };

            string ateJson = System.Text.Json.JsonSerializer.Serialize(atencion, options);
            var content = new StringContent(ateJson, Encoding.UTF8, "application/json");

            var response = await Conexion.Instancia.Cliente.PostAsync("https://localhost:7166/api/Atenciones",  content);
            return response.IsSuccessStatusCode;

        }

        public async static Task<bool> PostAtencionDTO(AtencionDTO dto)
        {
            try
            {

                var response = await Conexion.Instancia.Cliente.PostAsJsonAsync("https://localhost:7166/api/Atenciones/dto", dto);
                return response.IsSuccessStatusCode;

            }catch
            (Exception e)
            {
                return false;
            }

        }

    }
}
