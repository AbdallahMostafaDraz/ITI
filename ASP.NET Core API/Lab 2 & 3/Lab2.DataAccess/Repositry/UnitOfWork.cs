using Lab2.DataAccess.Data;
using Lab2.Entities.Interfaces;

namespace Lab2.DataAccess.Repositry
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDBContext _context;
        private  IStudentRepositry students = null!;
        private  IDepartmentRepositry departments = null!;

        public IStudentRepositry Students 
        { 
            get
            {
                if (students == null)
                    students = new StudentRepositry(_context);
                return students;
            }
        }

        public IDepartmentRepositry Departments 
        { 
            get
            {
                if (departments == null)
                    departments = new DepartmentRepositry(_context);
                return departments;
            }
        }

        public UnitOfWork(AppDBContext context)
        {
            _context = context;
        }
        public Task<int> Complete()
        {
            return _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.DisposeAsync();
        }
    }
}
