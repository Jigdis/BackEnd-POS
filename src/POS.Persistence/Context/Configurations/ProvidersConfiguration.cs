using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Persistence.Context.Configurations
{
    public class ProvidersConfiguration : IEntityTypeConfiguration<Providers>
    {
        public void Configure(EntityTypeBuilder<Providers> builder)
        {
            builder.HasOne(b => b.DocumentType)
            .WithMany(d => d.Providers)
            .HasForeignKey(b => b.DocumentTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
