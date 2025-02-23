using Lab2.Data;
using Lab2.Models;
using Lab2.Repositries.Interfaces;
using System.Linq.Expressions;

namespace Lab2.Repositries.Implementions
{
    public class StudentRepositry : GenericRepositry<Student>, IStudentRepositry
    {
        public StudentRepositry(AppDBContext context) : base(context) { }
        public bool CheckEmail(Expression<Func<Student, bool>> filter)
        {
           return dbset.Where(filter).Any();
        }
    }
}
