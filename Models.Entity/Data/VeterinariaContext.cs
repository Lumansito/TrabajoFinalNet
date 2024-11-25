using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entity.Models;
using Microsoft.Extensions.Configuration;


namespace Models.Entity.Data
{
    public class VeterinariaContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Membresia> Membresia { get; set; }
        public DbSet<ClienteMembresia> ClienteMembresia { get; set; }
        public DbSet<PrecioMembresia> PrecioMembresia { get; set; }
        public DbSet<Mascota> Mascota { get; set; }
        public DbSet<Raza> Raza { get; set; }
        public DbSet<Especie> Especie { get; set; }
        public DbSet<Atencion> Atencion { get; set; }
        public DbSet<Servicio> Servicio { get; set; }
        public DbSet<PrecioServicio> PrecioServicio { get; set; }
        public DbSet<Especialidad> Especialidad { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Jornada> Jornada { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Cliente

            modelBuilder.Entity<Cliente>()
                .HasKey(a => new { a.ClienteId });  // Clave primaria

            modelBuilder.Entity<Cliente>()
                .HasMany(m => m.Mascotas)
                .WithOne(c => c.Cliente)
                .HasForeignKey(m => m.ClienteId);

            #endregion

            #region Membresia

            modelBuilder.Entity<Membresia>()
                .HasKey(a => new { a.MembresiaId });  // Clave primaria

            modelBuilder.Entity<Membresia>()
                .HasMany(m => m.Precios)
                .WithOne(p => p.Membresia)
                .HasForeignKey(m => m.MembresiaId);


            modelBuilder.Entity<PrecioMembresia>()
                .HasKey(a => new { a.PrecioMembresiaId });  // Clave primaria

            #endregion

            #region Mascota

            modelBuilder.Entity<Mascota>()
                .HasKey(a => new { a.MascotaId });  // Clave primaria

            modelBuilder.Entity<Mascota>()
                .HasOne(m => m.Cliente)
                .WithMany(c => c.Mascotas)
                .HasForeignKey(m => m.ClienteId);

            modelBuilder.Entity<Mascota>()
                .HasOne(m => m.Raza)
                .WithMany(r => r.Mascotas)
                .HasForeignKey(m => m.RazaId);

            modelBuilder.Entity<Mascota>()
                .HasOne(m => m.Especie)
                .WithMany(e => e.Mascotas)
                .HasForeignKey(m => m.EspecieId);

            modelBuilder.Entity<Mascota>()
                .HasMany(m => m.Atenciones)
                .WithOne(a => a.Mascota)
                .HasForeignKey(m => m.MascotaId);

            #endregion

            #region Raza

            modelBuilder.Entity<Raza>()
                .HasKey(a => new { a.RazaId });

            #endregion

            #region Especie
            modelBuilder.Entity<Especie>()
                .HasKey(a => new { a.EspecieId });

            #endregion

            #region Atención
            modelBuilder.Entity<Atencion>()
                .HasKey(a => new { a.AtencionId });

            modelBuilder.Entity<Atencion>()
                .HasMany(s => s.Servicios)
                .WithMany(a => a.Atenciones)
                .UsingEntity(j => j.ToTable("AtencionServicio"));

            modelBuilder.Entity<Atencion>()
                .HasOne(u => u.Usuario)
                .WithMany(a => a.Atenciones)
                .HasForeignKey(u => u.UsuarioId);

            


            #endregion

            #region Servicio

            modelBuilder.Entity<Servicio>()
                .HasKey(a => new { a.ServicioId });

            modelBuilder.Entity<Servicio>()
                .HasMany(p => p.Precios)
                .WithOne(s => s.Servicio)
                .HasForeignKey(p => p.ServicioId);

            modelBuilder.Entity<Servicio>()
                .HasMany(e => e.Especialidades)
                .WithMany(s => s.Servicios)
                .UsingEntity(j => j.ToTable("ServicioEspecialidad"));

            modelBuilder.Entity<PrecioServicio>()
                .HasKey(a => new { a.PrecioServicioId });


            #endregion

            #region Especialidad

            modelBuilder.Entity<Especialidad>()
                .HasKey(a => new { a.EspecialidadId });

            #endregion

            #region ClienteMembresia

            // Configurar la relación muchos a muchos con la entidad intermedia
            modelBuilder.Entity<ClienteMembresia>()
                .HasKey(a => new { a.ClienteMembresiaId });  // Clave primaria compuesta
                                                             //Opatamos por id unico
            modelBuilder.Entity<ClienteMembresia>()
                .HasOne(a => a.Cliente)
                .WithMany(a => a.ClienteMembresia)
                .HasForeignKey(a => a.ClienteId);

            modelBuilder.Entity<ClienteMembresia>()
                .HasOne(a => a.Membresia)
                .WithMany(s => s.ClienteMembresia)
                .HasForeignKey(a => a.MembresiaId);

            #endregion

            #region Usuario

            modelBuilder.Entity<Usuario>()
                .HasKey(a => new { a.UsuarioId });

            modelBuilder.Entity<Usuario>()
                .HasMany(a => a.Especialidades)
                .WithMany(e => e.Usuarios)
                .UsingEntity(j => j.ToTable("UsuarioEspecialidad"));

            modelBuilder.Entity<Usuario>()
                .HasMany(a => a.Jornadas)
                .WithMany(a => a.Usuarios)
                .UsingEntity(j => j.ToTable("UsuarioJornada"));

            #endregion

            #region Jornada
            modelBuilder.Entity<Jornada>()
                .HasKey(a => new { a.JornadaId });

            #endregion

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                                    .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("ThirdConnection"))
                              .EnableSensitiveDataLogging();  // Para ver detalles de errores
            }
        }

        public void InicializarBaseDatos()
        {
            this.Database.EnsureCreated();
        }

        public VeterinariaContext()
            { }


        public VeterinariaContext(DbContextOptions<VeterinariaContext> options)
        : base(options)
        {
        }
    }
}
