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
    internal class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder
            .HasKey(p => p.Id);

            builder
            .Property(p => p.Name)
            .HasMaxLength(50)
            .IsRequired();

        
        }
    }
}
