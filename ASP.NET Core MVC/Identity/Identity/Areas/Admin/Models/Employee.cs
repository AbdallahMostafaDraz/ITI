namespace Identity.Areas.Admin.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Salary { get; set; }
    }
}
