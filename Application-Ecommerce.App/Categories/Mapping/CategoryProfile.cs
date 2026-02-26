using Application_Ecommerce.App.Categories.Dtos;
using AutoMapper;
using Application_Ecommerce.Core.Entities.Category;

namespace Application_Ecommerce.App.Categories.Mapping
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            // Mapping between entity and DTO
            CreateMap<Category, CategoryDto>().ReverseMap();

            // Mapping for creation operation
            CreateMap<CreateCategoryDto, Category>();

            // Mapping for update operation
            CreateMap<UpdateCategoryDto, Category>();
        }

    }
}
