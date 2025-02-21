using Lab2.Data;
using Lab2.Repositries.Interfaces;

namespace Lab2.Repositries.Implementions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDBContext _context;
        public IDepartmentRepositry Department { get; private set; }
        public IStudentRepositry Student { get; private set; }

        public UnitOfWork(AppDBContext context)
        {
            _context = context;
            Department = new DepartmentReposeitry(_context);
            Student = new StudentRepositry(_context);
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
