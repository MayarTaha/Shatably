using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shatably.data.Entities
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        // Relationships
        public User User { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
    }
}
