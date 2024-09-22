using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialEquipmentModel.Domain.Entities.Equipments
{
    /// <summary>
    /// Actuador.
    /// </summary>
    public class Actuator : Equipment
    {
        #region Properties
        /// <summary>
        /// Fabricante del actuador.
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Fecha del último mantenimiento del actuador.
        /// </summary>
        public DateTime LastMaintenance { get; set; }
        #endregion


        /// <summary>
        /// Requerido por EntityFrameworkCore para migraciones.
        /// </summary>
        protected Actuator() { }



        /// <summary>
        /// Inicializa un objeto <see cref="Actuator"/>.
        /// </summary>
        /// <param name="id">Identificador de la entidad.</param>
        /// <param name="workingPrinciple">Principio de funcionamiento del actuador.</param>
        /// <param name="module">Módulo al cual pertenece el actuador.</param>
        /// <param name="lastMaintenance">Fecha del último mantenimiento del actuador.</param>
        public Actuator(Guid id, string workingPrinciple, Module module, DateTime lastMaintenance) : base (id, workingPrinciple, module)
        {
            LastMaintenance = lastMaintenance;
            Brand = string.Empty;
        }
    }
}
