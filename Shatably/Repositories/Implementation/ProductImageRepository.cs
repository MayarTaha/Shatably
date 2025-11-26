using Microsoft.EntityFrameworkCore;
using Shatably.Data;
using Shatably.Models;
using Shatably.Repositories.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
               .Where(PI=> PI.ProductId == ProductId)
                .ToListAsync();

        }
    }
}
