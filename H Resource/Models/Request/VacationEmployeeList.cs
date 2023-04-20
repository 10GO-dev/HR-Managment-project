using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Resource.Models.Request
{
    public class VacationEmployeeList
    {
        [Browsable(false)]
        public int? VacationID { get; set; }
        [Browsable(false)]
        public int EmployeeId { get; set; }
        [DisplayName("Nombre Completo")]
        public string FullName { get; set; } = null!;

        [Browsable(false)]
        public string Department { get; set; } = null!;
        [Browsable(false)]
        public DateTime? HireDate { get; set; }

        [Browsable(false)]
        public string Document { get; set; } = null!;

        [Browsable(false)]
        public byte[]? Image { get; set; }
        [DisplayName("Fecha Inicio")]
        public DateTime? StartDate { get; set; }
        [DisplayName("Fecha Fin")]
        public DateTime? EndDate { get; set; }

        [DisplayName("Días tomados")]
        public int? TakenDays { get; set; }
        [Browsable(false)]
        public int? AvailableDays { get; set; }

    }
}
