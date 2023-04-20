using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Resource.Models.Request
{
    public class EmployeeVacationViewModel
    {
        [Browsable(false)]
        public int VacationId { get; set; }
        [Browsable(false)]
        public int EmployeeId { get; set; }
        [DisplayName("Nombre")]
        public string FullName { get; set; }
        [DisplayName("Días disponibles")]
        public int? AvailableDays { get; set; }
    }

}
