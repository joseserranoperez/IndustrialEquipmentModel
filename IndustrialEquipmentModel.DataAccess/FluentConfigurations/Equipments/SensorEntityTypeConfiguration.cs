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
    public class SensorEntityTypeConfiguration : IEntityTypeConfiguration<Sensor>
    {
        public void Configure(EntityTypeBuilder<Sensor> builder)
        {
            builder.ToTable("Sensors");
            builder.HasBaseType(typeof(Equipment));
        }
    }
}
