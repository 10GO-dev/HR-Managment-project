using H_Resource._Repositories;
using H_Resource.Models;
using H_Resource.Models.Request;
using H_Resource.Views;
using System.Runtime.CompilerServices;

namespace H_Resource.Presenters
{
    public class EmployeePresenter
    {
        //Fields
        private IEmployeeView view;
        private IEmployeeRepository repository;
        private BindingSource EmployeeBindingSource;
        private static IEnumerable<EmployeeModel?> employeeList;

        public EmployeePresenter(IEmployeeView view, IEmployeeRepository repository)
        {
            this.EmployeeBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Suscribe event handler methods to view events
            this.view.SearchEvent += SearchEmployee;
            this.view.AddNewEvent += AddNewEmployee;
            this.view.EditEvent += LoadSelectedEmployeeToEdit;
            this.view.DeleteEvent += DeleteSelectedEmployee;
            this.view.ShowHomeView += ShowHomeView;
            //Set employee binding source
            this.view.SetEmployeeListBindingSource(EmployeeBindingSource);
            //Load employee list view
            LoadAllEmployeeList();                                                               
            this.view.Show();
        }

        private void ShowHomeView(object? sender, EventArgs e)
        {
            MainContainer mainContainer = MainContainer.GetInstance();
            IHomeView view = HomeView.GetInstance(mainContainer);
            mainContainer.AddView((Form)view);
            new HomePresenter(view);
            this.view.SearchEvent -= SearchEmployee;
            this.view.AddNewEvent -= AddNewEmployee;
            this.view.EditEvent -= LoadSelectedEmployeeToEdit;
            this.view.DeleteEvent -= DeleteSelectedEmployee;
            this.view.ShowHomeView -= ShowHomeView;
            this.view.Close();
        }

        private async void LoadAllEmployeeList()
        {
            if(employeeList == null || !view.IsCached)
            {
                employeeList = await repository.GetAllAsync();
            }
            List<EmployeeViewModel> employeeViewList = employeeList.Select(e => new EmployeeViewModel
            {
                EmployeeId = e.EmployeeId,
                FullName = e.FirstName + " " + e.LastName,
                Department = e.Department.DepartmentName,
                Document = e.DocumentId,
                Phone = e.Phone,
                Email = e.Email,
                Nationality = e.Country.Name,
                BirthDate = e.BirthDate,
                HireDate = e.HireDate,
                Address = e.Address,
                Gender = e.Gender.Name,
                GenderId = e.GenderId,
                DepartmentId = e.DepartmentId,
                CountryId = e.CountryId
            }).ToList();
            view.IsCached = true;
            EmployeeBindingSource.DataSource = employeeViewList;
        }


        private async void LoadSelectedEmployeeToEdit(object? sender, EventArgs e)
        {
            var employeeListSc = EmployeeBindingSource.DataSource as List<EmployeeViewModel>;
            EmployeeViewModel selectedEmployee = employeeListSc[this.view.SelectedEmployeeIndex];
            if (selectedEmployee != null)
            {
                MainContainer mainContainer = MainContainer.GetInstance();
                EmployeeModel? employeeToEdit = employeeList.FirstOrDefault(e => e.EmployeeId == selectedEmployee.EmployeeId) ?? repository.GetAsync(selectedEmployee.EmployeeId);
                if (employeeToEdit != null)
                {

                    EmployeeDetailView view = EmployeeDetailView.GetInstance();
                    _ = new EmployeeDetailPresenter(view, repository);

                    view.IsEdit = true;
                    view.EmployeeId = employeeToEdit.EmployeeId.ToString();
                    view.FirstName = employeeToEdit.FirstName;
                    view.LastName = employeeToEdit.LastName;
                    view.Email = employeeToEdit.Email;
                    view.Phone = employeeToEdit.Phone;
                    view.Address = employeeToEdit.Address;
                    view.GenderId = employeeToEdit.GenderId;
                    view.DepartmentId = employeeToEdit.DepartmentId;
                    view.DocuemntId = employeeToEdit.DocumentId;
                    view.CountryId = employeeToEdit.CountryId;
                    view.BirthDate = employeeToEdit.BirthDate != null ? (DateTime)employeeToEdit.BirthDate : DateTime.Today;
                    view.HireDate = employeeToEdit.HireDate != null ? (DateTime)employeeToEdit.HireDate : DateTime.Today;
                    view.Salary = (int)employeeToEdit.Payrolls.First().BaseSalary;
                    if (employeeToEdit.Image != null)
                    {
                        byte[] imageBytes = employeeToEdit.Image;
                        using (MemoryStream ms = new(imageBytes))
                        {
                            view.Image = Image.FromStream(ms);
                        };
                    }
                    view.setTitle("Editar Empleado");
                    mainContainer.AddView(view);
                    this.view.Close();
                    
                }
                else
                {
                    this.view.Message = "No se pudeo cargar el empleado";
                }
            }
        }

