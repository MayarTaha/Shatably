using Microsoft.EntityFrameworkCore;
using Shatably.data.Entities;
using Shatably.Data;
using Shatably.Repositories.Interface;

namespace Shatably.Repositories.Implementation
{
    public class SubCategoryRepository : GenericRepository<SubCategory>, ISubCategoryRepository
    {
        public SubCategoryRepository(AppDbContext context) : base(context)
        {

        }
        public async Task<IEnumerable<SubCategory>> GetSubCategoryByCategoryIdAsync(int CategoryId)
        {
            return await _context.SubCategories
               .Where(sc => sc.CategoryId == CategoryId)
                .ToListAsync();

        }


    }
}
