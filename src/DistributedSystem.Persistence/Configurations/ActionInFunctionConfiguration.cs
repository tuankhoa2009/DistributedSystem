﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DistributedSystem.Domain.Entities.Identity;
using DistributedSystem.Persistence.Constants;


namespace DistributedSystem.Persistence.Configurations
{
    internal sealed class ActionInFunctionConfiguration : IEntityTypeConfiguration<ActionInFunction>
    {
        public void Configure(EntityTypeBuilder<ActionInFunction> builder)
        {
            builder.ToTable(TableNames.ActionInFunctions);

            builder.HasKey(x => new { x.ActionId, x.FunctionId });
        }
    }
}
