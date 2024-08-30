using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PadangResto.Services.CouponAPI.Models;

namespace PadangResto.Services.CouponAPI.Configurations
{
	public class CouponConfiguration : IEntityTypeConfiguration<Coupon>
	{
		public void Configure(EntityTypeBuilder<Coupon> builder)
		{
			builder.HasKey(c => c.CouponId);

			builder.Property(c => c.CouponCode)
				.IsRequired()
				.HasMaxLength(50);

			builder.Property(c => c.DiscountAmount)
				.IsRequired();
			
		}
	}
}
