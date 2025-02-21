using Lab2.Data;
using Lab2.Models;
using Lab2.Repositries.Interfaces;

namespace Lab2.Repositries.Implementions
{
    public class DepartmentReposeitry : GenericRepositry<Department>, IDepartmentRepositry
    {
        public DepartmentReposeitry(AppDBContext context) : base(context) { }
    }
}
