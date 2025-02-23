using Lab2.Models;
using System.Linq.Expressions;

namespace Lab2.Repositries.Interfaces
{
    public interface IEmailCheck<T> where T : class
    {
        bool CheckEmail(Expression<Func<T, bool>> filter);
    }
}
