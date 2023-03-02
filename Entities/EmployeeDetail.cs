using System;
using System.Collections.Generic;

namespace EntityFrameworkPrac.Entities;

public partial class EmployeeDetail
{
    public string EmpId { get; set; } = null!;

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? Salary { get; set; }

    public string? Designation { get; set; }
}
