using EFCore.Playground.Domain.ACLs;
using EFCore.Playground.Domain.Groups;
using EFCore.Playground.Domain.Shared;
using EFCore.Playground.Domain.Workspaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Playground.Infrastructure.Configurations;

internal sealed class AclConfiguration : IEntityTypeConfiguration<Acl>
{
    public void Configure(EntityTypeBuilder<Acl> builder)
    {
        builder.ToTable("acls");

        builder.HasKey(acl => new { acl.GroupId, acl.WorkspaceId, acl.RoleId });

        builder
            .HasOne<Workspace>()
            .WithMany()
            .HasForeignKey(x => x.WorkspaceId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne<Group>()
            .WithMany()
            .HasForeignKey(x => x.GroupId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne<Role>()
            .WithMany()
            .HasForeignKey(x => x.RoleId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}