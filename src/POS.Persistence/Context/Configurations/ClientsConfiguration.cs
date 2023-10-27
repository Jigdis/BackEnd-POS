using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Persistence.Context.Configurations
{
    public class ClientsConfiguration : IEntityTypeConfiguration<Clients>
    {
        public void Configure(EntityTypeBuilder<Clients> builder)
        {
            builder.HasOne(b => b.DocumentType)
            .WithMany(d => d.Clients)
            .HasForeignKey(b => b.DocumentTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
