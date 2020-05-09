using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.Data.EntityConfiguration
{
	public class CountryConfiguration : IEntityTypeConfiguration<Country>
	{
		public void Configure(EntityTypeBuilder<Country> builder)
		{
			builder.ToTable("country");

			builder.HasKey(x => x.Id);

			builder.Property(x => x.Name)
				.HasColumnName("name")
				.HasMaxLength(50)
				.IsRequired();
		}
	}


}
