using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndustrialEquipmentModel.Domain.Entities.Equipments;

namespace IndustrialEquipmentModel.Contracts
{
    /// <summary>
    /// Describe las funcionalidades necesaria para dar persistencia a los equipos.
    /// </summary>s
    public interface IEquipmentRepository
    {
        /// <summary>
        /// Añade un equipo al soporte de datos.
        /// </summary>
        /// <param name="equipment">Equipo a añadir.</param>
        void AddEquipment(Equipment equipment);

        /// <summary>
        /// Obtiene un equipo del soporte de datos a partir de su identificador.
        /// </summary>
        /// <typeparam name="T">Tipo de equipo a obtener</typeparam>
        /// <param name="id">Identificador del equipo.</param>
        /// <returns>Equipo obtenido del soporte de datos; de no existir, <see langword="null"/>.</returns>
        T? GetEquipmentById<T>(Guid id) where T : Equipment;

        /// <summary>
        /// Obtiene todos los equipos del soporte de datos.
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAllEquipments<T>() where T : Equipment;

        /// <summary>
        /// Actualiza el valor de un equipo en el soporte de datos.
        /// </summary>
        /// <param name="equipment">Instancia con la información a actualizar del equipo.</param>
        void UpdateEquipment(Equipment equipment);

        /// <summary>
        /// Elimina un equipo del soporte de datos
        /// </summary>
        /// <param name="equipment">Equipo a eliminar.</param>
        void DeleteEquipment(Equipment equipment);
    }
}
