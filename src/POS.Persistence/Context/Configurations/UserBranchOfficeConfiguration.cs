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
    public class UserBranchOfficeConfiguration : IEntityTypeConfiguration<UserBranchOffice>
    {
        public void Configure(EntityTypeBuilder<UserBranchOffice> builder)
        {
            builder.HasOne(b => b.User)
            .WithMany(d => d.UserBranchOffices)
            .HasForeignKey(b => b.UserId)
            .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
