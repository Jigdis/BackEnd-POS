using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Persistence.Context.Configurations
{
    public class BranchOfficeConfiguration : IEntityTypeConfiguration<BranchOffice>
    {
        public void Configure(EntityTypeBuilder<BranchOffice> builder)
        {
            builder.HasOne(b => b.Business)
           .WithMany(d => d.BranchOffices)
           .HasForeignKey(b => b.BusinessId)
           .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(b => b.District)
            .WithMany(d => d.BranchOffices)
            .HasForeignKey(b => b.DistrictId)
            .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
