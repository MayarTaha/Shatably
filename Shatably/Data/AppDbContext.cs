using Microsoft.EntityFrameworkCore;

namespace Shatably.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    }
}
