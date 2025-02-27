using Lab2.DataAccess.Data;
using Lab2.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Lab2.DataAccess.Repositry
{
    public class GenericRepositry<T> : IGenericRepositry<T> where T : class
    {
        private readonly AppDBContext _context;
        private readonly DbSet<T> _dbSet;
        public GenericRepositry(AppDBContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>>? filter = null, string[]? IncludeWord = null)
        {
            IQueryable<T> query = _dbSet;

            if (filter != null)
                query = query.Where(filter);

            if (IncludeWord != null)
                foreach (var item in IncludeWord)
                    query = query.Include(item);
             
            return await query.ToListAsync();
        }
        public async Task<T> Get(Expression<Func<T, bool>> filter, string[]? IncludeWord = null)
        {

            IQueryable<T> query = _dbSet;

            if (filter != null)
                query = query.Where(filter);

            if (IncludeWord != null)
                foreach (var item in IncludeWord)
                    query = query.Include(item);

            return await query.FirstOrDefaultAsync();
        }
        public async Task<T> Add(T item)
        {
           await _dbSet.AddAsync(item);
           return item;
        }

        public T Delete(T item)
        {
            _dbSet.Remove(item);
            return item;
        }

        public T Update(T item)
        {
            _dbSet.Update(item);
            return item;
        }
    }
}
