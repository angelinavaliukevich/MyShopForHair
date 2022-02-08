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
    internal class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Name)
                .HasMaxLength(32)
                .IsFixedLength()
                .IsRequired();

            builder
                .Property(x => x.Extension)
                .HasMaxLength(5)
                .IsRequired();

            builder
                .Ignore(x => x.Stream);

            builder
                .Ignore(x => x.IsNew);
        }


    }
}