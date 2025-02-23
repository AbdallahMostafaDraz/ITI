namespace Lab2.Repositries.Interfaces
{
    public interface IUnitOfWork
    {
        IDepartmentRepositry Department {  get; }
        IStudentRepositry Student { get; }
        IUserRepositry User { get; }
        IRoleRepositry Role { get; }
        int Complete();

    }
}
