using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.Data.EntityConfiguration
{
	public class AddressConfiguration : IEntityTypeConfiguration<Address>
	{
		public void Configure(EntityTypeBuilder<Address> builder)
		{
			builder.ToTable("address");

			builder.HasKey(x => x.Id);

			builder.Property(x => x.Street)
				.IsRequired()
                .HasColumnName("street");

			builder.Property(x => x.Latitude)
				.IsRequired()
				.HasColumnName("latitude");

			builder.Property(x => x.Longitude)
				.IsRequired()
				.HasColumnName("longitude");

			builder.Property(x => x.Street)
				.IsRequired()
				.HasColumnName("street");

			builder.Property(x => x.CountryId)
				.IsRequired()
				.HasColumnName("country_id");

			builder.Property(x => x.CityId)
				.IsRequired()
				.HasColumnName("city_id");

			builder.HasOne(x => x.Country)
				.WithMany()
				.HasForeignKey(x => x.CountryId)
				.OnDelete(DeleteBehavior.SetNull);

			builder.HasOne(x => x.City)
				.WithMany()
				.HasForeignKey(x => x.CityId)
				.OnDelete(DeleteBehavior.SetNull);
		}
	}
}
