using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.Data.EntityConfiguration
{
	public class RateDishConfiguration : AuditableBaseConfiguration<DishRate>
	{
		public override void Configure(EntityTypeBuilder<DishRate> builder)
		{
			base.Configure(builder);

			builder.ToTable("rate_dish");

			builder.Property(x => x.Rate)
				.HasColumnName("rate")
				.IsRequired();

			builder.Property(x => x.DishId)
				.HasColumnName("dish_id")
				.IsRequired();

			builder.HasOne(x => x.Dish)
				.WithMany(x => x.Rates)
				.HasForeignKey(x => x.DishId)
				.OnDelete(DeleteBehavior.SetNull);
		}
	}
}