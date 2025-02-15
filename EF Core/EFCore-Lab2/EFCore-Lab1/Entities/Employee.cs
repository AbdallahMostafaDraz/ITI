
namespace EFCore_Lab1.Entities
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Department Department { get; set; }
        public int? DepartmentId { get; set; }
    }
}
