using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndustrialEquipmentModel.Domain.Entities.Equipments;

namespace IndustrialEquipmentModel.Domain.Entities
{

    /// <summary>
    /// Modela un módulo.
    /// </summary>
    public class Module : Entity
    {   
        #region Properties

        /// <summary>
        /// Nombre del módulo.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Indica si el módulo es externo o no a la unidad.
        /// </summary>
        public bool IsExternal { get; set; }

        //Relación del módulo con su unidad.
        public Unit Unit { get; set; }

        public Guid? UnitId { get; set; } 

        //Relación módulo-sensores/actuadores.
        public List<Equipment> Equiments { get; set; } 
  
        #endregion


        /// <summary>
        /// Requerido por EntityFrameworkCore para migraciones.
        /// </summary>
        protected Module() { }



        /// <summary>
        /// Incicializa un objeto <see cref="Module"/>.
        /// </summary>
        /// <param name="id">Identificador de la entidad.</param>
        /// <param name="name">Nombre del módulo.</param>
        public Module(Guid id, string name) : base(id)
        {
            Name = name;
            IsExternal = false;
        }
    }
}
