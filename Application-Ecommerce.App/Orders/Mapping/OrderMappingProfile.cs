using Application_Ecommerce.App.Orders.Dtos;
using Application_Ecommerce.Core.Entities.Orders;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ecommerce.App.Orders.Mapping
{
    public class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        { 
          CreateMap<OrderHeader,  OrderHeaderDto>()
                .ReverseMap()
                 .ForMember(dest => dest.OrderDetails, opt => opt.Ignore());
            CreateMap<OrderDetails, OrderDetailsDto>()
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product != null ? src.Product.Name : string.Empty))
                .ForMember(dest => dest.ProductUrl, opt => opt.MapFrom(src => src.Product != null ? src.Product.ImageUrl : string.Empty))
                .ReverseMap()
                .ForMember(dest => dest.Product, opt => opt.Ignore());
        }

    }
}
