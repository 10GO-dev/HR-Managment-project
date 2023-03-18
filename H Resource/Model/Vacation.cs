using System;
using System.Collections.Generic;

namespace H_Resource.Model;

public partial class Vacation
{
    public int VacationId { get; set; }

    public int? EmployeeId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? AvailableDays { get; set; }

    public int? TakenDays { get; set; }

    public virtual Employee? Employee { get; set; }
}
