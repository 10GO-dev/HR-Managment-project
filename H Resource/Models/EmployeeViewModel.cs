using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H_Resource.Models;

namespace H_Resource.Views
{
    public class EmployeeViewModel
    {

        [DisplayName("Nombre Completo")]
        public string FullName { get; set; } = null!;
        [DisplayName("Departamento")]
        public string Department { get; set; } = null!;
        [DisplayName("Cédula")]
        public string Document { get; set; } = null!;
        [DisplayName("Teléfono")]
        public string Phone { get; set; } = null!;
        [DisplayName("Email")]
        public string Email { get; set; } = null!;
        [DisplayName("Fecha de Nacimiento")]
        public DateTime? BirthDate { get; set; }
        [DisplayName("Dirección")]
        public string? Address { get; set; }
        [DisplayName("Fecha de Contratación")]
        public DateTime? HireDate { get; set; }
        [DisplayName("Género")]
        public string Gender { get; set; } = null!;
        [DisplayName("Nacionalidad")]
        public string Nationality { get; set; } = null!;
        [Browsable(false)]
        public int GenderId { get; set; }
        [Browsable(false)]
        public int EmployeeId { get; set; }
        [Browsable(false)]
        public int DepartmentId { get; set; }
        [Browsable(false)]
        public int CountryId {  get; set; }
    }
}
