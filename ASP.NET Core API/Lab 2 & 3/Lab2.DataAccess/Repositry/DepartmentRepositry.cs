using Lab2.DataAccess.Data;
using Lab2.Entities.Interfaces;

namespace Lab2.DataAccess.Repositry
{
    public class DepartmentRepositry : GenericRepositry<Department>, IDepartmentRepositry
    {
        public DepartmentRepositry(AppDBContext context) : base(context)
        {
        }
    }
}
