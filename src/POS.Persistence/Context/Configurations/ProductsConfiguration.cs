using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Persistence.Context.Configurations
{
    public class ProductsConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasOne(b => b.Category)
            .WithMany(d => d.Products)
            .HasForeignKey(b => b.CategoryId)
            .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(b => b.Provider)
            .WithMany(d => d.Products)
            .HasForeignKey(b => b.ProviderId)
            .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
