using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndustrialEquipmentModel.Contracts;
using IndustrialEquipmentModel.DataAccess.Contexts;
using IndustrialEquipmentModel.DataAccess.Repositories.Common;
using IndustrialEquipmentModel.Domain.Entities.Equipments;

namespace IndustrialEquipmentModel.DataAccess.Repositories
{
    /// <summary>
    /// Implementación del repositorio <see cref="IEquipmentRepository"/>.
    /// </summary>
    public class EquipmentRepository : RepositoryBase, IEquipmentRepository
    {
        public EquipmentRepository(ApplicationContext context) : base(context)
        {
        }

        public void AddEquipment(Equipment equipment)
        {
            _context.Equipments.Add(equipment);
        }

        public void DeleteEquipment(Equipment equipment)
        {
            _context.Equipments.Remove(equipment);
        }

        public IEnumerable<T> GetAllEquipments<T>() where T : Equipment
        {
            return _context.Set<T>().ToList();
        }

        public T? GetEquipmentById<T>(Guid id) where T : Equipment
        {
            return _context.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public void UpdateEquipment(Equipment equipment)
        {
            _context.Equipments.Update(equipment);
        }
    }
}
