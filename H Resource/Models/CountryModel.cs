using System;
using System.Collections.Generic;

namespace H_Resource.Models;

public partial class CountryModel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual EmployeeModel? Employee { get; set; }
}
