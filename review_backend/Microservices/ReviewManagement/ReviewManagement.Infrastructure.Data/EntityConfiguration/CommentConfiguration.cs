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

            builder.HasOne(c => c.Thing)
                .WithMany(t => t.Comments)
                .HasForeignKey(c => c.Id);

            builder.Property(x => x.Text)
                .HasColumnName("text");
        }
    }
}
