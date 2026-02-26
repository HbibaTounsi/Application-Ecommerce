using Application_Ecommerce.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ecommerce.Core.Entities.Orders
{
    public class OrderDetails : BaseEntity
    {
        [Required]
        [ForeignKey("OrderHeader")]
        public Guid OrderHeaderId { get; set; }
        [Required]
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        public int Count { get; set; }
        public OrderHeader OrderHeader { get; set; }
        public Application_Ecommerce.Core.Entities.Product.Product Product { get; set; }





    }
}
