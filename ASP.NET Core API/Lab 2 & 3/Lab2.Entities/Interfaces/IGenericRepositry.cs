using System.Linq.Expressions;

namespace Lab2.Entities.Interfaces
{
    public interface IGenericRepositry<T> where T : class
    {
        Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>>? filter = null, string[]? IncludeWord = null);
        Task<T> Get(Expression<Func<T, bool>> filter, string[]? IncludeWord = null);
        Task<T> Add(T item);
        T Update(T item);
        T Delete(T item);
    }
}
