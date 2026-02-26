using Application_Ecommerce.App.Categories.Dtos;
using Application_Ecommerce.Models.Category;
using AutoMapper;

namespace Application_Ecommerce.Mapping.Category
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            // Index
            CreateMap<CategoryDto, CategoryViewModel>().ReverseMap();

            // Create
            CreateMap<CreateCategoryViewModel, CreateCategoryDto>();

            // Edit
            CreateMap<CategoryDto, EditCatgoryViewModel>().ReverseMap();
            CreateMap<EditCatgoryViewModel, UpdateCategoryDto>();

            // Delete
            CreateMap<CategoryDto, DeleteCategoryViewModel>().ReverseMap();
        }
    }
}
