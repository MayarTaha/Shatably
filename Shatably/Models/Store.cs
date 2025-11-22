
using Shatably.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Shatably.Models
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
