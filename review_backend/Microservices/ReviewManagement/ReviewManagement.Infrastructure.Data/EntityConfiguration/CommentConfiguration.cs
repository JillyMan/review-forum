using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.Data.EntityConfiguration
{
    public class CommentConfiguration : BaseConfiguration<Comment>
    {
        public override void Configure(EntityTypeBuilder<Comment> builder)
        {
            base.Configure(builder);

            builder.ToTable("comments");

            builder.HasAlternateKey(x => x.ThingId);
            builder.Property(e => e.ThingId)
                .HasColumnName("thing_id")
                .IsRequired();

            builder.HasOne(c => c.Thing)
                .WithMany(t => t.Comments)
                .HasForeignKey(c => c.ThingId)
                .HasConstraintName("FK_comments_things_thingId");

            builder.Property(e => e.UserId)
                .HasColumnName("user_id")
                .IsRequired();

            builder.Property(x => x.Text)
                .HasColumnName("text")
                .IsRequired();
        }
    }
}
