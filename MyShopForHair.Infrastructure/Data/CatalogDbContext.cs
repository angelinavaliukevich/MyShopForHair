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
            modelBuilder.Entity<Brand>().HasData(
                new Brand { Id = 1, Name = "Davines" },
                new Brand { Id = 2, Name = "Lador" },
                new Brand { Id = 3, Name = "CHI" },
                new Brand { Id = 4, Name = "TIGI" },
                new Brand { Id = 5, Name = "Global Keratin" },
                new Brand { Id = 6, Name = "Kerastase" },
                new Brand { Id = 7, Name = "Loreal" },
                new Brand { Id = 8, Name = "Olaplex" },
                new Brand { Id = 9, Name = "ORIBE" },
                new Brand { Id = 10, Name = "Matrix" },
                new Brand { Id = 11, Name = "Ollin" },
                new Brand { Id = 12, Name = "Batiste" },
                new Brand { Id = 13, Name = "Kapous" },
                new Brand { Id = 14, Name = "K18" },
                new Brand { Id = 15, Name = "Moroccanoil" }
                );
        }
    }
}
