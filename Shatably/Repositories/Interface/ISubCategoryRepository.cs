using Shatably.Models;

namespace Shatably.Repositories.Interface
{
    public interface ISubCategoryRepository:IGenericRepository<SubCategory>
    {
        Task<IEnumerable<SubCategory>>GetSubCategoryByCategoryIdAsync(int CategoryId);

    }
}
