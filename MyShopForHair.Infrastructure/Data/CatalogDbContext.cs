using Microsoft.EntityFrameworkCore;
using MyShopForHair.Core.Entities;
using MyShopForHair.Infrastructure.Data.Configuration;

namespace MyShopForHair.Infrastructure.Data
{
    public class CatalogDbContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Criteria> Criterias { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Group> Groups { get; set; }

        public CatalogDbContext(DbContextOptions<CatalogDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new RoleConfiguration().Configure(modelBuilder.Entity<Role>());
            new MemberConfiguration().Configure(modelBuilder.Entity<Member>());
            new UserConfiguration().Configure(modelBuilder.Entity<User>());
            new ProductsConfiguration().Configure(modelBuilder.Entity<Products>());
            new CriteriaConfiguration().Configure(modelBuilder.Entity<Criteria>());
            new BrandConfiguration().Configure(modelBuilder.Entity<Brand>());
            new GroupConfiguration().Configure(modelBuilder.Entity<Group>());

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "admin" },
                new Role { Id = 2, Name = "manager" },
                new Role { Id = 3, Name = "visitor" }
            );

            modelBuilder.Entity<Brand>().HasData(
                new Brand { Id = 1, Name = "Davines" },
                new Brand { Id = 2, Name = "Lador" },
                new Brand { Id = 3, Name = "CHI" },
                new Brand { Id = 4, Name = "TIGI" },
                new Brand { Id = 5, Name = "Global Keratin" },
                new Brand { Id = 6, Name = "Kerastase" },
                new Brand { Id = 7, Name = "Loreal Professional" },
                new Brand { Id = 8, Name = "Olaplex" },
                new Brand { Id = 9, Name = "ORIBE" },
                new Brand { Id = 10, Name = "Matrix" },
                new Brand { Id = 11, Name = "Rated Green" },
                new Brand { Id = 12, Name = "Batiste" },
                new Brand { Id = 13, Name = "Kapous" },
                new Brand { Id = 14, Name = "R+CO" },
                new Brand { Id = 15, Name = "Moroccanoil" }
                );
            modelBuilder.Entity<Group>().HasData(
            // волосы
            new Group { Id = 1, Name = "Поврежденные и окрашенные волосы", CriteriaID = 7 },
            new Group { Id = 2, Name = "Вьющиеся волосы", CriteriaID = 10 },
            new Group { Id = 3, Name = "Сухие волосы", CriteriaID = 12 },
            new Group { Id = 4, Name = "Пористые волосы", CriteriaID = 11 },
            new Group { Id = 5, Name = "Жирные волосы", CriteriaID = 13 },
            // голова
            new Group { Id = 6, Name = "Сухая кожа головы", CriteriaID = 1 },
            new Group { Id = 7, Name = "Чувствительная кожа головы", CriteriaID = 2 },
            new Group { Id = 8, Name = "Нормальная кожа головы", CriteriaID = 3 },
            new Group { Id = 9, Name = "Жирная кожа головы", CriteriaID = 4 },
            new Group { Id = 10, Name = "Комбинированная кожа головы", CriteriaID = 5 }
               );
            modelBuilder.Entity<Criteria>().HasData(
            //тип кожи головы
            new Criteria { Id = 1, Name = "Сухая" },
            new Criteria { Id = 2, Name = "Чувствительная" },
            new Criteria { Id = 3, Name = "Нормальная" },
            new Criteria { Id = 4, Name = "Жирная" },
            new Criteria { Id = 5, Name = "Комбинированная" },
            // тип волос
            new Criteria { Id = 6, Name = "Окрашенные" },
            new Criteria { Id = 7, Name = "Поврежденные" },
            new Criteria { Id = 8, Name = "Ломкие" },
            new Criteria { Id = 9, Name = "Для блондинок" },
            new Criteria { Id = 10, Name = "Вьющиеся" },
            new Criteria { Id = 11, Name = "Пористые" },
            new Criteria { Id = 12, Name = "Сухие" },
            new Criteria { Id = 13, Name = "Жирные" }
            );
        }
    }
}
