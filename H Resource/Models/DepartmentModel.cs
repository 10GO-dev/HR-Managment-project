using System;
using System.Collections.Generic;

namespace H_Resource.Models;

public partial class DepartmentModel
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public virtual ICollection<EmployeeModel> Employees { get; } = new List<EmployeeModel>();
}
