using Lab2.DataAccess;
using System.Linq.Expressions;

namespace Lab2.Entities.Interfaces
{
    public interface IStudentRepositry : IGenericRepositry<Student>
    {
        Task<IEnumerable<Student>> GetWithPagination(int pageNo = 1, int pageSize = 10, Expression<Func<Student, bool>>? filter = null, string[]? IncludeWord = null);
    }
}
