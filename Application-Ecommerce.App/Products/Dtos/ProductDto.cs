using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Application_Ecommerce.App.Products.Dtos
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public int Count { get; set; } = 1;
        [Display(Name = "Catégorie")]
        public string CategoryName { get; set; }
        public IFormFile? ImageFile { get; set; }

    }
}
