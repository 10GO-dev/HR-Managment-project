using System;
using System.Collections.Generic;

namespace H_Resource.Models;

public partial class CountryModel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<EmployeeModel> Employees { get; } = new List<EmployeeModel>();
}
