using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Resource.Models.Request
{
    public class EmployeePayrollModel
    {
        [DisplayName("Nombre Completo")]
        public string FullName { get; set; } = null!;
        [DisplayName("Departamento")]
        public string Department { get; set; } = null!;
        [DisplayName("Salario Base")]
        public decimal BaseSalary { get; set; }
        [DisplayName("Impuestos")]
        public decimal? Deductions { get; set; }
        [DisplayName("Bonos")]
        public decimal? Perks { get; set; }
        [DisplayName("Salario Neto")]
        public decimal? NetoSalary { get; set; }
    }
}
