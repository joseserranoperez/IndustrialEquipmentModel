using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndustrialEquipmentModel.Domain.Types;

namespace IndustrialEquipmentModel.Domain.Entities.Equipments
{
    /// <summary>
    /// Sensor.
    /// </summary>
    public class Sensor : Equipment
    {
        #region Properties

        /// <summary>
        /// Código alfanumérico del sensor.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Fecha de la última calibración del sensor.
        /// </summary>
        public DateTime LastCalibration { get; set; }

        /// <summary>
        /// Variable que mide el sensor.
        /// </summary>
        public Variable Variable { get; set; }
        #endregion


        /// <summary>
        /// Requerido por EntityFrameworkCore para migraciones.
        /// </summary>
        protected Sensor() { }



        /// <summary>
        /// El código alfanumérico del sensor debe ser de 6 caracteres.
        /// </summary>
        /// <param name="code">Código alfanumérico del sensor.</param>
        public void ChangesCode(string code)
        {
            if (code.Length != 6)
                return;
            Code = code;
        }



        /// <summary>
        /// Inicializa un objeto <see cref="Sensor"/>.
        /// </summary>
        /// <param name="id">Identificador de la entidad.</param>
        /// <param name="workingPrinciple">Principio de funcionamiento del sensor.</param>
        /// <param name="module">Módulo al cual pertenece el actuador.</param>
        /// <param name="lastCalibration">Fecha de la última calibración del sensor.</param>
        /// <param name="variable">Variable que mide el sensor.</param>
        public Sensor(Guid id, string workingPrinciple, Module module, DateTime lastCalibration, Variable variable) : base (id, workingPrinciple, module)
        {
            LastCalibration = lastCalibration;
            Variable = variable;
            Code = "0";
            
        }
    }
}
