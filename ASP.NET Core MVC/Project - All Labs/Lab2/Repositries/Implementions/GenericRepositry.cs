using Lab2.Data;
using Lab2.Repositries.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Lab2.Repositries.Implementions
{
    public class GenericRepositry<T> : IGenericRepositry<T> where T : class
    {
        private readonly AppDBContext _context;
        protected readonly DbSet<T> dbset;

        public GenericRepositry(AppDBContext context)
        {
            _context = context;
            dbset = _context.Set<T>();
        }

        public void Add(T item)
        {
            dbset.Add(item);
        }

        public void Edit(T item)
        {
            dbset.Update(item);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string[]? includeWords = null)
        {
            IQueryable<T> query = dbset;

            if (filter != null) 
                query = query.Where(filter);

            if (includeWords != null)
                foreach(var word in includeWords)
                    query = query.Include(word);
                    
            return query;
        }

        public T GetOne(Expression<Func<T, bool>>? filter = null, string[]? includeWords = null)
        {
            IQueryable<T> query = dbset;

            if (filter != null)
                query = query.Where(filter);

            if (includeWords != null)
                foreach(var word in includeWords)
                    query = query.Include(word);

            return query.FirstOrDefault();
        }

        public void Remove(T item)
        {
            dbset.Remove(item);
        }
    }
}
