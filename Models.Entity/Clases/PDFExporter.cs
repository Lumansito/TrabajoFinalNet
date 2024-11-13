using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Linq;
using Models.Entity.Data;
using Models.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Collections.Generic;

namespace Models.Entity.Clases
{
    public class PDFExporter
    {
        static PDFExporter()
        {
            // Configuración de la licencia
            QuestPDF.Settings.License = LicenseType.Community;
        }

        public static IDocument CreateDocument()
        {
            VeterinariaContext context = new VeterinariaContext();

            // Obtener la fecha de hace un mes
            DateTime fechaUltimoMes = DateTime.Now.AddMonths(-1);

            // Filtrar las atenciones realizadas en el último mes
            var atencionesUltimoMes = context.Atencion
                .Where(a => a.FechaHoraPago >= fechaUltimoMes)
                .Include(a => a.Mascota)
                .ThenInclude(m => m.Cliente)
                .ToList();

            // Crear la lista de AtencionReporte con la información filtrada
            List<AtencionReporte> muestra = new List<AtencionReporte>();

            foreach (var atencion in atencionesUltimoMes)
            {
                var cliente = atencion.Mascota.Cliente;

                var membresia = context.ClienteMembresia
                    .Where(cm => cm.ClienteId == cliente.ClienteId && cm.FechaDesde >= DateTime.Now.AddMonths(-1))
                    .Include(cm => cm.Membresia)
                    .OrderByDescending(cm => cm.FechaDesde)
                    .FirstOrDefault();

                // Variable de descuento
                decimal descuento = 0;

                // Si se encuentra una membresía dentro del último mes, asignar el descuento
                if (membresia != null)
                {
                    descuento = membresia.Membresia.PorcentajeDescuento; // Si el descuento es nulo, usar 0
                }


                var montoFinal = atencion.MontoApagar - (atencion.MontoApagar * (descuento) / 100);

                muestra.Add(new AtencionReporte
                {
                    FechaHora = atencion.FechaHora,
                    Motivo = atencion.Motivo,                   
                    MontoAPagar = atencion.MontoApagar,
                    Dni = cliente.Dni.ToString(),
                    Descuento = descuento,
                    MontoFinal = montoFinal
                });
            }

            // Calcular el total de los MontoFinal
            decimal? totalMontoFinal = muestra.Sum(a => a.MontoFinal);

            return Document.Create(container =>
            {
                // Definir las propiedades del documento
                container.Page(page =>
                {
                    page.Margin(50);
                    page.Size(PageSizes.A4);

                    page.Content().Column(column =>
                    {
                        // Título del documento
                        column.Item().Text("Reporte de Atenciones del Último Mes").FontSize(24).Bold().Underline();

                        // Espaciado entre elementos
                        column.Item().PaddingTop(20).Text("Este reporte muestra las atenciones realizadas en el último mes.");

                        // Espaciado entre elementos
                        column.Item().PaddingTop(20).Text("A continuación se detallan las atenciones:");

                        // Crear una tabla para mostrar las atenciones con encabezados
                        column.Item().Table(table =>
                        {
                            // Definir las columnas de la tabla (Fecha, Motivo, Monto, DNI Cliente, Descuento, Monto Final)
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(); // Fecha
                                columns.RelativeColumn(); // Motivo
                                columns.RelativeColumn(); // Monto
                                columns.RelativeColumn(); // DNI Cliente
                                columns.RelativeColumn(); // Descuento
                                columns.RelativeColumn(); // Monto Final
                            });

                            // Agregar los encabezados
                            table.Cell().Text("Fecha").Bold();
                            table.Cell().Text("Motivo").Bold();
                            table.Cell().Text("Monto").Bold();
                            table.Cell().Text("DNI Cliente").Bold();
                            table.Cell().Text("Descuento (%)").Bold();
                            table.Cell().Text("Monto Final").Bold();

                            // Agregar filas de datos (cada atención)
                            foreach (var atencion in muestra)
                            {
                                table.Cell().Text(atencion.FechaHora.ToString("dd/MM/yyyy"));
                                table.Cell().Text(atencion.Motivo);
                                table.Cell().Text(atencion.MontoAPagar?.ToString("C"));
                                table.Cell().Text(atencion.Dni);
                                table.Cell().Text(atencion.Descuento.ToString("0.00"));
                                table.Cell().Text(atencion.MontoFinal?.ToString("C"));
                            }

                            // Agregar una fila al final con la suma de los Montos Finales
                            table.Cell().ColumnSpan(5).Text("Total Monto Final:").Bold();
                            table.Cell().Text(totalMontoFinal?.ToString("C")).Bold();
                        });
                    });
                });
            });
        }
    }
}
