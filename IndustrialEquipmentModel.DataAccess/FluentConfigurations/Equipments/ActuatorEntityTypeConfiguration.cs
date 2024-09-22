using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IndustrialEquipmentModel.DataAccess.FluentConfigurations.Common;
using IndustrialEquipmentModel.Domain.Entities;
using IndustrialEquipmentModel.Domain.Entities.Equipments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialEquipmentModel.DataAccess.FluentConfigurations.Equipments
{
    public class ActuatorEntityTypeConfiguration : IEntityTypeConfiguration<Actuator>
    {
        public void Configure(EntityTypeBuilder<Actuator> builder)
        {
            builder.ToTable("Actuators");
            builder.HasBaseType(typeof(Equipment));
        }
    }
}
