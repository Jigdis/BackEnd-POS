using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Persistence.Context.Configurations
{
    public class DistrictsConfiguration : IEntityTypeConfiguration<Districts>
    {
        public void Configure(EntityTypeBuilder<Districts> builder)
        {
            builder.HasOne(b => b.Province)
            .WithMany(d => d.Districts)
            .HasForeignKey(b => b.ProvinceId)
            .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
