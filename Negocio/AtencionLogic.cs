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
        public async static Task<List<Atencion>> GetAtencionesByDate(DateTime date)
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

            var response = await Conexion.Instancia.Cliente.PostAsync("https://localhost:7166/api/Atenciones", content);
            return response.IsSuccessStatusCode;

        }

        public async static Task<bool> PostAtencionDTO(AtencionDTO dto)
        {
            try
            {

                var response = await Conexion.Instancia.Cliente.PostAsJsonAsync("https://localhost:7166/api/Atenciones/dto", dto);
                return response.IsSuccessStatusCode;

            }
            catch
            (Exception e)
            {
                return false;
            }

        }


        public async static Task<List<Servicio>> GetServiciosPosiblesByIdAtencion(int atencionId)
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync($"https://localhost:7166/api/Atenciones/{atencionId}");
            var atencion = JsonConvert.DeserializeObject<Atencion>(response);

            if (atencion == null || atencion.Usuario == null)
            {
                return null;
            }
            
            var listaServicios = atencion.Usuario.Especialidades
                         .SelectMany(especialidad => especialidad.Servicios)
                         .ToList();

            return listaServicios;

        }




        public async static Task<List<InfoAtencionesRealizadas>> GetAllInfoAtencionesRealizadas()
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7166/api/Atenciones/");
            var atenciones = JsonConvert.DeserializeObject<IEnumerable<Atencion>>(response);

            if (atenciones == null)
            {
                return null;
            }
            var infoAtenciones = atenciones
                .Where(a => !string.IsNullOrWhiteSpace(a.Observaciones))
                .Select(a => new InfoAtencionesRealizadas
                {
                    AtencionId = a.AtencionId,
                    FechaHora = a.FechaHora,
                    DniCliente = a.Mascota.Cliente.Dni,
                    MascotaId = a.Mascota.MascotaId,
                    NombreMascota = a.Mascota.Nombre,
                    UsuarioId = a.UsuarioId,
                    NombreProfesional = a.Usuario.Nombre,
                    Observaciones = a.Observaciones,
                    MontoApagar = a.MontoApagar,
                    Motivo = a.Motivo,
                    FechaHoraPago = a.FechaHoraPago,
                    Servicios = a.Servicios.ToList()
                }).ToList();
            return infoAtenciones;
        }






        public async static Task<bool> RegistrarPago(int idAtencion, DateTime fechaHoraPago)
        {
            string url = $"https://localhost:7166/api/Atenciones/{idAtencion}";

            // Crea el objeto AtencionPatchDTO y asigna la fecha de pago
            var patchDto = new AtencionPatchDTO
            {
                FechaHoraPago = fechaHoraPago
            };

            // Serializa el objeto AtencionPatchDTO
            var json = JsonConvert.SerializeObject(patchDto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Realiza la solicitud PATCH
            var response = await Conexion.Instancia.Cliente.PatchAsync(url, content);

            // Retorna el estado de la respuesta
            return response.IsSuccessStatusCode;
        }





        public async static Task<List<InfoAtencionesRealizadas>> GetAtencionesCliente(int dni)
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7166/api/Atenciones/");
            var atenciones = JsonConvert.DeserializeObject<IEnumerable<Atencion>>(response);
            var atencionesFiltradas = atenciones?.Where(a => a.Mascota.Cliente.Dni == dni && a.Observaciones is not null).ToList();


            if (atencionesFiltradas == null)
            {
                return null;
            }

            var infoAtenciones = atencionesFiltradas.Select(a => new InfoAtencionesRealizadas
            {
                AtencionId = a.AtencionId,
                FechaHora = a.FechaHora,
                DniCliente = a.Mascota.Cliente.Dni,
                MascotaId = a.Mascota.MascotaId,
                NombreMascota = a.Mascota.Nombre,
                UsuarioId = a.UsuarioId,
                NombreProfesional = a.Usuario.Nombre,
                Observaciones = a.Observaciones,
                MontoApagar = a.MontoApagar,
                Motivo = a.Motivo,
                FechaHoraPago = a.FechaHoraPago
            }).ToList();

            return infoAtenciones;
        }


        public async static Task<bool> ActualizarAtencion(int idAtencion, AtencionPatchDTO patchDTO)
        {
            string url = $"https://localhost:7166/api/Atenciones/{idAtencion}/ActualizarAtencion";


            // Serializa el objeto AtencionPatchDTO
            var json = JsonConvert.SerializeObject(patchDTO);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Realiza la solicitud PATCH
            var response = await Conexion.Instancia.Cliente.PatchAsync(url, content);

            // Retorna el estado de la respuesta
            return response.IsSuccessStatusCode;
        }


    }


}
