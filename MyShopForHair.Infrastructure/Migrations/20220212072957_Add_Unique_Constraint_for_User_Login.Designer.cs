﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyShopForHair.Infrastructure.Data;

namespace MyShopForHair.Infrastructure.Migrations
{
    [DbContext(typeof(CatalogDbContext))]
    [Migration("20220212072957_Add_Unique_Constraint_for_User_Login")]
    partial class Add_Unique_Constraint_for_User_Login
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyShopForHair.Core.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Davines"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Lador"
                        },
                        new
                        {
                            Id = 3,
                            Name = "CHI"
                        },
                        new
                        {
                            Id = 4,
                            Name = "TIGI"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Global Keratin"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Kerastase"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Loreal Professional"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Olaplex"
                        },
                        new
                        {
                            Id = 9,
                            Name = "ORIBE"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Matrix"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Rated Green"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Batiste"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Kapous"
                        },
                        new
                        {
                            Id = 14,
                            Name = "R+CO"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Moroccanoil"
                        });
                });

            modelBuilder.Entity("MyShopForHair.Core.Entities.Criteria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductsId");

                    b.ToTable("Criterias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Сухая"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Чувствительная"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Нормальная"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Жирная"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Комбинированная"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Окрашенные"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Поврежденные"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Ломкие"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Для блондинок"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Вьющиеся"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Пористые"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Сухие"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Жирные"
                        });
                });

            modelBuilder.Entity("MyShopForHair.Core.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CriteriaID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CriteriaID = 7,
                            Name = "Поврежденные и окрашенные волосы"
                        },
                        new
                        {
                            Id = 2,
                            CriteriaID = 10,
                            Name = "Вьющиеся волосы"
                        },
                        new
                        {
                            Id = 3,
                            CriteriaID = 12,
                            Name = "Сухие волосы"
                        },
                        new
                        {
                            Id = 4,
                            CriteriaID = 11,
                            Name = "Пористые волосы"
                        },
                        new
                        {
                            Id = 5,
                            CriteriaID = 13,
                            Name = "Жирные волосы"
                        },
                        new
                        {
                            Id = 6,
                            CriteriaID = 1,
                            Name = "Сухая кожа головы"
                        },
                        new
                        {
                            Id = 7,
                            CriteriaID = 2,
                            Name = "Чувствительная кожа головы"
                        },
                        new
                        {
                            Id = 8,
                            CriteriaID = 3,
                            Name = "Нормальная кожа головы"
                        },
                        new
                        {
                            Id = 9,
                            CriteriaID = 4,
                            Name = "Жирная кожа головы"
                        },
                        new
                        {
                            Id = 10,
                            CriteriaID = 5,
                            Name = "Комбинированная кожа головы"
                        });
                });

            modelBuilder.Entity("MyShopForHair.Core.Entities.Member", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("MyShopForHair.Core.Entities.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MyShopForHair.Core.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "manager"
                        },
                        new
                        {
                            Id = 3,
                            Name = "visitor"
                        });
                });

            modelBuilder.Entity("MyShopForHair.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nchar(128)")
                        .IsFixedLength(true);

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<int>("RolesId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("RolesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("RoleUser");
                });

            modelBuilder.Entity("MyShopForHair.Core.Entities.Criteria", b =>
                {
                    b.HasOne("MyShopForHair.Core.Entities.Products", null)
                        .WithMany("Criterias")
                        .HasForeignKey("ProductsId");
                });

            modelBuilder.Entity("MyShopForHair.Core.Entities.Member", b =>
                {
                    b.HasOne("MyShopForHair.Core.Entities.Role", "Role")
                        .WithMany("Members")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyShopForHair.Core.Entities.User", "User")
                        .WithMany("Members")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("MyShopForHair.Core.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyShopForHair.Core.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyShopForHair.Core.Entities.Products", b =>
                {
                    b.Navigation("Criterias");
                });

            modelBuilder.Entity("MyShopForHair.Core.Entities.Role", b =>
                {
                    b.Navigation("Members");
                });

            modelBuilder.Entity("MyShopForHair.Core.Entities.User", b =>
                {
                    b.Navigation("Members");
                });
#pragma warning restore 612, 618
        }
    }
}