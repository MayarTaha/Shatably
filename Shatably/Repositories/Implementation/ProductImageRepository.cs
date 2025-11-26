using Microsoft.EntityFrameworkCore;
using Shatably.data.Entities;
using Shatably.Data;
using Shatably.Repositories.Interface;

namespace Shatably.Repositories.Implementation
{


    public class ProductImageRepository : GenericRepository<ProductImage>, IProductImageRepository

    {
        public ProductImageRepository(AppDbContext context) : base(context)
        {

        }
        public async Task<IEnumerable<ProductImage>> GetProductImageByProductIdAsync(int ProductId)
        {
            return await _context.ProductImages
               .Where(PI => PI.ProductId == ProductId)
                .ToListAsync();

        }
    }
}
