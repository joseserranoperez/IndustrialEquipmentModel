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
    public class  UnitEntityTypeConfiguration : EntityTypeConfigurationBase<Unit>
    {
        public override void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.ToTable("Unities");
            base.Configure(builder);
        }

    }

}
