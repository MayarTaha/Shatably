using Shatably.Models;

namespace Shatably.Repositories.Interface
{
  
        public interface IProductImageRepository : IGenericRepository<ProductImage>
        {
        Task<IEnumerable<ProductImage>> GetProductImageByProductIdAsync(int ProductId);

        }
    
}
