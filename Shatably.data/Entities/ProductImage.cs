using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shatably.Models
{
    public class ProductImage
    {
        [Key]
        public int ProductImageId { get; set; }
        public string ImageUrl{get;set;}
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
