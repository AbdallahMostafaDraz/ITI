using System.Linq.Expressions;

namespace Lab2.Repositries.Interfaces
{
    public interface IGenericRepositry<T>
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string[]? includeWords = null);
        T GetOne(Expression<Func<T, bool>>? filter = null, string[]? includeWords = null);
        void Add(T item);
        void Remove(T item);
        void Edit(T item);
    }
}
