using AutoMapper;
using PadangResto.Services.CouponAPI.Models;
using PadangResto.Services.CouponAPI.Models.Dto;

namespace PadangResto.Services.CouponAPI
{
	public class MappingConfig
	{
		public static MapperConfiguration RegisterMaps()
		{
			var mappingConfig = new MapperConfiguration(config =>
			{
				config.CreateMap<CouponDto, Coupon>();
				config.CreateMap<Coupon, CouponDto>();
			});
			return mappingConfig;
		}
	}
}