        private async void DeleteSelectedEmployee(object? sender, EventArgs e)
        {
            // obtener el empleado seleccionado
            var employee = (EmployeeViewModel)EmployeeBindingSource.Current;

            // mostrar mensaje de confirmación antes de eliminar
            var confirmResult = MessageBox.Show($"¿Está seguro de eliminar al empleado {employee.FullName}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // obtener el empleado desde el repositorio
                    var employeeToDelete = repository.GetAsync(employee.EmployeeId);
                    if (employeeToDelete != null)
                    {
                        // eliminar el empleado
                        await repository.DeleteAsync(employeeToDelete);
                        MessageBox.Show("Empleado eliminado correctamente!");
                        employeeList = null;
                        // recargar la lista de empleados
                        LoadAllEmployeeList();
                    }
                    else
                    {
                        MessageBox.Show($"No se pudo encontrar al empleado con ID {employee.EmployeeId}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al intentar eliminar al empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void AddNewEmployee(object? sender, EventArgs e)
        {
            
            MainContainer mainContainer = MainContainer.GetInstance();
            EmployeeDetailView view = EmployeeDetailView.GetInstance();
            mainContainer.AddView(view);
            view.IsEdit = false;
            view.setTitle("Añadir Empleado");
            _ = new EmployeeDetailPresenter(view, repository);
            this.view.SearchEvent -= SearchEmployee;
            this.view.AddNewEvent -= AddNewEmployee;
            this.view.EditEvent -= LoadSelectedEmployeeToEdit;
            this.view.DeleteEvent -= DeleteSelectedEmployee;
            this.view.ShowHomeView -= ShowHomeView;
            this.view.Close();
        }

        private async void SearchEmployee(object? sender, EventArgs e)
        {

            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            bool emptyCriteria = string.IsNullOrWhiteSpace(this.view.SearchCriteria);
           
            if (!emptyValue && !emptyCriteria)
            {   
                employeeList = await repository.FindByValueAsync(this.view.SearchCriteria, this.view.SearchValue);

            }
            else employeeList = await repository.GetAllAsync();

            List<EmployeeViewModel> employeeViewList = employeeList.Select(e => new EmployeeViewModel
            {
                EmployeeId = e.EmployeeId,
                FullName = e.FirstName + " " + e.LastName,
                Department = e.Department.DepartmentName,
                Document = e.DocumentId,
                Phone = e.Phone,
                Email = e.Email,
                Nationality = e.Country.Name,
                BirthDate = e.BirthDate,
                HireDate = e.HireDate,
                Address = e.Address,
                Gender = e.Gender.Name,
                GenderId = e.GenderId,
                DepartmentId = e.DepartmentId,
                CountryId = e.CountryId

            }).ToList();
            EmployeeBindingSource.DataSource = employeeViewList;
        }
    }
}
