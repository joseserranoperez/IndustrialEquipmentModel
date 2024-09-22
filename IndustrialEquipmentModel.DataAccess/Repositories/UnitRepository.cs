using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndustrialEquipmentModel.Contracts;
using IndustrialEquipmentModel.DataAccess.Contexts;
using IndustrialEquipmentModel.DataAccess.Repositories.Common;
using IndustrialEquipmentModel.Domain.Entities;


namespace IndustrialEquipmentModel.DataAccess.Repositories
{
    /// <summary>
    /// Implementación del repositorio <see cref="IUnitRepository"/>.
    /// </summary>
    public class UnitRepository : RepositoryBase, IUnitRepository
    {
        public UnitRepository(ApplicationContext context) : base(context)
        {
        }

        public void AddUnit(Unit unit)
        {
            _context.Units.Add(unit);
        }

        public void DeleteUnit(Unit unit)
        {
            _context.Units.Remove(unit);
        }

        public IEnumerable<Unit> GetAllUnits()
        {
            return _context.Units.ToList();
        }

        public Unit? GetUnitById(Guid id)
        {
            return _context.Units.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateUnit(Unit unit)
        {
            _context.Units.Update(unit);
        }
    }
}
