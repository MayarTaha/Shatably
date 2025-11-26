using Microsoft.EntityFrameworkCore;
using Shatably.data.Entities;
using Shatably.Data;
using Shatably.Repositories.Interface;

namespace Shatably.Repositories.Implementation
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {


        }
        public async Task<IEnumerable<Product>> GetProductsBySubCategoryIdAsync(int SubCategoryId)
        {
            return await _context.Products
               .Where(p => p.SubCategoryId == SubCategoryId)
               .ToListAsync();
        }

    }
}
