using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EFCore.Playground.Domain.Documents;
using EFCore.Playground.Domain.Shared;
using EFCore.Playground.Domain.Workspaces;

namespace EFCore.Playground.Infrastructure.Configurations;

internal sealed class DocumentConfiguration : IEntityTypeConfiguration<Document>
{
    public void Configure(EntityTypeBuilder<Document> builder)
    {
        builder.ToTable("documents");

        builder.HasKey(doc => doc.DocumentId);
        builder.Property(doc => doc.DocumentName)
            .HasConversion(docName => docName.Value, value => new Name(value))
            .HasMaxLength(250)
            .IsRequired();

        builder
            .HasOne<Workspace>()
            .WithMany()
            .HasForeignKey(x => x.WorkspaceId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}