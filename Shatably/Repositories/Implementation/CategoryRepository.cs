using Shatably.data.Entities;
using Shatably.Data;
//using Shatably.Models;
using Shatably.Repositories.Interface;

namespace Shatably.Repositories.Implementation
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {


        }

    }
}
