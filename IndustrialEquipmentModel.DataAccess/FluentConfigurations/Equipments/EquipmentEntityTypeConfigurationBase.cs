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
    public class EquipmentEntityTypeConfigurationBase : EntityTypeConfigurationBase<Equipment>
    {
        public override void Configure(EntityTypeBuilder<Equipment> builder)
        {
            builder.ToTable("Equipment");
            base.Configure(builder);
            builder.HasOne(x => x.Module).WithMany(x => x.Equiments).HasForeignKey(x => x.ModuleId);
        }

    }
}
