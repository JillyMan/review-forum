using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.Data.EntityConfiguration
{
	public class CityConfiguration : IEntityTypeConfiguration<City>
	{
		public void Configure(EntityTypeBuilder<City> builder)
		{
			builder.ToTable("city");

			builder.HasKey(x => x.Id);

			builder.Property(x => x.Name)
				.HasColumnName("name")
				.HasMaxLength(50)
				.IsRequired();
		}
	}
}
