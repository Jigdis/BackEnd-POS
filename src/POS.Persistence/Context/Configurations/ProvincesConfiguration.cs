using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Persistence.Context.Configurations
{
    public class ProvincesConfiguration : IEntityTypeConfiguration<Provinces>
    {
        public void Configure(EntityTypeBuilder<Provinces> builder)
        {
            builder.HasOne(b => b.Department)
            .WithMany(d => d.Provinces)
            .HasForeignKey(b => b.DepartmentId)
            .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
