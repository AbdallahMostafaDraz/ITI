using Lab2.Models;
using System.Linq.Expressions;

namespace Lab2.Repositries.Interfaces
{
    public interface IStudentRepositry : IGenericRepositry<Student>
    {
        public bool CheckEmail(Expression<Func<Student, bool>> filter);

    }
}
