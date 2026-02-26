using Application_Ecommerce.Core.Entities.Cart;
using Application_Ecommerce.Core.Entities.Orders;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Application_Ecommerce.Core.Entities.Identity
{
    public class ApplicationUser : IdentityUser 
    {
        [Required]
        [Range(1000, 99999, ErrorMessage = "Le code postal doit être entre 1000 et 99999.")]
        public int ZipCode { get; set; }

        // Adresse complète de l'utilisateur, utilisée pour la livraison
        [Required(ErrorMessage = "L'adresse est requise.")]
        [StringLength(255, ErrorMessage = "L'adresse ne peut pas dépasser 255 caractères.")]
        public string? Address { get; set; }

        // Collection des paniers de l'utilisateur (généralement un seul actif)
        public ICollection<CartHeader> CartHeaders { get; set; }

        // Collection des commandes passées par l'utilisateur (historique des achats)
        public ICollection<OrderHeader> OrderHeaders { get; set; }

    }
}
