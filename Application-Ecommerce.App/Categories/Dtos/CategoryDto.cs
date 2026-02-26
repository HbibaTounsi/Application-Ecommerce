using System.ComponentModel.DataAnnotations;

namespace Application_Ecommerce.App.Categories.Dtos
{
    public class CategoryDto 
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The Category name cannot exceed 100 characters.")]
        public string Name { get; set; }

        [StringLength(500, ErrorMessage = "The description cannot exceed 500 characters.")]
        public string Description { get; set; }
    }
}
