using Lab2.Data;
using Lab2.Models;
using Lab2.Repositries.Interfaces;
using System.Linq.Expressions;

namespace Lab2.Repositries.Implementions
{
    public class UserRepositry : GenericRepositry<User>, IUserRepositry, IEmailCheck<User>
    {
        public UserRepositry(AppDBContext context) : base(context) { }

        public bool CheckEmail(Expression<Func<User, bool>> filter)
        {
            return dbset.Where(filter).Any();
        }
    }
}
