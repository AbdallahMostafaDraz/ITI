using System;
using System.Collections.Generic;

namespace EFCore_Lab1.Entities;

public partial class Employee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? DepartmentId { get; set; }

    public virtual Department? Department { get; set; }
}
