using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialEquipmentModel.Domain.Entities
{ 

    /// <summary>
    /// Modela una unidad.
    /// </summary>
    
    public class Unit : Entity
    {
        #region Properties

        /// <summary>
        /// Nombre de la unidad.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Código alfanumérico de la unidad.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Fabricante de la unidad.
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Fecha de puesta en marcha de la unidad.
        /// </summary>
        DateTime StartUp { get; set; }

        /// <summary>
        /// Relación unidad-módulos.
        /// </summary>
        public List<Module> Modules { get; set; }
        #endregion

        /// <summary>
        /// El código alfanumérico de la unidad debe ser de 6 caracteres.
        /// </summary>
        /// <param name="code">Código alfanumérico de la unidad.</param>
        public void ChangesCode(string code)
        {
            if (code.Length != 6)
                return;
            Code = code;
        }



        /// <summary>
        /// Requerido por EntityFrameworkCore para migraciones.
        /// </summary>
        protected Unit() { }



        /// <summary>
        /// Inicializa un objeto <see cref="Unit"/>.
        /// </summary>
        /// <param name="id">Identificador de la entidad.</param>
        /// <param name="name">Nombre de la unidad.</param>
        /// <param name="startUp">Fecha de puesta en marcha de la unidad.</param>
        public Unit(Guid id, string name, DateTime startUp) : base(id)
        {
            Name = name;
            StartUp = startUp;
            Brand = string.Empty;
            Code = "0";
        }

    }
}
