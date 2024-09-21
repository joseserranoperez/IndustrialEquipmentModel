using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialEquipmentModel.Domain.Types
{
    /// <summary>
    /// Tipo de variable que mide un sensor.
    /// </summary>
    public enum Variable
    {  
        /// <summary>
        /// Temperatura como tipo de variable.
        /// </summary>
        Temperature,

        /// <summary>
        /// Flujo como tipo de variable.
        /// </summary>
        Flow,

        /// <summary>
        /// Conductividad como tipo de variable.
        /// </summary>
        Conductivity,

        /// <summary>
        /// pH como tipo de variable.
        /// </summary>
        PH,

        /// <summary>
        /// Presión como tipo de variable.
        /// </summary>
        Pressure
    }
}
