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
    internal class MemberConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder
                .HasKey(p => new { p.UserId, p.RoleId });

            builder
                .HasOne(m => m.User)
                .WithMany(u => u.Members)
                .HasForeignKey(m => m.UserId);

            builder
                .HasOne(m => m.Role)
                .WithMany(r => r.Members)
                .HasForeignKey(m => m.RoleId);
        }
    }
}
