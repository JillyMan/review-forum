using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.Data.EntityConfiguration
{
    public class CommentConfiguration : AuditableBaseConfiguration<Comment>
    {
        public override void Configure(EntityTypeBuilder<Comment> builder)
        {
            base.Configure(builder);

            builder.ToTable("comments");

            builder.Property(x => x.PlaceId)
                .HasColumnName("place_id")
                .IsRequired();

            builder.HasOne(c => c.Place)
                .WithMany(t => t.Comments)
                .HasForeignKey(c => c.PlaceId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Property(x => x.Text)
                .HasColumnName("text")
                .IsRequired();
        }
    }
}
