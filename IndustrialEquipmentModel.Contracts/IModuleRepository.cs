using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndustrialEquipmentModel.Domain.Entities;

namespace IndustrialEquipmentModel.Contracts
{
    /// <summary>
    /// Describe las funcionalidades necesarias para dar persistencia a los módulos.
    /// </summary>
    public interface IModuleRepository
    {
        /// <summary>
        /// Añade un módulo al soporte de datos.
        /// </summary>
        /// <param name="module">Módulo a añadir.</param>
        void AddModule(Module module);

        /// <summary>
        /// Obtiene un módulo del soporte de datos a partir de su identificador.
        /// </summary>
        /// <param name="id">Identificador del módulo.</param>
        /// <returns>Módulo obtenido del soporte de datos; de no existir, <see langword="null"/>.</returns>
        Module? GetModuleById(Guid id);

        /// <summary>
        /// Obtiene todas los módulos del soporte de datos.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Module> GetAllModules();

        /// <summary>
        /// Actualiza el valor de un módulo en el soporte de datos.
        /// </summary>
        /// <param name="module">Instancia con la información a actualizar del módulo.</param>
        void UpdateModule(Module module);

        /// <summary>
        /// Elimina un módulo del soporte de datos.
        /// </summary>
        /// <param name="module">Módulo a eliminar.</param>
        void DeleteModule(Module module);
    }
}
