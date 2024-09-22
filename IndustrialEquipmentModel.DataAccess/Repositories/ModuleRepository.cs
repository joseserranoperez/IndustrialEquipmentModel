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
    /// Implementación del repositorio <see cref="IModuleRepository"/>.
    /// </summary>
    public class ModuleRepository : RepositoryBase, IModuleRepository
    {
        public ModuleRepository(ApplicationContext context) : base(context)
        {
        }

        public void AddModule(Module module)
        {
            _context.Modules.Add(module);
        }

        public void DeleteModule(Module module)
        {
            _context.Modules.Remove(module);
        }

        public IEnumerable<Module> GetAllModules()
        {
            return _context.Modules.ToList();
        }

        public Module? GetModuleById(Guid id)
        {
            return _context.Modules.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateModule(Module module)
        {
            _context.Modules.Update(module);
        }
    }
}
