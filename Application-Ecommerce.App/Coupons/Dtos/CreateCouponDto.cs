using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ecommerce.App.Coupons.Dtos
{
    public class CreateCouponDto
    {
        [Required]
        [MaxLength(50)]
        public string CouponCode { get; set; }

        [Required]
        public decimal DiscountAmount { get; set; }

        [Required]
        public decimal MinimumAmount { get; set; }
    }
}
