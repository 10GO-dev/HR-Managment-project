using System;
using System.Collections.Generic;

namespace H_Resource.Models;

public partial class VacationModel
{
    public int VacationId { get; set; }

    public int? EmployeeId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? AvailableDays { get; set; }

    public int? TakenDays { get; set; }

    public virtual EmployeeModel? Employee { get; set; }
}
