using Application_Ecommerce.App.Cart.Dtos;
using Application_Ecommerce.Core.Entities.Cart;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ecommerce.App.Cart.Mapping
{
    public class CartMappingProfile : Profile
    {
        public CartMappingProfile() {

            // Map CartHeader <-> CartHeaderDto
            CreateMap<CartHeader, CartHeaderDto>().ReverseMap();

            // Map CartDetails <-> CartDetailsDto
            CreateMap<CartDetails, CartDetailsDto>().ReverseMap();
        }
    }
}
