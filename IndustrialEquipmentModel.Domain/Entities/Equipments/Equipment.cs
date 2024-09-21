using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialEquipmentModel.Domain.Entities.Equipments
{
    /// <summary>
    /// Modela un equipo (sensor/actuador).
    /// </summary>
    public abstract class Equipment : Entity
    {
        #region Properties

        /// <summary>
        /// Principio de funcionamiento del equipo.
        /// </summary>
        string WorkingPrinciple { get; set; }

        public Module Module{ get; set; }

        public Guid? ModuleId { get; set; }

        #endregion


        /// <summary>
        /// Requerido por EntityFrameworkCore para migraciones.
        /// </summary>
        protected Equipment() { }



        /// <summary>
        /// Inicializa un equipo <see cref="Equipment"/>.
        /// </summary>
        /// <param name="workingPrinciple">Principio de funcionamiento del equipo.</param>
        public Equipment(Guid id, string workingPrinciple) : base (id)
        {
            WorkingPrinciple = workingPrinciple;
        }
    }
}
