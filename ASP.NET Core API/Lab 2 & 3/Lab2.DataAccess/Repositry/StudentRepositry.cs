using Lab2.DataAccess.Data;
using Lab2.Entities.Interfaces;
using System.Linq.Expressions;

namespace Lab2.DataAccess.Repositry
{
    public class StudentRepositry : GenericRepositry<Student>, IStudentRepositry
    {
        public StudentRepositry(AppDBContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Student>> GetWithPagination(int pageNo = 1, int pageSize = 10, Expression<Func<Student, bool>>? filter = null, string[]? IncludeWord = null)
        {
            var result = await GetAll(filter, IncludeWord);
            return result.Skip((pageNo - 1) * pageSize).Take(pageSize).ToList();

        }
    }
}
