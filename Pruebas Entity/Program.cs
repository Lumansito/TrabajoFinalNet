using Microsoft.EntityFrameworkCore;
using Models.Entity.Data;
using Models.Entity.Models;
using System.Text.Json.Serialization;
using System.Text.Json;
using Models.Entity.Clases;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using Logic;



//var a =PDFExporter.CreateDocument();
//QuestPDF.Settings.License = LicenseType.Community;


//a.GeneratePdf(@"C:\Users\matia\Desktop\ReporteBasico.pdf");
//Console.WriteLine("Se creo");

static async Task<List<Servicio>> pruebaServicios()
{
    var servicios = await Logic.AtencionLogic.GetServiciosPosiblesByIdAtencion(1);
    Console.WriteLine(servicios);
    return servicios;
}


Console.ReadLine();


// Agregar usuarios (profesionales)
/*
context.InicializarBaseDatos();

var especie1 = new Especie { Nombre = "Perro" };
var especie2 = new Especie { Nombre = "Gato" };

context.Especie.AddRange(especie1, especie2);
context.SaveChanges();

// Agregar razas<
var raza1 = new Raza { Nombre = "Labrador" };
var raza2 = new Raza { Nombre = "Persa" };

context.Raza.AddRange(raza1, raza2);
context.SaveChanges();

// Agregar clientes
var cliente1 = new Cliente { Nombre = "Juan Pérez" };
var cliente2 = new Cliente { Nombre = "Ana Gómez" };

context.Cliente.AddRange(cliente1, cliente2);
context.SaveChanges();

// Agregar membresías
var membresia1 = new Membresia { Descripcion = "Básica" };
var membresia2 = new Membresia { Descripcion = "Premium" };

context.Membresia.AddRange(membresia1, membresia2);
context.SaveChanges();

// Agregar precios de membresía
var precioMembresia1 = new PrecioMembresia { Precio = 100, Membresia = membresia1 };
var precioMembresia2 = new PrecioMembresia { Precio = 200, Membresia = membresia2 };

context.PrecioMembresia.AddRange(precioMembresia1, precioMembresia2);
context.SaveChanges();

// Agregar mascotas
var mascota1 = new Mascota { Nombre = "Firulais", Cliente = cliente1, Raza = raza1, Especie = especie1 };
var mascota2 = new Mascota { Nombre = "Mimi", Cliente = cliente2, Raza = raza2, Especie = especie2 };

context.Mascota.AddRange(mascota1, mascota2);
context.SaveChanges();

// Agregar servicios
var servicio1 = new Servicio { Nombre = "Vacunación" };
var servicio2 = new Servicio { Nombre = "Baño" };

context.Servicio.AddRange(servicio1, servicio2);
context.SaveChanges();

// Agregar precios de servicio
var precioServicio1 = new PrecioServicio { Precio = 50, Servicio = servicio1 };
var precioServicio2 = new PrecioServicio { Precio = 30, Servicio = servicio2 };

context.PrecioServicio.AddRange(precioServicio1, precioServicio2);
context.SaveChanges();

// Agregar especialidades
var especialidad1 = new Especialidad { Nombre = "Veterinario General" };
var especialidad2 = new Especialidad { Nombre = "Dermatología" };

context.Especialidad.AddRange(especialidad1, especialidad2);
context.SaveChanges();

// Agregar usuarios (profesionales)
var usuario1 = new Usuario { Nombre = "Dr. Smith", Especialidades = new List<Especialidad> { especialidad1 }, Rol = "Profesional" };
var usuario2 = new Usuario { Nombre = "Dra. Johnson", Especialidades = new List<Especialidad> { especialidad2 }, Rol = "Profesional" };

context.Usuario.AddRange(usuario1, usuario2);
context.SaveChanges();

// Agregar atenciones
var atencion1 = new Atencion { Mascota = mascota1, Usuario = usuario1 };
var atencion2 = new Atencion { Mascota = mascota2, Usuario = usuario2 };

context.Atencion.AddRange(atencion1, atencion2);
context.SaveChanges();











Console.WriteLine("Clientes:");
var clientes = context.Cliente.ToList();
foreach (var cliente in clientes)
{
    Console.WriteLine($"- Cliente: {cliente.Nombre}");
}

// Consultar y mostrar especies
Console.WriteLine("\nEspecies:");
var especies = context.Especie.ToList();
foreach (var especie in especies)
{
    Console.WriteLine($"- Especie: {especie.Nombre}");
}

// Consultar y mostrar razas
Console.WriteLine("\nRazas:");
var razas = context.Raza.ToList();
foreach (var raza in razas)
{
    Console.WriteLine($"- Raza: {raza.Nombre}");
}

// Consultar y mostrar mascotas
Console.WriteLine("\nMascotas:");
var mascotas = context.Mascota
    .Include(m => m.Raza)
    .Include(m => m.Especie)
    .Include(m => m.Cliente)
    .ToList();

foreach (var mascota in mascotas)
{
    Console.WriteLine($"- Mascota: {mascota.Nombre}, Especie: {mascota.Especie.Nombre}, Raza: {mascota.Raza.Nombre}, Propietario: {mascota.Cliente.Nombre}");
}

// Consultar y mostrar membresías
Console.WriteLine("\nMembresías:");
var membresias = context.Membresia.ToList();
foreach (var membresia in membresias)
{
    Console.WriteLine($"- Membresía: {membresia.Descripcion}");
}

// Consultar y mostrar precios de membresía
Console.WriteLine("\nPrecios de Membresía:");
var preciosMembresia = context.PrecioMembresia.Include(p => p.Membresia).ToList();
foreach (var precio in preciosMembresia)
{
    Console.WriteLine($"- Precio: {precio.Precio}, Membresía: {precio.Membresia.Descripcion}");
}

// Consultar y mostrar servicios
Console.WriteLine("\nServicios:");
var servicios = context.Servicio.ToList();
foreach (var servicio in servicios)
{
    Console.WriteLine($"- Servicio: {servicio.Nombre}");
}

// Consultar y mostrar precios de servicio
Console.WriteLine("\nPrecios de Servicio:");
var preciosServicio = context.PrecioServicio.Include(p => p.Servicio).ToList();
foreach (var precio in preciosServicio)
{
    Console.WriteLine($"- Precio: {precio.Precio}, Servicio: {precio.Servicio.Nombre}");
}

// Consultar y mostrar atenciones
Console.WriteLine("\nAtenciones:");
var atenciones = context.Atencion
    .Include(a => a.Mascota)
    .Include(a => a.Usuario)
    .ToList();

foreach (var atencion in atenciones)
{
    Console.WriteLine($"- Atención: {atencion.AtencionId}, Mascota: {atencion.Mascota.Nombre}, Profesional: {atencion.Usuario.Nombre}");
}














/*


var cliente = a.Cliente
    .Where(c => c.ClienteId == 1)
    .Include(cm => cm.ClienteMembresia)
        .ThenInclude(c => c.Membresia)
    .FirstOrDefault();

// Serializar a JSON
var options = new JsonSerializerOptions
{
    ReferenceHandler = ReferenceHandler.IgnoreCycles, // Evita ciclos de referencia
    WriteIndented = true // Para que el JSON sea legible
};

string json = JsonSerializer.Serialize(cliente, options);

// Imprimir en consola
Console.WriteLine(json);





*/

