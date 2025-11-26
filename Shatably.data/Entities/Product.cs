

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shatably.data.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [ForeignKey("SubCategory")]
        public int SubCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public SubCategory SubCategory { get; set; }
        public ICollection<StoreProduct> StoreProducts { get; set; }
        public ICollection<ProductImage> ProductImage { get; set; }
        public ICollection<PackageItem> PackageItems { get; set; }
        public ICollection<Review> Reviews { get; set; }




    }
}








