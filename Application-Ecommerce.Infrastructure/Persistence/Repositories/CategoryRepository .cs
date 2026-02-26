using Application_Ecommerce.Core.Entities.Category;
using Application_Ecommerce.Core.Interfaces.Repositories;
using Application_Ecommerce.Infrastructure.Persistence.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace Application_Ecommerce.Infrastructure.Persistence.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<Category> AddAsync(Category category)
        {
            await _context.categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<Category> ReadByIdAsync(Guid categoryId)
        {
            var category = await _context.categories.FirstOrDefaultAsync(c => c.Id == categoryId);

            if (category == null)
                throw new KeyNotFoundException($"Catégorie introuvable: {categoryId}");

            return category;
        }

        public async Task<IEnumerable<Category>> ReadAllAsync()
        {
            return await _context.categories
                .OrderBy(c => c.Name)
                .ToListAsync();
        }

        public async Task<Guid?> GetCategoryIdByCategoryNameAsync(string categoryName)
        {
            var category = await _context.categories
                .FirstOrDefaultAsync(c => c.Name.ToLower() == categoryName.ToLower());

            return category?.Id;
        }

        public async Task Update(Category category)
        {
            _context.categories.Update(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid categoryId)
        {
            var category = await _context.categories.FindAsync(categoryId);

            if (category != null)
            {
                _context.categories.Remove(category);
                await _context.SaveChangesAsync();
            }
        }
    }
}
