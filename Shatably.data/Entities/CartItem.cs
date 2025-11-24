using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shatably.Models
{
    public class CartItem
    {
        [Key]
        public int CartItemId { get; set; }

        [ForeignKey("Cart")]
        public int CartId { get; set; }

        [ForeignKey("StoreProduct")]
        public int StoreProductId { get; set; }

        public int Quantity { get; set; }

        // Relationships
        public Cart Cart { get; set; }
        public StoreProduct StoreProduct { get; set; }
    }
}
