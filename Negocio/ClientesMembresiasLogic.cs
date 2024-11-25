using Models.Entity.Models;
using Models.Entity.Clases;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace Logic
{
    public class ClientesMembresiasLogic
    {
        public async static Task<IEnumerable<ClienteMembresia>?> GetAll()
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7166/api/ClientesMembresias/");
                var clientesMembresias = JsonConvert.DeserializeObject<List<ClienteMembresia>>(response);
                return clientesMembresias;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error inesperado: {e.Message}");
                return new List<ClienteMembresia>();
            }
        }

        public async static Task<Boolean> Add(ClienteMembresia clienteMembresia)
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.PostAsJsonAsync("https://localhost:7166/api/ClientesMembresias/", clienteMembresia);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception($"Error al crear la instancia ClienteMembresia: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear la instancia ClienteMembresia: {ex.Message}");
                return false;
            }
        }

        public async static Task<ClienteMembresia?> GetUltimoClienteMembresia(int dniCliente)
        {
            try
            {
                var cm = await ClientesMembresiasLogic.GetAll();
                var ultimaMembresia = cm?
                    .Where(cm => cm.Cliente.Dni == dniCliente)
                    .OrderByDescending(cm => cm.FechaDesde)
                    .FirstOrDefault();
                return ultimaMembresia;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error inesperado: {e.Message}");
                return null;
            }
        }

        public async static Task<ClienteMembresia> GetPorcentajeDescuentoByDni(int codMembresia, int dniCliente)
        {
            string url = $"https://localhost:7166/api/ClientesMembresias/{codMembresia}/{dniCliente}";

            var response = await Conexion.Instancia.Cliente.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var clienteMembresia = await response.Content.ReadFromJsonAsync<ClienteMembresia>();
                return clienteMembresia;
            }

            return null;
        }

        public async static Task<MembresiaInfo> GetInfoUltimaMembresiaByDni(int dni)
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7166/api/ClientesMembresias/");
            var clientesMembresias = JsonConvert.DeserializeObject<IEnumerable<ClienteMembresia>>(response);

            var clienteMembresia = clientesMembresias?
                .Where(cm => cm.Cliente.Dni == dni)
                .OrderByDescending(p => p.FechaDesde)
                .FirstOrDefault();

            var codUltimaMembresia = clientesMembresias?
                    .Where(cm => cm.Cliente.Dni == dni && cm.FechaDesde.AddDays(30) > DateTime.Now) 
                    .OrderByDescending(p => p.FechaDesde)
                    .Select(cm => cm.MembresiaId) // Seleccionar la membresía asociada
                    .FirstOrDefault();

            var response2 = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7166/api/Membresias/");
            var membresias = JsonConvert.DeserializeObject<IEnumerable<Membresia>>(response2);
            var ultimaMembresia = membresias?
                .Where(m => m.MembresiaId == codUltimaMembresia)
                .FirstOrDefault();

            if (ultimaMembresia == null)
            {
                return null;
            }

            return new MembresiaInfo
            {
                FechaDesde = clienteMembresia.FechaDesde,
                PorcentajeDescuento = ultimaMembresia.PorcentajeDescuento,
                Descripcion = ultimaMembresia.Descripcion

            };
        }

    }
}