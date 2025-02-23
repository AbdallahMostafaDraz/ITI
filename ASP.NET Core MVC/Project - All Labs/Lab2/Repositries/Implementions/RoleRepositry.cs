using Lab2.Data;
using Lab2.Models;
using Lab2.Repositries.Interfaces;

namespace Lab2.Repositries.Implementions
{
    public class RoleRepositry : GenericRepositry<Role>, IRoleRepositry
    {
        public RoleRepositry(AppDBContext context) : base(context) { }
    }
}
