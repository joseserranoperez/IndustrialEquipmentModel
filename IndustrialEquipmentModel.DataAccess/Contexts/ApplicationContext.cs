using IndustrialEquipmentModel.DataAccess.FluentConfigurations;
using IndustrialEquipmentModel.DataAccess.FluentConfigurations.Equipments;
using IndustrialEquipmentModel.Domain.Entities;
using IndustrialEquipmentModel.Domain.Entities.Equipments;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialEquipmentModel.DataAccess.Contexts
{

    /// <summary>
    /// Define la estructura de la base de datos de la aplicación.
    /// </summary>
    public class ApplicationContext : DbContext
    {
        //Región destinada a la declaración de las tablas de las entidades base
        #region Tables

        /// <summary>
        /// Tabla de unidades.
        /// </summary>
        public DbSet<Unit> Units { get; set; }

        /// <summary>
        /// Tabla de módulos.
        /// </summary>
        public DbSet<Module> Modules { get; set; }

        /// <summary>
        /// Tabla de equipos (sensores y actuadores).
        /// </summary>
        public DbSet<Equipment> Equipments { get; set; }
        #endregion



        #region Helpers

        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqliteDbContextOptionsBuilderExtensions.UseSqlite(new DbContextOptionsBuilder(), connectionString).Options;
        }

        #endregion



        #region Constructores del contexto

        /// <summary>
        /// Requerido por EntityFrameworkCore para migraciones.
        /// </summary>
        public ApplicationContext()
        {
        }

        /// <summary>
        /// Inicializa un objeto <see cref="ApplicationContext"/>.
        /// </summary>
        /// <param name="connectionString">
        /// Cadena de conexión.
        /// </param>
        public ApplicationContext(string connectionString)
            : base(GetOptions(connectionString))
        {
        }

        /// <summary>
        /// Inicializa un objeto <see cref="ApplicationContext"/>.
        /// </summary>
        /// <param name="options">
        /// Opciones del contexto.
        /// </param>
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
        #endregion


        //Función a llamar cada vez que se cree un contexto. Define a Sqlite como RDBMS.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite();
        }


        //Función que es llamada cuando se define la estructura de la base de datos.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UnitEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ModuleEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EquipmentEntityTypeConfigurationBase());
            modelBuilder.ApplyConfiguration(new SensorEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ActuatorEntityTypeConfiguration());
        }


    }
}
