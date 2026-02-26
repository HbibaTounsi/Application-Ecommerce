using Application_Ecommerce.App.Coupons.Dtos;
using Application_Ecommerce.Core.Entities.Coupon;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ecommerce.App.Coupons.Mapping
{
    public class CouponProfile : Profile
    {
        public CouponProfile() {

            CreateMap<Coupon, CouponDto>();
            CreateMap<CouponDto, Coupon>();

            //create update
            CreateMap<CreateCouponDto, Coupon>();
            CreateMap<UpdateCouponDto, Coupon>();
        }
    }
}
