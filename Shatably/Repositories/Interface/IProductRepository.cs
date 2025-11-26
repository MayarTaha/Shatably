using Shatably.Models;

namespace Shatably.Repositories.Interface
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsBySubCategoryIdAsync(int SubCategoryId);

    }
}
