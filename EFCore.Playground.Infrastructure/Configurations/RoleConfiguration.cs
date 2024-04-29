using EFCore.Playground.Domain.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Playground.Infrastructure.Configurations;

public sealed class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("roles");
        builder.HasKey(role => role.Id);
        builder.Property(role => role.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder.HasData(Role.GetValues());
    }
}