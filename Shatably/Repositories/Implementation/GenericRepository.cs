using Microsoft.EntityFrameworkCore;
using Shatably.Data;
using Shatably.Repositories.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shatably.Repositories.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _DbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _DbSet = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _DbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _DbSet.FindAsync(id);
        }

        public async Task AddAsync(T entity)
        {
            await _DbSet.AddAsync(entity);
        }

        public void Update(T entity)
        {
            _DbSet.Update(entity);
        }

        public void Delete(T entity)
        {
            _DbSet.Remove(entity);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
