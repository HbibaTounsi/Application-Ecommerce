using Application_Ecommerce.App.Categories.Dtos;
using Application_Ecommerce.Models.Category;
using AutoMapper;

namespace Application_Ecommerce.Mapping.Category
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            // Mapping pour CategoryViewModel <-> CategoryDto
            CreateMap<CategoryViewModel, CategoryDto>().ReverseMap();

            CreateMap<DeleteCategoryViewModel, CategoryDto>().ReverseMap();

            CreateMap<CreateCategoryViewModel, CreateCategoryDto>();
            CreateMap<EditCatgoryViewModel, UpdateCategoryDto>().ReverseMap();
        }
    }
}
