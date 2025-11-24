using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shatably.Models
{
    public class SubCategory
    {
        public string Name { get; set; }
        [Key]
        public int SubCategoryId { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Product> Products { get; set; }
    }

}