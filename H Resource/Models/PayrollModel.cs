using System;
using System.Collections.Generic;

namespace H_Resource.Models;

public partial class Payroll
{
    public int PayrollId { get; set; }

    public int EmployeeId { get; set; }

    public decimal BaseSalary { get; set; }

    public decimal? Deductions { get; set; }

    public decimal? Perks { get; set; }

    public DateTime? EntryDate { get; set; }

    public DateTime? ExitDate { get; set; }

    public virtual EmployeeModel Employee { get; set; } = null!;
}
