using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReviewManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewManagement.Data.EntityConfiguration
{
    public class ThingRateInfoConfiguration : BaseConfiguration<ThingRateInfo>
    {
        public override void Configure(EntityTypeBuilder<ThingRateInfo> builder)
        {
            base.Configure(builder);

            builder.ToTable("thing_rate_info");

            builder.Property(e => e.Rate)
                .HasColumnName("rate")
                .IsRequired();

            builder.Property(e => e.UserId)
                .HasColumnName("user_id")
                .IsRequired();

            builder.HasAlternateKey(e => e.ThingId);
            builder.Property(e => e.ThingId)
                .HasColumnName("thing_id")
                .IsRequired();

            //builder.HasOne(t => t.Thing)
            //    .WithMany(r => r.Rates)
            //    .HasForeignKey(r => r.ThingId)
            //    .OnDelete(DeleteBehavior.Cascade)
            //    .HasConstraintName("FK_thing_rate_info_thing_id");
        }
    }
}
