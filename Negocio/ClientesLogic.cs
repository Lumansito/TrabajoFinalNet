using Models.Clases;
using Models.Models;
using Newtonsoft.Json;
using System.Text;

namespace Logic
{
    public class ClientesLogic
    {
        public async static Task<IEnumerable<MembresiasCliente>> GetAllByDni(int dni)
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7166/api/Clientes/" + dni);
                var cliente = JsonConvert.DeserializeObject<Clientes>(response);

                response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7166/api/Membresias/");
                var membresias = JsonConvert.DeserializeObject<List<Membresia>>(response);

                response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7166/api/ClientesMembresias/");
                var clientesMembresias = JsonConvert.DeserializeObject<List<ClienteMembresia>>(response);

                response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7166/api/PreciosMembresia/");
                var preciosMembresias = JsonConvert.DeserializeObject<List<PrecioMembresia>>(response);

                var membresiasFiltradas = clientesMembresias?
                        .Where(cm => cm.DniCliente == dni)
                        .Select(cm => new MembresiasCliente
                        {
                            Descripcion = membresias?.FirstOrDefault(m => m.CodMembresia == cm.CodMembresia)?.Descripcion,
                            FechaDesde = cm.FechaDesde,
                            Precio = preciosMembresias?.FirstOrDefault(pm => pm.CodMembresia == cm.CodMembresia && pm.FechaVigencia <= cm.FechaDesde)?.Precio,
                            PorcentajeDescuento = membresias?.FirstOrDefault(m => m.CodMembresia == cm.CodMembresia)?.PorcentajeDescuento,
                        });
                return membresiasFiltradas;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error inesperado: {e.Message}");
                return null;
            }
        }

        public async static Task<List<Clientes>> GetAll()
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.GetAsync("https://localhost:7166/api/Clientes");
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Clientes>>(responseBody) ?? new List<Clientes>();
                }
                else
                {
                    throw new Exception($"Error en la respuesta de la API: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener la lista de clientes: {ex.Message}");
                return new List<Clientes>();
            }
        }

        public async static Task<Clientes> GetByDni(int Dni)
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.GetAsync("https://localhost:7166/api/Clientes/" + Dni.ToString());
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Clientes>(responseBody) ?? new Clientes();
                }
                else
                {
                    throw new Exception($"Error en la respuesta de la API: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el Cliente : {ex.Message}");
                return new Clientes();
            }

        }

        public async static Task<bool> Eliminar(int Dni)
        {
            try
            {
                var response = await Conexion.Instancia.Cliente.DeleteAsync("https://localhost:7166/api/Clientes/" + Dni.ToString());
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception($"Error en la respuesta de la API: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el Cliente : {ex.Message}");
                return false;
            }
        }

        public async static Task<bool> Crear(Clientes cliente)
        {
            try
            {
                var clienteJson = JsonConvert.SerializeObject(cliente);
                var content = new StringContent(clienteJson, Encoding.UTF8, "application/json");
                var response = await Conexion.Instancia.Cliente.PostAsync("https://localhost:7166/api/Clientes", content);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception($"Error al crear el cliente: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear el cliente: {ex.Message}");
                return false;
            }
        }

        public async static Task<bool> Editar(Clientes cliente)
        {
            try
            {
                var clienteJson = JsonConvert.SerializeObject(cliente);
                var content = new StringContent(clienteJson, Encoding.UTF8, "application/json");
                var response = await Conexion.Instancia.Cliente.PutAsync("https://localhost:7166/api/Clientes/" + cliente.DniCliente, content);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception($"Error al editar el cliente: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al editar el cliente: {ex.Message}");
                return false;
            }
        }


    }
}
