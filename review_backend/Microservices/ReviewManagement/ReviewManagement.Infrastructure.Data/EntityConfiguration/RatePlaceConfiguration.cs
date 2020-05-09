using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.Data.EntityConfiguration
{
	public class RatePlaceConfiguration : AuditableBaseConfiguration<PlaceRate>
	{
		public override void Configure(EntityTypeBuilder<PlaceRate> builder)
		{
			base.Configure(builder);

			builder.ToTable("rate_place");

			builder.Property(x => x.Rate)
				.HasColumnName("rate")
				.IsRequired();

			builder.Property(x => x.PlaceId)
				.HasColumnName("place_id")
				.IsRequired();

			builder.HasOne(x => x.Place)
				.WithMany(x => x.Rates)
				.HasForeignKey(x => x.PlaceId)
				.OnDelete(DeleteBehavior.SetNull);
		}
	}
}
