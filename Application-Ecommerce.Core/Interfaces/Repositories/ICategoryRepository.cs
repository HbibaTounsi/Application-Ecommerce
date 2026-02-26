using Application_Ecommerce.Core.Entities.Category;
using Application_Ecommerce.Core.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ecommerce.Core.Interfaces.Repositories
{
    public interface ICategoryRepository: IRepository<Category>
    {

        
            // Ajoute une nouvelle catégorie à la base de données
            Task<Category> AddAsync(Category category);

            // Récupère une catégorie par son identifiant
            Task<Category> ReadByIdAsync(Guid categoryId);

            // Récupère toutes les catégories existantes
            Task<IEnumerable<Category>> ReadAllAsync();

            // Trouve l'identifiant d'une catégorie à partir de son nom
            Task<Guid?> GetCategoryIdByCategoryNameAsync(string categoryName);

            // Met à jour une catégorie existante
            Task Update(Category category);

            // Supprime une catégorie par son identifiant
            Task DeleteAsync(Guid categoryId);
    }
}
