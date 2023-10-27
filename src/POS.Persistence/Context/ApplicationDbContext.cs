using Microsoft.EntityFrameworkCore;
using POS.Domain.Entities;
using System.Data.Common;
using System.Reflection;

namespace POS.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbConnection CreateConnection => Database.GetDbConnection();

        #region ENTITIES
        public virtual DbSet<BranchOffice> BranchOffice { get; set; }
        public virtual DbSet<Business> Business { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Districts> Districts { get; set; }
        public virtual DbSet<DocumentTypes> DocumentTypes { get; set; }
        public virtual DbSet<MenuRoles> MenuRoles { get; set; }
        public virtual DbSet<Menus> Menus { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Providers> Providers { get; set; }
        public virtual DbSet<Provinces> Provinces { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
