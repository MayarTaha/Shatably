
using System.ComponentModel.DataAnnotations;


namespace Shatably.data.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }

    }

}









