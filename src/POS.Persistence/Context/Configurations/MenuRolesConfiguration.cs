using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Persistence.Context.Configurations
{
    public class MenuRolesConfiguration : IEntityTypeConfiguration<MenuRoles>
    {
        public void Configure(EntityTypeBuilder<MenuRoles> builder)
        {
            builder.HasOne(b => b.Menu)
           .WithMany(d => d.MenuRoles)
           .HasForeignKey(b => b.MenuId)
           .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(b => b.Role)
           .WithMany(d => d.MenuRoles)
           .HasForeignKey(b => b.RoleId)
           .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
