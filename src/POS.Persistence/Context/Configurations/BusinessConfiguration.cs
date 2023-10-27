using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Persistence.Context.Configurations
{
    public class BusinessConfiguration : IEntityTypeConfiguration<Business>
    {
        public void Configure(EntityTypeBuilder<Business> builder)
        {
            builder.HasOne(b => b.District)
            .WithMany(d => d.Businesses)
            .HasForeignKey(b => b.DistrictId)
            .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
