
namespace Lab2.Entities.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepositry Students { get; }
        IDepartmentRepositry Departments { get; }

        Task<int> Complete();
    }
}
