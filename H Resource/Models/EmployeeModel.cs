using System.ComponentModel.DataAnnotations;

namespace H_Resource.Models;

public partial class EmployeeModel
{
    public int EmployeeId { get; set; }
    [Required(ErrorMessage = "El nombre es requerido")]
    [StringLength(20, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 5 y 20 carácteres")]
    public string FirstName { get; set; } = null!;
    [Required(ErrorMessage = "El apellido es requerido")]
    [StringLength(40, MinimumLength = 3, ErrorMessage = "El apellido debe tener entre 5 y 40 carácteres")]
    public string LastName { get; set; } = null!;
    [Required(ErrorMessage = "La cédula es requerida")]
    [StringLength(11, MinimumLength = 11, ErrorMessage = "Numero de documento inválido")]
    public string DocumentId { get; set; } = null!;

    public DateTime? BirthDate { get; set; }
    [Required(ErrorMessage = "El género es requerido")]

    public int GenderId { get; set; }
    public string? MaritalStatus { get; set; }
    public string? Address { get; set; }
    [Required(ErrorMessage = "El teléfono es requerido")]
    [StringLength(10, MinimumLength = 10, ErrorMessage = "teléfono inválido")]
    [Phone]
    public string Phone { get; set; } = null!;
    [Required(ErrorMessage = "El correo es requerido")]
    [EmailAddress]
    public string Email { get; set; } = null!;
    public byte[]? Image { get; set; }
    public DateTime? HireDate { get; set; }
    [Required(ErrorMessage = "El departamento es requerido")]
    public int DepartmentId { get; set; }
    [Required(ErrorMessage = "El nacionalidad es requerida")]
    public int CountryId { get; set; }
    public int? AvailableDays { get; set; }

    public virtual CountryModel Country { get; set; } = null!;
    public virtual DepartmentModel Department { get; set; } = null!;
    public virtual GenderModel Gender { get; set; } = null!;

    public virtual ICollection<PayrollModel> Payrolls { get; } = new List<PayrollModel>();

    public virtual ICollection<VacationModel> Vacations { get; } = new List<VacationModel>();
}
