using System.ComponentModel.DataAnnotations;


namespace Shatably.data.Entities
{
    public class Store
    {
        [Key]
        public int StoreId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(20)]
        public string Phone { get; set; }

        // Relationships
        public ICollection<StoreLocation> StoreLocations { get; set; }
        public ICollection<StoreProduct> StoreProducts { get; set; }
    }

}
