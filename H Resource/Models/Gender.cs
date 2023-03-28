using System;
using System.Collections.Generic;

namespace H_Resource.Models;

public partial class Gender
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual Employee? Employee { get; set; }
}
