namespace Lab2.Repositries.Interfaces
{
    public interface IUnitOfWork
    {
        IDepartmentRepositry Department {  get; }
        IStudentRepositry Student { get; }
        int Complete();

    }
}
