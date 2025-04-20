﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DistributedSystem.Domain.Entities.Identity;
using DistributedSystem.Persistence.Constants;

namespace DistributedSystem.Persistence.Configurations
{
    internal sealed class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.ToTable(TableNames.Permissions);

            builder.HasKey(x => new { x.RoleId, x.FunctionId, x.ActionId });
        }
    }
}
