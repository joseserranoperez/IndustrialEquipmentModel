using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IndustrialEquipmentModel.DataAccess.FluentConfigurations.Common;
using IndustrialEquipmentModel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialEquipmentModel.DataAccess.FluentConfigurations
{
    public class ModuleEntityTypeConfiguration : EntityTypeConfigurationBase<Module>
    {
        public override void Configure(EntityTypeBuilder<Module> builder)
        {
            builder.ToTable("Modules");
            base.Configure(builder);
            builder.HasOne(x => x.Unit).WithMany(x => x.Modules).HasForeignKey(x => x.UnitId);
        }

    }


}

