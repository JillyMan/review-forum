using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.Data.EntityConfiguration
{
	public class PlaceConfiguration : AuditableBaseConfiguration<Place>
	{
		public override void Configure(EntityTypeBuilder<Place> builder)
		{
			base.Configure(builder);

			builder.Property(x => x.Name)
				.HasColumnName("name")
				.IsRequired();

			builder.Property(x => x.Rate)
				.HasColumnName("rate")
				.IsRequired();

			builder.Property(x => x.PhoneNumber)
				.HasColumnName("phone_number")
				.IsRequired();

			builder.Property(x => x.CategoryId)
				.HasColumnName("category_id")
				.IsRequired();

			builder.HasOne(x => x.Category)
				.WithMany()
				.HasForeignKey(x => x.CategoryId)
				.OnDelete(DeleteBehavior.SetNull);

			builder.Property(x => x.AddressId)
				.HasColumnName("address_id")
				.IsRequired();

			builder.HasOne(x => x.Address)
				.WithMany(x => x.Places)
				.HasForeignKey(x => x.AddressId)
				.OnDelete(DeleteBehavior.SetNull);

			builder.Property(x => x.ImageId)
				.HasColumnName("image_id");

			builder.HasOne(x => x.Image)
				.WithMany()
				.HasForeignKey(x => x.ImageId)
				.OnDelete(DeleteBehavior.SetNull);

			//builder.HasMany(x => x.HeaderImages)
			//	.WithOne()
			//	.OnDelete(x => x.;
		}
	}
}