/*
 a.Cliente.Add(new Cliente
{
    Dni = 12345678,
    Nombre = "Juan",
    Apellido = "Perez",
    Mail = ""
});

a.Membresia.Add(new Membresia
{
    Descripcion = "Membresia 1",
    AntiguedadMinimaCliente = 1,
    PorcentajeDescuento = 10
});

a.SaveChanges();

a.ClienteMembresia.Add(new ClienteMembresia
{
    Cliente = a.Cliente.Find(1),
    Membresia = a.Membresia.Find(1),
    FechaDesde = new DateOnly(2021, 1, 1)
});

a.SaveChanges();




a.Cliente.Add(new Cliente
{
    Dni = 222,
    Nombre = "marcos",
    Apellido = "luhmann",
    Mail = ""
});

a.SaveChanges();

a.ClienteMembresia.Add(new ClienteMembresia
{
    Cliente = a.Cliente.Find(2),
    Membresia = a.Membresia.Find(1),
    FechaDesde = new DateOnly(2021, 1, 1)
});

a.SaveChanges();



var Cliente = a.Cliente.Include(cm => cm.ClienteMembresia)
        .ThenInclude(c => c.Membresia)
        .FirstOrDefault(); ;
 */


/*
context.InicializarBaseDatos();

var especie1 = new Especie {  Nombre = "Perro" };
var especie2 = new Especie {  Nombre = "Gato" };

context.Especie.AddRange(especie1, especie2);
context.SaveChanges();

// Agregar razas<
var raza1 = new Raza { Nombre = "Labrador" };
var raza2 = new Raza {  Nombre = "Persa" };

context.Raza.AddRange(raza1, raza2);
context.SaveChanges();

// Agregar clientes
var cliente1 = new Cliente {  Nombre = "Juan Pérez" };
var cliente2 = new Cliente {  Nombre = "Ana Gómez" };

context.Cliente.AddRange(cliente1, cliente2);
context.SaveChanges();

// Agregar membresías
var membresia1 = new Membresia {  Descripcion = "Básica" };
var membresia2 = new Membresia {  Descripcion = "Premium" };

context.Membresia.AddRange(membresia1, membresia2);
context.SaveChanges();

// Agregar precios de membresía
var precioMembresia1 = new PrecioMembresia {  Precio = 100, Membresia = membresia1 };
var precioMembresia2 = new PrecioMembresia {  Precio = 200, Membresia = membresia2 };

context.PrecioMembresia.AddRange(precioMembresia1, precioMembresia2);
context.SaveChanges();

// Agregar mascotas
var mascota1 = new Mascota {  Nombre = "Firulais", Cliente = cliente1, Raza = raza1, Especie = especie1 };
var mascota2 = new Mascota {  Nombre = "Mimi", Cliente = cliente2, Raza = raza2, Especie = especie2 };

context.Mascota.AddRange(mascota1, mascota2);
context.SaveChanges();

// Agregar servicios
var servicio1 = new Servicio {  Nombre = "Vacunación" };
var servicio2 = new Servicio {  Nombre = "Baño" };

context.Servicio.AddRange(servicio1, servicio2);
context.SaveChanges();

// Agregar precios de servicio
var precioServicio1 = new PrecioServicio {  Precio = 50, Servicio = servicio1 };
var precioServicio2 = new PrecioServicio {  Precio = 30, Servicio = servicio2 };

context.PrecioServicio.AddRange(precioServicio1, precioServicio2);
context.SaveChanges();

// Agregar especialidades
var especialidad1 = new Especialidad {  Nombre = "Veterinario General" };
var especialidad2 = new Especialidad {  Nombre = "Dermatología" };

context.Especialidad.AddRange(especialidad1, especialidad2);
context.SaveChanges();

// Agregar usuarios (profesionales)
var usuario1 = new Usuario {  Nombre = "Dr. Smith", Especialidades = new List<Especialidad> { especialidad1 }, Rol = "Profesional" };
var usuario2 = new Usuario {  Nombre = "Dra. Johnson", Especialidades = new List<Especialidad> { especialidad2 }, Rol = "Profesional" };

context.Usuario.AddRange(usuario1, usuario2);
context.SaveChanges();

// Agregar atenciones
var atencion1 = new Atencion {  Mascota = mascota1, Usuario = usuario1 };
var atencion2 = new Atencion {  Mascota = mascota2, Usuario = usuario2 };

context.Atencion.AddRange(atencion1, atencion2);
context.SaveChanges();


*/
