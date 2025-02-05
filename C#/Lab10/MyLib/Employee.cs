namespace MyLib
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"[{Id}], {Name}, {Salary} EGP";
        }
    }
}
