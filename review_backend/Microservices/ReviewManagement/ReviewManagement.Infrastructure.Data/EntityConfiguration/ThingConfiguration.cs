using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.Data.EntityConfiguration
{
    public class ThingConfiguration : BaseConfiguration<Thing>
    {
        public override void Configure(EntityTypeBuilder<Thing> builder)
        {
            base.Configure(builder);

            builder.ToTable("things");

            builder.Property(t => t.Rate)
                .HasColumnName("rate")
                .HasDefaultValue(0);

            builder.Property(t => t.Description)
                .HasColumnName("description")
                // todo: can be deleted in future
                .HasMaxLength(2000);

            builder.Property(t => t.CategoryId)
                .HasColumnName("category_id");

            builder.HasMany(t => t.Comments)
                .WithOne(c => c.Thing)
                .HasForeignKey(c => c.Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
