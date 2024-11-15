﻿using Models.Entity.Models;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;

namespace Logic
{
    public class ServiciosLogic
    {


        public async static Task<List<Servicio>> GetServiciosByIdAtencion(int idAtencion)
        {
            string urlAtencionServicios = $"https://localhost:7166/api/Atenciones/";
            var responseAtencion = await Conexion.Instancia.Cliente.GetAsync(urlAtencionServicios);
            if (responseAtencion.IsSuccessStatusCode)
            {
                var responseData = await responseAtencion.Content.ReadAsStringAsync();
                var atencion = JsonConvert.DeserializeObject<List<Models.Entity.Models.Atencion>>(responseData);

                var serviciosFiltrados = atencion?
                .Where(a => a.AtencionId == idAtencion)
                .SelectMany(a => a.Servicios) // Selecciona todos los servicios de la atenci�n
                .ToList();
                return serviciosFiltrados;
            }

            return null; // Si no es exitosa, devolver null 
        }



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

        public async static Task<bool> AsignarPrecio(int servicioId, decimal nuevoPrecio)
        {
            try
            {
                string url = $"https://localhost:7166/api/Servicios/{servicioId}/AsignarPrecio?precio={nuevoPrecio}";
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
