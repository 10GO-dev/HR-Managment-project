using System;
using System.Collections.Generic;

namespace H_Resource.Model;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime? BirthDate { get; set; }

    public string Gender { get; set; } = null!;

    public string? MaritalStatus { get; set; }

    public string? Address { get; set; }

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public byte[]? Image { get; set; }

    public DateTime? HireDate { get; set; }

    public int DepartmentId { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual ICollection<Payroll> Payrolls { get; } = new List<Payroll>();

    public virtual ICollection<Vacation> Vacations { get; } = new List<Vacation>();
}
