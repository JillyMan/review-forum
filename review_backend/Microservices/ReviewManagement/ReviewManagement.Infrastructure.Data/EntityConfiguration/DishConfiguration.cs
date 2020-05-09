using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReviewManagement.Domain.Entities;
using System;

namespace ReviewManagement.Data.EntityConfiguration
{
	public class DishConfiguration : IEntityTypeConfiguration<Dish>
	{
		public void Configure(EntityTypeBuilder<Dish> builder)
		{
			builder.ToTable("dish");

			builder.HasKey(x => x.Id);

			builder.Property(x => x.Name)
				.HasColumnName("name")
				.IsRequired();

			builder.Property(x => x.Rate)
				.HasColumnName("rate")
				.HasDefaultValue(0.0f);

			builder.Property(x => x.Price)
				.HasColumnName("price")
				.IsRequired();

			builder.Property(x => x.ImageId)
				.HasColumnName("image_id");

			builder.HasOne(x => x.Image)
				.WithMany()
				.HasForeignKey(x => x.ImageId)
				.OnDelete(DeleteBehavior.SetNull);

			builder.Property(x => x.PlaceId)
				.HasColumnName("place_id")
				.IsRequired();

			builder.HasOne(x => x.Place)
				.WithMany(x => x.Dishes)
				.HasForeignKey(x => x.PlaceId)
				.OnDelete(DeleteBehavior.SetNull);			
		}
	}
}
