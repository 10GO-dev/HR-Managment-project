using System;
using System.Collections.Generic;

namespace H_Resource.Models;

public partial class UserModel
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;
}
