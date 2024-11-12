using Models.Clases;
using Models.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Logic
{
    public class AtencionUsuariosLogic
    {
        public async static Task<List<HorarioProfesional>> getHorarioProfesionalEspecialidadDia(DateTime date, int especialidadId)
        {
            List<HorarioProfesional> horarios;
            List<Usuario> profesionales = await UsuariosLogic.GetProfesionalesConEspecialidadIdJornada(especialidadId, date);
            List<Atencion> atenciones = await AtencionLogic.GetAtencionesByDate(date);

            if (profesionales == null )
            {
                return null;
            }
            horarios = GeneraraHorariosProf(profesionales,atenciones, date);
            return horarios;
        }





        private static List<HorarioProfesional> GeneraraHorariosProf(List<Usuario> profesinales, List<Atencion> atenciones, DateTime selectedDate)
        {

            var turnosDisponibles = new List<HorarioProfesional>();

            var diasSemana = new Dictionary<DayOfWeek, string>
                    {
                        { DayOfWeek.Monday, "Lunes" },
                        { DayOfWeek.Tuesday, "Martes" },
                        { DayOfWeek.Wednesday, "Miércoles" },
                        { DayOfWeek.Thursday, "Jueves" },
                        { DayOfWeek.Friday, "Viernes" },
                        { DayOfWeek.Saturday, "Sábado" },
                        { DayOfWeek.Sunday, "Domingo" }
            };
            var diaEnEspañol = diasSemana[selectedDate.DayOfWeek];
       


            foreach (var prof in profesinales)
            {
                foreach (var jornada in prof.Jornadas)
                {
                    if (jornada.NombreDia != diaEnEspañol)
                    {
                        continue;
                    }


                    DateTime inicio = selectedDate.Date + jornada.HoraInicio;

                    // Combina la fecha seleccionada con la hora de finalización
                    DateTime fin = selectedDate.Date + jornada.HoraFin;

                    while (inicio < fin)
                    {
                        // Agregar el intervalo y el nombre del profesional a la lista
                        if(TurnoOcupado(atenciones, inicio, prof.UsuarioId))
                            {
                            inicio = inicio.AddHours(1);
                            continue;
                        }
                        turnosDisponibles.Add(new HorarioProfesional
                        {


                            NombreProf = prof.Nombre,
                            ApellidoProf = prof.Apellido,
                            DniProf = prof.Dni,
                            ProfesionalId = prof.UsuarioId,
                            DiaHoraInicio = inicio,

                            Intervalo = $"{inicio.ToString("HH:mm")} - {inicio.AddHours(1).ToString("HH:mm")}"
                        });
                        inicio = inicio.AddHours(1);
                    }
                }


            }
            


            return turnosDisponibles;

        }
        private static bool TurnoOcupado(List<Atencion> atenciones, DateTime inicio, int userID)
        {
            if (atenciones == null)
            {
                return false;
            }
            return atenciones.Any(x => x.FechaHora == inicio && x.UsuarioId == userID);
        }
    }
}

/*

public List<HorarioProfesional> CargaDgvHorariosProfesionalesDisponibles(int idEspecialidad, DateTime calendario)
        {
      
            using (VeterinariaEntities db = new VeterinariaEntities())
            {

                var profesionales = db.USUARIOS.Where(x => x.rol == "profesional").ToList();

                
                    // Obtener la especialidad seleccionada
                   
                    var filtradosEspecialidad = profesionales.Where(x => x.ESPECIALIDADES.Any(e => e.codEspecialidad == idEspecialidad)).ToList();
         
                    string nombreDia = calendario.ToString("dddd");

                    var filtradosDia = filtradosEspecialidad.Where(x => x.JORNADA.Any(h => h.nombreDia == nombreDia)).ToList();

                    var turnosDisponibles = new List<HorarioProfesional>();


                    foreach (var prof in filtradosDia)
                    {
                        foreach (var jornada in prof.JORNADA.Where(j => j.nombreDia == nombreDia))
                        {
                            DateTime inicio = calendario.Date + jornada.horaInicioJornada;
                            DateTime fin = (DateTime)(calendario.Date + jornada.horaFinJornada);

                            while (inicio < fin)
                            {
                                // Agregar el intervalo y el nombre del profesional a la lista
                                turnosDisponibles.Add(new HorarioProfesional
                                {


                                    NombreProf = prof.nombre,
                                    ApellidoProf = prof.apellido,
                                    DniProf = prof.dni,
                                    DiaHoraInicio = inicio,

                                    Intervalo = $"{inicio.ToString("HH:mm")} - {inicio.AddHours(1).ToString("HH:mm")}"
                                });
                                inicio = inicio.AddHours(1);
                            }
                        }


                    }
                    var previos = TurnosPrevios(calendario);

                    foreach (var previo in previos)
                    {
                        turnosDisponibles.RemoveAll(x => x.DniProf == previo.DniProf && x.DiaHoraInicio == previo.DiaHoraInicio);
                    }


                    return turnosDisponibles;
            }
            

        }
        

        private List<HorarioProfesional> TurnosPrevios(DateTime diaTurno)
        {

            using (VeterinariaEntities db = new VeterinariaEntities())
            {
                var turnos = db.ATENCION
               .Where(x => DbFunctions.TruncateTime(x.fechaHoraAtencion) == DbFunctions.TruncateTime(diaTurno))
               .ToList();

                var returno = new List<HorarioProfesional>();
                foreach (var turno in turnos)
                {
                    DateTime inicio = turno.fechaHoraAtencion.Value;
                    returno.Add(new HorarioProfesional
                    {

                        NombreProf = turno.USUARIOS.nombre,
                        ApellidoProf = turno.USUARIOS.apellido,
                        DniProf = (int)(turno.dniProfesional),
                        DiaHoraInicio = (DateTime)turno.fechaHoraAtencion,
                        Intervalo = $"{inicio.ToString("HH:mm")} - {inicio.AddHours(1).ToString("HH:mm")}"
                    });
                }
                return returno;
            }
             
        }
       
 */