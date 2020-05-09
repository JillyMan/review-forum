using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.Data.EntityConfiguration
{
	public class ImageConfiguration : IEntityTypeConfiguration<Image>
	{
		public void Configure(EntityTypeBuilder<Image> builder)
		{
			builder.ToTable("image");

			builder.HasKey(x => x.Id);

			builder.Property(x => x.ImageUrl)
				.HasColumnName("url");
		}
	}
}
