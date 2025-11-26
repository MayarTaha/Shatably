using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shatably.data.Entities
{
    public class StoreLocation
    {
        [Key]
        public int LocationId { get; set; }

        [ForeignKey("Store")]
        public int StoreId { get; set; }

        [Required, MaxLength(50)]
        public string Country { get; set; }

        [Required, MaxLength(50)]
        public string City { get; set; }

        [Required, MaxLength(100)]
        public string Street { get; set; }

        // Relationship
        public Store Store { get; set; }
    }
}
