using Microsoft.EntityFrameworkCore;
using MyShopForHair.Core.Entities;
using MyShopForHair.Infrastructure.Data.Configuration;

namespace MyShopForHair.Infrastructure.Data
{
    public class CatalogDbContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Criteria> Criterias { get; set; }
        public DbSet<Products> Products { get; set; }

        public CatalogDbContext(DbContextOptions<CatalogDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new RoleConfiguration().Configure(modelBuilder.Entity<Role>());
            new UserConfiguration().Configure(modelBuilder.Entity<User>());
            new ProductsConfiguration().Configure(modelBuilder.Entity<Products>());
            new CriteriaConfiguration().Configure(modelBuilder.Entity<Criteria>());
            new BrandConfiguration().Configure(modelBuilder.Entity<Brand>());
        }

    }
}
