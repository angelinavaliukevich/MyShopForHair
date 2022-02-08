using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShopForHair.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopForHair.Infrastructure.Data.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
            .HasKey(p => p.Id);

            builder
            .Property(p => p.Name)
            .HasMaxLength(50)
            .IsRequired();

            builder
            .Property(p => p.Login)
            .HasMaxLength(50)
            .IsRequired();

            builder
            .Property(p => p.Password)
            .HasMaxLength(128)
            .IsFixedLength()
            .IsRequired();

           /* builder
                .Property(p => p.Salt)
                .HasMaxLength(128)
                .IsFixedLength()
                .IsRequired();*/
        }
    }
}