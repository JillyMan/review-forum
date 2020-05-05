using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.Data.EntityConfiguration
{
    public class ThingConfiguration : AuditableBaseConfiguration<Thing>
    {
        public override void Configure(EntityTypeBuilder<Thing> builder)
        {
            base.Configure(builder);

            builder.ToTable("things");

            builder.Property(t => t.Description)
                .HasColumnName("description")
                .HasMaxLength(2000)
                .IsRequired();

            builder.Property(t => t.CategoryId)
                .HasColumnName("category_id")
                .IsRequired();
        }
    }
}
