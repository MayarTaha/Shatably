using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shatably.Models
{
    public class StoreProduct
    {
        [Key]
        public int StoreProductId { get; set; }

        [ForeignKey("Store")]
        public int StoreId { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int Stock { get; set; }

        public int DeliveryTime { get; set; } // days

        // Relationships
        public Store Store { get; set; }
        public Product Product { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
    }
}
