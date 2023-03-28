using System;
using System.Collections.Generic;

namespace H_Resource.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime? BirthDate { get; set; }

    public int? GenderId { get; set; }

    public string? MaritalStatus { get; set; }

    public string? Address { get; set; }

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public byte[]? Image { get; set; }

    public DateTime? HireDate { get; set; }

    public int? DepartmentId { get; set; }

    public int? CountryId { get; set; }

    public virtual Department? Department { get; set; }

    public virtual Gender Employee1 { get; set; } = null!;

    public virtual Country EmployeeNavigation { get; set; } = null!;

    public virtual ICollection<Payroll> Payrolls { get; } = new List<Payroll>();

    public virtual ICollection<Vacation> Vacations { get; } = new List<Vacation>();
}
