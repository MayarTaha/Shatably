using Shatably.Data;
using Shatably.Models;
using Shatably.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Shatably.Repositories.Implementation
{
    public class SubCategoryRepository:GenericRepository<SubCategory>,ISubCategoryRepository
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
