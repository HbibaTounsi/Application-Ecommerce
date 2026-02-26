using Application_Ecommerce.Models.Home;
using AutoMapper;
using Application_Ecommerce.App.Products.Dtos;


namespace Application_Ecommerce.Mapping.Home
{
    public class HomeMappingProfile : Profile
    {
        public HomeMappingProfile()
        {
            CreateMap<HomeProductViewModel, ProductDto>().ReverseMap();
        }
    }
}
