using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace H_Resource.Models;

public partial class EmployeeModel
{
    [DisplayName("Employee ID")]
    public int EmployeeId { get; set; }

    [DisplayName("First Name")]
    [Required(ErrorMessage ="El campo nombre es requerido")]
    [StringLength(20,MinimumLength =3, ErrorMessage ="El nombre debe tener entre 5 y 20 carácteres")]
    public string FirstName { get; set; } = null!;

    [DisplayName("Last Name")]
    [Required(ErrorMessage = "El campo apellido es requerido")]
    [StringLength(20, MinimumLength = 3, ErrorMessage = "El apellido debe tener entre 5 y 20 carácteres")]
    public string LastName { get; set; } = null!;

    [DisplayName("BirthDate")]
    [Required(ErrorMessage ="La fecha de nacimiento es requerida")]
    public DateTime? BirthDate { get; set; }

    public int? GenderId { get; set; }

    public string? MaritalStatus { get; set; }
    [DisplayName("Address")]
    public string? Address { get; set; }
    [DisplayName("Phone")]
    [Required(ErrorMessage ="El teléfono es requerido")]
    public string Phone { get; set; } = null!;
    [DisplayName("Email")]
    [Required(ErrorMessage ="El correo es requerdio")]
    public string Email { get; set; } = null!;
    [DisplayName("Image")]
    public byte[]? Image { get; set; }
    [DisplayName("Hire Date")]
    public DateTime? HireDate { get; set; }

    public int? DepartmentId { get; set; }

    public int? CountryId { get; set; }
    [DisplayName("Department")]
    public virtual DepartmentModel? Department { get; set; }
    [DisplayName("Gender")]
    public virtual GenderModel Employee1 { get; set; } = null!;
    [DisplayName("Country")]
    public virtual CountryModel EmployeeNavigation { get; set; } = null!;

    public virtual ICollection<PayrollModel> Payrolls { get; } = new List<PayrollModel>();

    public virtual ICollection<VacationModel> Vacations { get; } = new List<VacationModel>();
}
