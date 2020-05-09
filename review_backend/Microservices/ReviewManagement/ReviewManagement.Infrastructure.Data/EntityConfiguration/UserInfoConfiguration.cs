using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReviewManagement.Domain.Entities;
using ReviewManagement.Domain.Enums;
using System;

namespace ReviewManagement.Data.EntityConfiguration
{
	public class UserInfoConfiguration : IEntityTypeConfiguration<UserInfo>
	{
		public void Configure(EntityTypeBuilder<UserInfo> builder)
		{
			builder.ToTable("users");

			builder.HasKey(x => x.Id);

			builder.Property(e => e.CreatedAt)
				.HasColumnName("created_at")
				.HasColumnType("datetime")
				.IsRequired();

			builder.Property(e => e.UpdatedAt)
				.HasColumnName("updated_at")
				.HasColumnType("datetime")
				.IsRequired();

			builder.Property(x => x.Role)
				.HasConversion(
					v => v.ToString(),
					v => (Role)Enum.Parse(typeof(Role), v));

			builder.Property(x => x.FirstName)
				.HasColumnName("first_name")
				.IsRequired();

			builder.Property(x => x.LastName)
				.HasColumnName("last_name")
				.IsRequired();

			builder.Property(x => x.IsActive)
				.IsRequired()
				.HasDefaultValue(false)
				.HasColumnName("is_active");
		}
	}
}
