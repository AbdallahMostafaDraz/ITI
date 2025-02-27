using System;
using System.Collections.Generic;

namespace Lab2.DataAccess;

public partial class Department
{
    public int DeptId { get; set; }

    public string? DeptName { get; set; }

    public string? DeptDesc { get; set; }

    public string? DeptLocation { get; set; }

    public int? DeptManager { get; set; }

    public DateOnly? ManagerHiredate { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
