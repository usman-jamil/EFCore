﻿using EFCore.Playground.Domain.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Playground.Infrastructure.Configurations;

internal sealed class UserGroupConfiguration : IEntityTypeConfiguration<UserGroup>
{
    public void Configure(EntityTypeBuilder<UserGroup> builder)
    {
        builder.ToTable("user_group");

        builder.HasKey(userGroup => new { userGroup.UserId, userGroup.GroupId });
    }
}
